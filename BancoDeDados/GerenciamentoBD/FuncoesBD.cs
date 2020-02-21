using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace BancoDeDados.GerenciamentoBD
{
    public class FuncoesBD
    {
        public bool ReceberPathDB()
        {
            string dirDocumentos = (string)Microsoft.Win32.Registry.CurrentUser
                .OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders")
                     .GetValue("Personal");

            bool verificaDeuCerto = false;
            if (File.Exists(dirDocumentos + "\\DBPath.txt"))
            {
                StreamReader file = new StreamReader(dirDocumentos + "\\DBPath.txt");

                string line = File.ReadAllText(dirDocumentos + "\\DBPath.txt");
                string[] linhas = line.Split('\n');

                string pathBD = linhas[1].Substring(0, linhas[1].Length - 1);
                string verifica = linhas[0].Substring(0, linhas[0].Length - 1);
                if (TestarConexaoBanco(pathBD))
                {
                    if (verifica.Equals("false"))
                    {
                        CreateDB(pathBD);
                        file.Close();
                        File.Delete(dirDocumentos + "\\DBPath.txt");
                        StreamWriter salvar = new StreamWriter(dirDocumentos + "\\DBPath.txt");
                        salvar.WriteLine("true");
                        salvar.WriteLine(pathBD);
                        verificaDeuCerto = true; ;
                    }
                }
            }
            else
            {
                StreamWriter salvar = new StreamWriter(dirDocumentos + "\\DBPath.txt");
                salvar.WriteLine("false");
                salvar.WriteLine("*escreva o caminho do banco de dados nesta linha*");
                salvar.Close();
                MessageBox.Show($"Criei um arquivo txt automaticamente em: '  {dirDocumentos}" + "\\DBPath.txt  ' ::.. Por favor, insira o caminho para o banco de dados nesse txt criado!", "INSIRA O CAMINHO DO BD NO TXT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return verificaDeuCerto;
        }

        public bool TestarConexaoBanco(string pathBanco)
        {
            using (SqlConnection sc = new SqlConnection(pathBanco))
            {
                try
                {
                    sc.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public void CreateDB(string pathDB)
        {
            string sqlCreateDBQuery;
            try
            {
                SqlConnection tmpConn = new SqlConnection(pathDB);

                sqlCreateDBQuery = "SELECT * FROM master.dbo.sysdatabases where name = 'Your db name\'";


                using (tmpConn)
                {
                    tmpConn.Open();
                    tmpConn.ChangeDatabase("master");

                    using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn))
                    {
                        int exists = sqlCmd.ExecuteNonQuery();

                        if (exists <= 0)
                        {

                            string script = "CREATE DATABASE CadastroEmpresa";

                            sqlCmd.CommandText = script;
                            sqlCmd.ExecuteNonQuery();

                            tmpConn.ChangeDatabase("CadastroEmpresa");

                            SqlCommand nvSql = new SqlCommand("SELECT * FROM master.dbo.sysdatabases where name = 'CadastroEmpresa\'", tmpConn);

                            script = @"CREATE TABLE [dbo].[PessoaFisica] (
                                                [ID]             INT          NOT NULL,
                                                [Nome]           VARCHAR (50) NULL,
                                                [CPF]            VARCHAR (14) NULL,
                                                [DataNascimento] DATETIME     NULL,
                                                [Email]          VARCHAR (50) NULL,
                                                [Telefone]       VARCHAR (15) NULL,
                                                [Celular]        NCHAR (15)   NULL,
                                                PRIMARY KEY CLUSTERED ([ID] ASC)
                                            );";
                            nvSql.CommandText = script;
                            nvSql.ExecuteNonQuery();

                            script = @"CREATE TABLE [dbo].[Endereco] (
                                        [Id]          INT           NOT NULL,
                                        [Cep]         VARCHAR (15)  NULL,
                                        [Cidade]      VARCHAR (30)  NULL,
                                        [Uf]          VARCHAR (30)  NULL,
                                        [Logradouro]  VARCHAR (100) NULL,
                                        [Bairro]      VARCHAR (50)  NULL,
                                        [Numero]      VARCHAR (10)  NULL,
                                        [Complemento] VARCHAR (130) NULL,
                                        PRIMARY KEY CLUSTERED ([Id] ASC)
                                    );";

                            nvSql.CommandText = script;
                            nvSql.ExecuteNonQuery();


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GravarBDa()
        {
            
        }

    }
}
