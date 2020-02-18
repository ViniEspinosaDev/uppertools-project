using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroEmpresasLibrary.Classes;

namespace CadastroDeEmpresasLibrary.Classes
{
    public partial class Endereco
    {
        public Endereco()
        {
            this.ID = Proximo();
            this._isNew = true;
            this._isModified = false;
        }

        //Mexi no banco de dados aqui!!! Se der erro já sabe
        public Endereco(int ID)
        {
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
                    cmd.Connection = cn;
                    cmd.CommandText = "SELECT * FROM Endereco WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", ID);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dr.Read();
                            Endereco end = ConvertRowToEntity(dr);
                            //this.ID = dr.GetInt32(dr.GetOrdinal("Id"));
                            //this.CEP = dr.GetString(dr.GetOrdinal("Cep"));
                            //this.Cidade = dr.GetString(dr.GetOrdinal("Cidade"));
                            //this.UF = dr.GetString(dr.GetOrdinal("Uf"));
                            //this.Logradouro = dr.GetString(dr.GetOrdinal("Logradouro"));
                            //this.Bairro = dr.GetString(dr.GetOrdinal("Bairro"));
                            //this.Numero = dr.GetString(dr.GetOrdinal("Numero"));
                            //this.Complemento = dr.GetString(dr.GetOrdinal("Complemento"));

                        }
                    }

                }
            }
        }
        public void ApagarBD(int _id)
        {
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
                    cmd.CommandText = @"DELETE FROM Endereco WHERE ID = @id";
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@id", _id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
        public void Select(int _id)
        {
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
                    cmd.Connection = cn;
                    cmd.CommandText = "SELECT * FROM Endereco WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", _id);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dr.Read();
                            this.ID = dr.GetInt32(dr.GetOrdinal("Id"));
                            this.CEP = dr.GetString(dr.GetOrdinal("Cep"));
                            this.Cidade = dr.GetString(dr.GetOrdinal("Cidade"));
                            this.UF = dr.GetString(dr.GetOrdinal("Uf"));
                            this.Logradouro = dr.GetString(dr.GetOrdinal("Logradouro"));
                            this.Bairro = dr.GetString(dr.GetOrdinal("Bairro"));
                            this.Numero = dr.GetString(dr.GetOrdinal("Numero"));
                            this.Complemento = dr.GetString(dr.GetOrdinal("Complemento"));

                        }
                    }

                }
            }
        }
        public static Int32 Proximo()
        {
            Int32 _return = 0;
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
                    cmd.Connection = cn;
                    cmd.CommandText = "SELECT * FROM Endereco";


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            _return++;
                        }
                    }
                }
            }
            return _return + 1;
        }
        //Ver se já existe o CPF cadastrado
    }
}
