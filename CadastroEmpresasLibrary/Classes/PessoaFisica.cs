using CadastroEmpresasLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroEmpresasLibrary.Metodos;
using System.ComponentModel;

namespace CadastroEmpresasLibrary.Classes
{
    public partial class PessoaFisica : IDisposable
    {
        Funcoes Func = new Funcoes();

        //Verifica se é novo
        private bool _isNew;
        [Browsable(false)]
        public bool IsNew
        {
            get { return _isNew; }
        }

        //Verifica se já foi modificado
        private bool _isModified;
        [Browsable(false)]
        public bool IsModified
        {
            get { return _isModified; }
        }

        //Valida ID (APENAS TESTE)
        private int _ID;
        public int Id
        {
            get { return _ID; }
            set 
            {
                if (value < 0)
                {
                    throw new ValidacaoException("O ID do cliente não pode ser negativo!");
                }
                else
                {
                    _ID = value;
                    this._isModified = true;
                }
            }
        }

        //Nome
        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set 
            {
               _Nome = value;
                if (string.IsNullOrEmpty(Nome))
                    throw new ValidacaoException("Nome não pode ser nulo!");
                this._isModified = true;
                _Nome = Func.Maiuscula(_Nome);
            }
        }

        //Valida CPF
        private string _CPF;
        public string CPF
        {
            get { return _CPF; }
            set 
            {
                //Algoritmo CPF
                if (Func.VerificaCPF(value))
                {
                    _CPF = value;
                    this._isModified = true;
                }
                else
                {
                    throw new ValidacaoException("O CPF é inválido!");
                }
                     
            }
        }

        //Valida DataNascimento
        private DateTime _DataNascimento;
        public DateTime DataNascimento
        {
            get { return _DataNascimento; }
            set 
            {
                _DataNascimento = value;
                if (DataNascimento == null)
                    throw new ValidacaoException("Data de Nascimento não pode ser nulo!");               
                this._isModified = true; 
            }
        }

        //Valida E-mail
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set 
            {
               

                bool ver = false;
                foreach(char x in value)
                {
                    if (x == '@')
                    {
                        ver = true;
                        break;
                    }
                        
                }

                if(ver)
                {
                    _Email = value;
                    _Email = Func.Maiuscula(_Email);
                } 
                else
                {
                    throw new ValidacaoException("O e-mail é inválido!");
                }

                if (string.IsNullOrEmpty(Email))
                    throw new ValidacaoException("Email não pode ser nulo!");
            }
        }

        //Valida Telefone
        private string _Telefone;
        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; this._isModified = true; }
        }

        //Valida Celular
        private string _Celular;
        public string Celular
        {
            get { return _Celular; }
            set { _Celular = value; this._isModified = true; }
        }


    }
}
