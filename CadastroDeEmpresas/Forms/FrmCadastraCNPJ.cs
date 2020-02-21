using CadastroEmpresasLibrary.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using System.Windows.Forms;
using System.Xml;

namespace CadastroDeEmpresas.Forms
{
    public partial class FrmCadastraCNPJ : Form
    {
        public FrmCadastraCNPJ()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroEmpresaLibrary.ServicoCNPJ.WsConsulta wsConsulta = new CadastroEmpresaLibrary.ServicoCNPJ.WsConsulta();
            Funcoes func = new Funcoes();

            if(!string.IsNullOrEmpty(mskTxtCNPJ.Text))
            {
                try
                {
                    if(func.VerificaCNPJ(mskTxtCNPJ.Text))
                    {
                        XmlDocument n = new XmlDocument();
                        string cnpj = mskTxtCNPJ.Text.Replace(".", "").Replace("-", "");
                         = wsConsulta.ConsultarInformacoesCadastrais(cnpj).;
                    }
                    
                }
                catch (Exception)
                {

                }










            }
            else
            {
                MessageBox.Show("Verifique o CNPJ");
            }

            


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //button2_Click(sender, e);
                this.Close();
            }
        }
    }
}
