using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CadastroEmpresasLibrary.Classes
{
    public partial class PessoaFisica : Backwork<PessoaFisica>, IDisposable, ICRUD
    {
        public PessoaFisica()
        {
            this.PessoaFisicaId = Convert.ToInt32(Next());
            this._isNew = true;
            this._isModified = false;
        }
        public PessoaFisica(int ID)
        {
            SetSelf(GetByPrimaryKey(ID));
            this._isNew = false;
            this._isModified = false;
        }

        public void Dispose()
        {
            this.Gravar();
        }
        public bool HasCpf(string cpf)
        {
            using (SqlConnection cn = new SqlConnection(CaminhoBD))
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
                        if (dr.Read())
                        {
                            this.PessoaFisicaId = dr.GetInt32(dr.GetOrdinal("PessoaFisicaId"));
                            this.Nome = dr.GetString(dr.GetOrdinal("Nome"));
                            this.CPF = dr.GetString(dr.GetOrdinal("CPF"));
                            this.DataNascimento = dr.GetDateTime(dr.GetOrdinal("DataNascimento"));
                            this.ContatoId = dr.GetInt32(dr.GetOrdinal("ContatoId"));
                            this.EnderecoId = dr.GetInt32(dr.GetOrdinal("EnderecoId"));
                            return true;
                        }

                    }
                }
            }
            return false;
        }
        public static List<PessoaFisica> BuscaNome(string enome)
        {
            List<PessoaFisica> _return = null;

            using (SqlConnection cn = new SqlConnection(CaminhoBD))
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
                    cmd.CommandText = $"SELECT * FROM PessoaFisica WHERE Nome like '%{enome}%'";

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                PessoaFisica auxPessoaFisica = new PessoaFisica();

                                auxPessoaFisica.PessoaFisicaId = dr.GetInt32(dr.GetOrdinal("PessoaFisicaId"));
                                auxPessoaFisica.Nome = dr.GetString(dr.GetOrdinal("Nome"));
                                auxPessoaFisica.CPF = dr.GetString(dr.GetOrdinal("CPF"));
                                auxPessoaFisica.DataNascimento = dr.GetDateTime(dr.GetOrdinal("DataNascimento"));
                                auxPessoaFisica.ContatoId = dr.GetInt32(dr.GetOrdinal("ContatoId"));
                                auxPessoaFisica.EnderecoId = dr.GetInt32(dr.GetOrdinal("EnderecoId"));


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

    }
}
