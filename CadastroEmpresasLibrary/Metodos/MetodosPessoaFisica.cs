using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEmpresasLibrary.Classes
{
    public partial class PessoaFisica : IDisposable
    {
        //Construtores
        public PessoaFisica()
        {
            this._ID = Proximo();
            this._isNew = true;
            this._isModified = false;
        }
        public PessoaFisica(int ID)
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
                    cmd.CommandText = "SELECT * FROM PessoaFisica WHERE ID = @id";
                    cmd.Parameters.AddWithValue("@id", ID);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dr.Read();
                            this._ID = dr.GetInt32(dr.GetOrdinal("ID"));
                            this._Nome = dr.GetString(dr.GetOrdinal("Nome"));
                            this._CPF = dr.GetString(dr.GetOrdinal("CPF"));
                            this._DataNascimento = dr.GetDateTime(dr.GetOrdinal("DataNascimento"));
                            this._Email = dr.GetString(dr.GetOrdinal("Email"));
                            this._Telefone = dr.GetString(dr.GetOrdinal("Telefone"));
                            this._Celular = dr.GetString(dr.GetOrdinal("Celular"));

                        }
                    }

                }
            }
            this._isModified = false;
            this._isNew = false;
        }
        //Metodos Banco de dados
        public void Insert()
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
                    cmd.CommandText = @"INSERT INTO PessoaFisica (ID, Nome, CPF, DataNascimento, 
                            Email, Telefone, Celular) VALUES (@id, @nome, @cpf, @datanascimento, @email, @telefone, @celular)";
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@id", this._ID);
                    cmd.Parameters.AddWithValue("@nome", this._Nome);
                    cmd.Parameters.AddWithValue("@cpf", this._CPF);
                    cmd.Parameters.AddWithValue("@datanascimento", this._DataNascimento);
                    cmd.Parameters.AddWithValue("@email", this._Email);
                    cmd.Parameters.AddWithValue("@telefone", this._Telefone);
                    cmd.Parameters.AddWithValue("@celular", this._Celular);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        this._isNew = false;
                    }
                    catch (Exception)
                    {

                        throw;
                    }



                }
            }
        }
        public void Update()
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
                    cmd.CommandText = @"UPDATE PessoaFisica SET Nome = @nome, CPF = @cpf, DataNascimento = @datanascimento, Email = @email,
                                            Telefone = @telefone, Celular = @celular WHERE ID = @id";
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@id", this._ID);
                    cmd.Parameters.AddWithValue("@nome", this._Nome);
                    cmd.Parameters.AddWithValue("@cpf", this._CPF);
                    cmd.Parameters.AddWithValue("@datanascimento", this._DataNascimento);
                    cmd.Parameters.AddWithValue("@email", this._Email);
                    cmd.Parameters.AddWithValue("@telefone", this._Telefone);
                    cmd.Parameters.AddWithValue("@celular", this._Celular);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        this._isModified = false;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        public void GravarBD()
        {
            if (this._isNew)
                Insert();
            else if (this._isModified)
                Update();
        }
        public void ApagarBD()
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
                    cmd.CommandText = @"DELETE FROM PessoaFisica WHERE ID = @id";
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@id", this._ID);

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
        public int _Proximo()
        {
            return Proximo();
        }
        //Pegar a proxima linha do banco
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
                    cmd.CommandText = "SELECT * FROM PessoaFisica";
                    

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            _return++;
                        }
                    }
                }
            }
            return _return + 1;
        }
        //Ver se já existe o CPF cadastrado
        public bool HasCpf(string cpf)
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
                    cmd.CommandText = $"SELECT * FROM PessoaFisica WHERE CPF = @cpf";
                    cmd.Parameters.AddWithValue("@cpf", cpf);


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if(dr.Read())
                        {
                            this._ID = dr.GetInt32(dr.GetOrdinal("ID"));
                            this._Nome = dr.GetString(dr.GetOrdinal("Nome"));
                            this._CPF = dr.GetString(dr.GetOrdinal("CPF"));
                            this._DataNascimento = dr.GetDateTime(dr.GetOrdinal("DataNascimento"));
                            this._Email = dr.GetString(dr.GetOrdinal("Email"));
                            this._Telefone = dr.GetString(dr.GetOrdinal("Telefone"));
                            this._Celular = dr.GetString(dr.GetOrdinal("Celular"));
                            return true;
                        }
                           
                    }
                }
            }
            return false;
        }

        public static List<PessoaFisica> BuscaNome(string nome)
        {
            List<PessoaFisica> _return = null;

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
                    cmd.CommandText = "SELECT * FROM PessoaFisica WHERE Nome like '%@nome%'";
                    cmd.Parameters.AddWithValue("@nome", nome);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                PessoaFisica auxPessoaFisica = new PessoaFisica();

                                auxPessoaFisica.Id = dr.GetInt32(dr.GetOrdinal("ID"));
                                auxPessoaFisica._Nome = dr.GetString(dr.GetOrdinal("Nome"));
                                auxPessoaFisica._CPF = dr.GetString(dr.GetOrdinal("CPF"));
                                auxPessoaFisica._DataNascimento = dr.GetDateTime(dr.GetOrdinal("DataNascimento"));
                                auxPessoaFisica._Email = dr.GetString(dr.GetOrdinal("Email"));
                                auxPessoaFisica._Telefone = dr.GetString(dr.GetOrdinal("Telefone"));
                                auxPessoaFisica._Celular = dr.GetString(dr.GetOrdinal("Celular"));

                                if (_return == null)
                                    _return = new List<PessoaFisica>();

                                auxPessoaFisica._isNew = false;

                                _return.Add(auxPessoaFisica);
                            }

                        }
                    }

                }
            }

            return _return;
        }
        //Buscar todos os dados
        public static List<PessoaFisica> Todos()
        {
            List<PessoaFisica> _return = null;

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
                    cmd.CommandText = "SELECT * FROM PessoaFisica";

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while(dr.Read())
                            {
                                PessoaFisica auxPessoaFisica = new PessoaFisica();

                                auxPessoaFisica.Id = dr.GetInt32(dr.GetOrdinal("ID"));
                                auxPessoaFisica._Nome = dr.GetString(dr.GetOrdinal("Nome"));
                                auxPessoaFisica._CPF = dr.GetString(dr.GetOrdinal("CPF"));
                                auxPessoaFisica._DataNascimento = dr.GetDateTime(dr.GetOrdinal("DataNascimento"));
                                auxPessoaFisica._Email = dr.GetString(dr.GetOrdinal("Email"));
                                auxPessoaFisica._Telefone = dr.GetString(dr.GetOrdinal("Telefone"));
                                auxPessoaFisica._Celular = dr.GetString(dr.GetOrdinal("Celular"));

                                if (_return == null)
                                    _return = new List<PessoaFisica>();

                                auxPessoaFisica._isNew = false;

                                _return.Add(auxPessoaFisica);
                            }

                        }
                    }

                }
            }

            return _return;
        }
        public void Dispose()
        {
            this.GravarBD();
        }
    }
}
