using CadastroEmpresasLibrary.Exceptions;
using CadastroEmpresasLibrary.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CadastroEmpresasLibrary.Classes
{
    public partial class Contato : Backwork<Contato>, ICRUD
    {
        Funcoes funcs = new Funcoes();

        #region Conteudo - Contato

        private int _contatoId;
        [DataObjectField(true, true, false)]
        [DisplayName("Codigo")]
        [Key]
        public int ContatoId
        {
            get { return _contatoId; }
            set
            {
                if (value < 0)
                {
                    throw new ValidacaoException("O ID do cliente não pode ser negativo!");
                }
                else
                {
                    _contatoId = value;
                    this._isModified = true;
                }
            }
        }


        private string _email;
        //Valida E-mail
        [DataObjectField(false, false, true)]
        [DisplayName("Email")]
        public string Email
        {
            get { return _email; }
            set
            {
                bool ver = false;
                foreach (char x in value)
                {
                    if (x == '@')
                    {
                        ver = true;
                        break;
                    }

                }

                if (ver)
                {
                    _email = value;
                    _email = funcs.Maiuscula(_email);
                    this._isModified = true;
                }
                else
                {
                    throw new ValidacaoException("O e-mail é inválido!");
                }

                if (string.IsNullOrEmpty(Email))
                    throw new ValidacaoException("E-mail não pode ser nulo!");
            }
        }



        private string _telefone;
        //Valida Telefone
        [DataObjectField(false, false, true)]
        [DisplayName("Telefone")]
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; this._isModified = true; }
        }



        private string _celular;
        //Valida Celular
        [DataObjectField(false, false, true)]
        [DisplayName("Celular")]
        public string Celular
        {
            get { return _celular; }
            set { _celular = value; this._isModified = true; }
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
