using CadastroEmpresasLibrary.Classes;
using CadastroEmpresasLibrary.Exceptions;
using CadastroEmpresasLibrary.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeEmpresasLibrary.Classes
{
    public partial class Endereco : Backwork<Endereco>, IDisposable
    {
        Funcoes Func = new Funcoes();

        [DataObjectField(true, true, false)]
        public int ID { get; set; }

        private string _CEP;
        [DataObjectField(false, false, false)]
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
        [DataObjectField(false, false, false)]
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
        [DataObjectField(false, false, false)]
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
        [DataObjectField(false, false, true)]
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
        [DataObjectField(false, false, true)]
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
        [DataObjectField(false, false, false)]
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
        [DataObjectField(false, false, true)]
        public string Complemento
        {
            get { return _Complemento; }
            set 
            { 
                _Complemento = value;
                _Complemento = Func.Maiuscula(_Complemento);
            }
        }

        public void Dispose()
        {
            this.GravarBD();
        }

        [Browsable(false)]
        public bool IsNew
        {
            get { return _isNew; }
        }
        [Browsable(false)]
        public bool IsModified
        {
            get { return _isModified; }
        }

        //Verifica se é novo
        private bool _isNew;

        //Verifica se já foi modificado
        private bool _isModified;
    }
}
