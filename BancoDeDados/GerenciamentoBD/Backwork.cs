using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace BancoDeDados.GerenciamentoBD
{
    interface ICRUD
    {
        bool IsNew { get; }
        bool IsModified { get; }
    }

    public abstract class Backwork<T> where T : Backwork<T>, new()
    {
        public static object ChangeType(object value, Type conversionType)
        {
            if (conversionType == null)
            {
                throw new ArgumentNullException("conversionType");
            }

            if (conversionType.IsGenericType && conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return null;
                }

                NullableConverter nullableConverter = new NullableConverter(conversionType);
                conversionType = nullableConverter.UnderlyingType;
            }
            return Convert.ChangeType(value, conversionType);
        }

        public static T ConvertRowToEntity(SqlDataReader dr)
        {
            T _return = new T();

            foreach (PropertyInfo pro in typeof(T).GetProperties().ToList())
            {
                try
                {
                    object valor = dr.GetValue(dr.GetOrdinal(pro.Name));
                    if (valor == DBNull.Value)
                    {
                        _return.GetType().GetProperty(pro.Name).SetValue(null, null);
                    }
                    else
                    {
                        valor = ChangeType(valor, pro.PropertyType);
                        _return.GetType().GetProperty(pro.Name).SetValue(_return, valor);
                    }
                }
                catch (Exception)
                {

                }
            }
            return _return;
        }

        public SqlCommand GetInsertCommand()
        {
            SqlCommand _return = new SqlCommand();
            _return.CommandText = "INSERT INTO {0} ({1}) VALUES ({2})";

            string tabela = typeof(T).Name;
            string campos = "";
            string valores = "";

            foreach (PropertyInfo pro in typeof(T).GetProperties().ToList().Where(
                    p => p.GetCustomAttribute(typeof(DataObjectFieldAttribute)) != null))
            {
                campos += pro.Name + ", ";
                valores += "@" + pro.Name + ", ";

                _return.Parameters.AddWithValue("@" + pro.Name, pro.GetValue(this));
            }

            campos = campos.Substring(0, campos.Length - 2);
            valores = valores.Substring(0, valores.Length - 2);

            _return.CommandText = string.Format(_return.CommandText, tabela, campos, valores);

            return _return;
        }

        public SqlCommand GetUpdateCommand()
        {
            SqlCommand _return = new SqlCommand();
            _return.CommandText = "UPDATE {0} SET {1} WHERE {2}";

            string tabela = typeof(T).Name;
            string campos = "";
            string chave = "";

            foreach (PropertyInfo pro in typeof(T).GetProperties().ToList().Where(
                    p => p.GetCustomAttribute(typeof(DataObjectFieldAttribute)) != null))
            {
                DataObjectFieldAttribute att = (DataObjectFieldAttribute)pro.GetCustomAttribute(typeof(DataObjectFieldAttribute));

                if (att.PrimaryKey)
                {
                    chave = pro.Name + "=@" + pro.Name;
                    _return.Parameters.AddWithValue("@" + pro.Name, pro.GetValue(this));
                }
                else
                {
                    campos += pro.Name + "=@" + pro.Name + ",";
                    _return.Parameters.AddWithValue("@" + pro.Name, pro.GetValue(this));
                }



            }

            campos = campos.Substring(0, campos.Length - 1);

            _return.CommandText = string.Format(_return.CommandText, tabela, campos, chave);

            return _return;
        }

        public SqlCommand GetDeleteCommand()
        {
            SqlCommand _return = new SqlCommand();
            string tabela = typeof(T).Name;
            string chave = "";

            using (SqlConnection cn = new SqlConnection("Server=.\\sqlexpress;Database=CadastroEmpresa;Trusted_Connection=True;"))
            {
                try
                {
                    cn.Open();
                }
                catch (Exception)
                {

                    throw;
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    _return.CommandText = @"DELETE FROM {0} WHERE {1}";
                    cmd.Connection = cn;

                    foreach (PropertyInfo pro in typeof(T).GetProperties().ToList().Where(
                                 p => p.GetCustomAttribute(typeof(DataObjectFieldAttribute)) != null))
                    {
                        DataObjectFieldAttribute att = (DataObjectFieldAttribute)pro.GetCustomAttribute(typeof(DataObjectFieldAttribute));
                        if (att.PrimaryKey)
                        {
                            chave = pro.Name + "=@" + pro.Name;
                            _return.Parameters.AddWithValue("@" + pro.Name, pro.GetValue(this));

                        }
                    }
                    _return.CommandText = string.Format(_return.CommandText, tabela, chave);
                }
            }
            return _return;
        }

        public void GravarBD()
        {
            if ((bool)typeof(T).GetProperty("IsNew").GetValue(this))
            {
                Insert();
            }
            else if ((bool)typeof(T).GetProperty("IsModified").GetValue(this))
            {
                Update();
            }
        }

        public void Insert()
        {
            using (SqlConnection cn = new SqlConnection("Server=.\\sqlexpress;Database=CadastroEmpresa;Trusted_Connection=True;"))
            {
                SqlCommand cmd = this.GetInsertCommand();
                try
                {
                    cn.Open();
                }
                catch (Exception e )
                {
                    throw new Exception(e.Message);
                }

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
        }

        public void Update()
        {
            using (SqlConnection cn = new SqlConnection("Server=.\\sqlexpress;Database=CadastroEmpresa;Trusted_Connection=True;"))
            {
                SqlCommand cmd = this.GetUpdateCommand();
                try
                {
                    cn.Open();
                }
                catch (Exception)
                {
                    
                }
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete()
        {
            using (SqlConnection cn = new SqlConnection("Server=.\\sqlexpress;Database=CadastroEmpresa;Trusted_Connection=True;"))
            {
                SqlCommand cmd = this.GetDeleteCommand();
                try
                {
                    cn.Open();
                }
                catch (Exception r)
                {
                    throw new Exception(r.Message);
                }

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
        }


    }
}
