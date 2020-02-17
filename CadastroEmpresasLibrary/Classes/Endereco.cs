using CadastroEmpresasLibrary.Classes;
using CadastroEmpresasLibrary.Exceptions;
using CadastroEmpresasLibrary.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeEmpresasLibrary.Classes
{
    public partial class Endereco
    {
        Funcoes Func = new Funcoes();
        public int ID { get; set; }

        private string _CEP;
        public string CEP
        {
            get { return _CEP; }
            set 
            {
                _CEP = value;
                if (string.IsNullOrEmpty(_CEP))
                    throw new ValidacaoException("CEP não pode ser nulo!");
            }
        }

        private string _Cidade;
        public string Cidade
        {
            get { return _Cidade; }
            set 
            {
                _Cidade = value;
                _Cidade = Func.Maiuscula(_Cidade);
                if (string.IsNullOrEmpty(_Cidade))
                    throw new ValidacaoException("Cidade não pode ser nulo!");
            }
        }

        private string _UF;
        public string UF
        {
            get { return _UF; }
            set 
            {
                _UF = value;
                _UF = Func.Maiuscula(_UF);
                if (string.IsNullOrEmpty(_UF))
                    throw new ValidacaoException("UF não pode ser nulo!");
            }
        }


        private string _Logradouro;
        public string Logradouro
        {
            get { return _Logradouro; }
            set 
            {
                _Logradouro = value;
                _Logradouro = Func.Maiuscula(_Logradouro);
            }
        }


        private string _Bairro;
        public string Bairro
        {
            get { return _Bairro; }
            set
            { 
                _Bairro = value;
                _Bairro = Func.Maiuscula(_Bairro);
            }
        }


        private string _Numero;
        public string Numero
        {
            get { return _Numero; }
            set 
            { 
                _Numero = value;
                _Numero = Func.Maiuscula(_Numero);
            }
        }


        private string _Complemento;
        public string Complemento
        {
            get { return _Complemento; }
            set 
            { 
                _Complemento = value;
                _Complemento = Func.Maiuscula(_Complemento);
            }
        }

    }
}
