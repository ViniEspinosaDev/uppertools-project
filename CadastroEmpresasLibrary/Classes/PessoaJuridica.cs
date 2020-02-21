using CadastroEmpresasLibrary.Exceptions;
using CadastroEmpresasLibrary.Metodos;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroEmpresasLibrary.Classes
{
    public partial class PessoaJuridica : Backwork<PessoaJuridica>, ICRUD
    {
        Funcoes func = new Funcoes();

        #region Conteudo - PessoaJuridica



        private int _pessoaJuridicaId;
        [DataObjectField(true, true, false)]
        [DisplayName("Codigo")]
        [Key]
        public int PessoaJuridicaId
        {
            get { return _pessoaJuridicaId; }
            set
            {
                if (value < 0)
                {
                    throw new ValidacaoException("O ID da empresa não pode ser negativo!");
                }
                else
                {
                    _pessoaJuridicaId = value;
                    this._isModified = true;
                }
            }
        }




        private string _status;
        [DataObjectField(false, false, true)]
        [DisplayName("Status")]
        public string Status
        {
            get { return _status; }
            set { _status = value; this._isModified = true; }
        }




        private string _message;
        [DataObjectField(false, false, true)]
        [DisplayName("Mensagem")]
        public string Message
        {
            get { return _message; }
            set { _message = value; this._isModified = true; }
        }



        private string _cnpj;
        [DataObjectField(false, false, false)]
        [DisplayName("CNPJ")]
        public string CNPJ
        {
            get { return _cnpj; }
            set
            {
                if (func.VerificaCNPJ(value))
                {
                    _cnpj = value;
                    this._isModified = true;
                }
                else
                {
                    throw new ValidacaoException("O CNPJ é inválido!");
                }
            }
        }




        private string _tipo;
        [DataObjectField(false, false, true)]
        [DisplayName("Tipo")]
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; this._isModified = true; }
        }



        private DateTime _abertura;
        [DataObjectField(false, false, true)]
        [DisplayName("Abertura")]
        public DateTime Abertura
        {
            get { return _abertura; }
            set { _abertura = value; this._isModified = true; }
        }




        private string _nome;
        [DataObjectField(false, false, false)]
        [DisplayName("Razao Social")]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; this._isModified = true; }
        }



        private string _fantasia;
        [DataObjectField(false, false, true)]
        [DisplayName("Fantasia")]
        public string Fantasia
        {
            get { return _fantasia; }
            set { _fantasia = value; this._isModified = true; }
        }





        private string _situacao;
        [DataObjectField(false, false, true)]
        [DisplayName("Situacao")]
        public string Situacao
        {
            get { return _situacao; }
            set { _situacao = value; this._isModified = true; }
        }




        [ForeignKey("ContatoId")]
        [DataObjectField(false, false, true)]
        [DisplayName("ContatoID")]
        public int ContatoId { get; set; }
        [Browsable(false)]
        public virtual Contato _Contato { get; set; }




        [ForeignKey("EnderecoId")]
        [DataObjectField(false, false, true)]
        [DisplayName("EnderecoID")]
        public int EnderecoId { get; set; }
        [Browsable(false)]
        public virtual Endereco _Endereco { get; set; }




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
        [Browsable(false)]
        private bool _isNew;
        [Browsable(false)]
        private bool _isModified;

        #endregion

    }
}
