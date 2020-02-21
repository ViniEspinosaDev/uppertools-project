using System;

namespace CadastroEmpresasLibrary.Classes
{
    public partial class Endereco : Backwork<Endereco>, IDisposable, ICRUD
    {
        public Endereco()
        {
            this.EnderecoId = Convert.ToInt32(Next());
            this._isNew = true;
            this._isModified = false;
        }
        public Endereco(int ID)
        {
            SetSelf(GetByPrimaryKey(ID));
            this._isNew = false;
            this._isModified = false;
        }
        public void Dispose()
        {
            this.Gravar();
        }
    }
}
