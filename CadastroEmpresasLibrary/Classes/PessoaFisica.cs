using CadastroEmpresasLibrary.Exceptions;
using System;
using CadastroEmpresasLibrary.Metodos;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CadastroEmpresasLibrary.Classes
{
    public partial class PessoaFisica : Backwork<PessoaFisica>, ICRUD
    {
        Funcoes func = new Funcoes();

        #region Conteudo - PessoaFisica

        private int _pessoaFisicaId;
        [DataObjectField(true, true, false)]
        [DisplayName("Codigo")]
        [Key]
        public int PessoaFisicaId
        {
            get { return _pessoaFisicaId; }
            set
            {
                if (value < 0)
                {
                    throw new ValidacaoException("O ID da Pessoa não pode ser negativo!");
                }
                else
                {
                    _pessoaFisicaId = value;
                    this._isModified = true;
                }
            }
        }



        private string _Nome;
        [DataObjectField(false, false, false)]
        [DisplayName("Nome")]
        public string Nome
        {
            get { return _Nome; }
            set
            {
                _Nome = value;
                if (string.IsNullOrEmpty(Nome))
                    throw new ValidacaoException("Nome não pode ser nulo!");
                this._isModified = true;
                _Nome = func.Maiuscula(_Nome);
            }
        }



        private string _cpf;
        [DataObjectField(false, false, false)]
        [DisplayName("CPF")]
        public string CPF
        {
            get { return _cpf; }
            set
            {
                if (func.VerificaCPF(value))
                {
                    _cpf = value;
                    this._isModified = true;
                }
                else
                {
                    throw new ValidacaoException("O CPF é inválido!");
                }
            }
        }



        private DateTime _DataNascimento;
        [DataObjectField(false, false, false)]
        [DisplayName("Data Nascimento")]
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


        [ForeignKey("ContatoId")]
        [DataObjectField(false, false, true)]
        [DisplayName("ContatoID")]
        public int ContatoId { get; set; }
        public virtual Contato _Contato { get; set; }



        [ForeignKey("EnderecoId")]
        [DataObjectField(false, false, true)]
        [DisplayName("EnderecoID")]
        public int EnderecoId { get; set; }
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

        //Verifica se é novo
        private bool _isNew;

        //Verifica se já foi modificado
        private bool _isModified;
        #endregion

    }
}
