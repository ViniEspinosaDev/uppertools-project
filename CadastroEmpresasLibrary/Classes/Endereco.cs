using CadastroEmpresasLibrary.Exceptions;
using CadastroEmpresasLibrary.Metodos;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CadastroEmpresasLibrary.Classes
{
    public partial class Endereco : Backwork<Endereco>, ICRUD
    {
        Funcoes Func = new Funcoes();

        #region Conteudo - Endereco

        private int _enderecoId;
        [DataObjectField(true, true, false)]
        [DisplayName("Codigo")]
        [Key]
        public int EnderecoId
        {
            get { return _enderecoId; }
            set
            {
                if (value < 0)
                {
                    throw new ValidacaoException("O ID do cliente não pode ser negativo!");
                }
                else
                {
                    _enderecoId = value;
                    this._isModified = true;
                }
            }
        }

        private string _cep;
        [DataObjectField(false, false, false)]
        [DisplayName("CEP")]
        public string CEP
        {
            get { return _cep; }
            set
            {
                _cep = value;
                this._isModified = true;
                if (string.IsNullOrEmpty(_cep))
                    throw new ValidacaoException("CEP não pode ser nulo!");
            }
        }

        private string _cidade;
        [DataObjectField(false, false, false)]
        [DisplayName("Cidade")]
        public string Cidade
        {
            get { return _cidade; }
            set
            {
                _cidade = value;
                _cidade = Func.Maiuscula(_cidade);
                this._isModified = true;
                if (string.IsNullOrEmpty(_cidade))
                    throw new ValidacaoException("Cidade não pode ser nulo!");
            }
        }

        private string _uf;
        [DataObjectField(false, false, false)]
        [DisplayName("UF")]
        public string UF
        {
            get { return _uf; }
            set
            {
                _uf = value;
                _uf = Func.Maiuscula(_uf);
                this._isModified = true;
                if (string.IsNullOrEmpty(_uf))
                    throw new ValidacaoException("UF não pode ser nulo!");
            }
        }


        private string _logradouro;
        [DataObjectField(false, false, true)]
        [DisplayName("Logradouro")]
        public string Logradouro
        {
            get { return _logradouro; }
            set
            {
                _logradouro = value;
                this._isModified = true;
                _logradouro = Func.Maiuscula(_logradouro);
            }
        }


        private string _bairro;
        [DataObjectField(false, false, true)]
        [DisplayName("Bairro")]
        public string Bairro
        {
            get { return _bairro; }
            set
            {
                _bairro = value;
                _bairro = Func.Maiuscula(_bairro);
                this._isModified = true;
            }
        }


        private string _numero;
        [DataObjectField(false, false, false)]
        [DisplayName("Numero")]
        public string Numero
        {
            get { return _numero; }
            set
            {
                _numero = value;
                _numero = Func.Maiuscula(_numero);
                this._isModified = true;
            }
        }


        private string _complemento;
        [DataObjectField(false, false, true)]
        [DisplayName("Complemento")]
        public string Complemento
        {
            get { return _complemento; }
            set
            {
                _complemento = value;
                _complemento = Func.Maiuscula(_complemento);
                this._isModified = true;
            }
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


        #endregion
    }
}
