using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeEmpresasLibrary.Classes
{
    public partial class Endereco
    {
        public Endereco()
        {
        }
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
                    cmd.CommandText = @"INSERT INTO Endereco (Id, Cep, Cidade, Uf, 
                            Logradouro, Bairro, Numero, Complemento) VALUES (@id, @cep, @cidade, @uf, @logradouro, @bairro, @numero, @complemento)";
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@id", this.ID);
                    cmd.Parameters.AddWithValue("@cep", this.CEP);
                    cmd.Parameters.AddWithValue("@cidade", this.Cidade);
                    cmd.Parameters.AddWithValue("@uf", this.UF);
                    cmd.Parameters.AddWithValue("@logradouro", this.Logradouro);
                    cmd.Parameters.AddWithValue("@bairro", this.Bairro);
                    cmd.Parameters.AddWithValue("@numero", this.Numero);
                    cmd.Parameters.AddWithValue("@complemento", this.Complemento);

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
    }
}
