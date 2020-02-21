using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CadastroEmpresasLibrary.Classes
{
    public partial class PessoaJuridica : Backwork<PessoaJuridica>, ICRUD
    {
        public PessoaJuridica()
        {
            this.PessoaJuridicaId = Convert.ToInt32(Next());
            this._isNew = true;
            this._isModified = false;
        }
        public PessoaJuridica(int ID)
        {
            SetSelf(GetByPrimaryKey(ID));
            this._isNew = false;
            this._isModified = false;
        }
        public void Dispose()
        {
            this.Gravar();
        }
        public bool HasCNPJ(string cnpj)
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
                    cmd.CommandText = $"SELECT * FROM PessoaJuridica WHERE CNPJ = @cnpj";
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            this.PessoaJuridicaId = dr.GetInt32(dr.GetOrdinal("PessoaJuridicaId"));
                            this.Nome = dr.GetString(dr.GetOrdinal("Nome"));
                            this.CNPJ = dr.GetString(dr.GetOrdinal("CNPJ"));
                            this.Abertura = dr.GetDateTime(dr.GetOrdinal("Abertura"));
                            this.Fantasia = dr.GetString(dr.GetOrdinal("Fantasia"));
                            this.Message = dr.GetString(dr.GetOrdinal("Message"));
                            this.Situacao = dr.GetString(dr.GetOrdinal("Situacao"));
                            this.Status = dr.GetString(dr.GetOrdinal("Status"));
                            this.Tipo = dr.GetString(dr.GetOrdinal("Tipo"));
                            this.ContatoId = dr.GetInt32(dr.GetOrdinal("ContatoId"));
                            this.EnderecoId = dr.GetInt32(dr.GetOrdinal("EnderecoId"));
                            return true;
                        }

                    }
                }
            }
            return false;
        }
        public static List<PessoaJuridica> BuscaNome(string enome)
        {
            List<PessoaJuridica> _return = null;

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
                    cmd.CommandText = $"SELECT * FROM PessoaJuridica WHERE Nome like '%{enome}%'";

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                PessoaJuridica auxPessoaJuridica = new PessoaJuridica();

                                auxPessoaJuridica.PessoaJuridicaId = dr.GetInt32(dr.GetOrdinal("PessoaJuridicaId"));
                                auxPessoaJuridica.Nome = dr.GetString(dr.GetOrdinal("Nome"));
                                auxPessoaJuridica.CNPJ = dr.GetString(dr.GetOrdinal("CNPJ"));
                                auxPessoaJuridica.Abertura = dr.GetDateTime(dr.GetOrdinal("Abertura"));
                                auxPessoaJuridica.Fantasia = dr.GetString(dr.GetOrdinal("Fantasia"));
                                auxPessoaJuridica.Message = dr.GetString(dr.GetOrdinal("Message"));
                                auxPessoaJuridica.Situacao = dr.GetString(dr.GetOrdinal("Situacao"));
                                auxPessoaJuridica.Status = dr.GetString(dr.GetOrdinal("Status"));
                                auxPessoaJuridica.Tipo = dr.GetString(dr.GetOrdinal("Tipo"));
                                auxPessoaJuridica.ContatoId = dr.GetInt32(dr.GetOrdinal("ContatoId"));
                                auxPessoaJuridica.EnderecoId = dr.GetInt32(dr.GetOrdinal("EnderecoId"));



                                if (_return == null)
                                    _return = new List<PessoaJuridica>();

                                auxPessoaJuridica._isNew = false;

                                _return.Add(auxPessoaJuridica);
                            }

                        }
                    }

                }
            }

            return _return;
        }

    }
}
