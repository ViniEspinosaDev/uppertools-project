using System;

namespace CadastroEmpresasLibrary.Classes
{
    public partial class Contato : Backwork<Contato>, IDisposable
    {
        public Contato()
        {
            this.ContatoId = Convert.ToInt32(Next());
            this._isNew = true;
            this._isModified = false;
        }
        public Contato(int Codigo)
        {
            SetSelf(GetByPrimaryKey(Codigo));
            this._isNew = false;
            this._isModified = false;
        }
        public void Dispose()
        {
            this.Gravar();
        }
    }
}
