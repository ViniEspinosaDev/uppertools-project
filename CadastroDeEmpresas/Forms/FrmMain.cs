using CadastroDeEmpresas.Forms;
using CadastroDeEmpresasLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CadastroEmpresasLibrary.Metodos;

namespace CadastroDeEmpresas
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            //string pathBD = null;
            //try
            //{
            //    pathBD = File.ReadAllText(@"C:\Users\vinie\Documents\Arquivos\Vinicius\Profissional\Estágio\Uppertools\CadastroDeEmpresas\BDPath.txt");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Erro ao ler o caminho de banco de dados!\nCertifique-se que o caminho do BD SQL Server esteja escrito no Txt do seguinte caminho:\n" +
            //        "\\desktop\\CadastroDeEmpresas\\BDPath.txt", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

            //try
            //{
            //    //Testar conexão
            //    Funcoes funcao = new Funcoes();

            //    if (funcao.TestarConexaoBanco(pathBD))
            //    {
            //        //VERIFICAR SE EXISTE AS TABELAS E SE NAO EXISTIR CRIAR :)




            //    }

            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.Message,"ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

            InitializeComponent();
            //AO INICIALIZAR O FORM VERIFICAR SE EXISTE UM BANCO DE DADOS INTEGRADO AO SISTEMA
            //Ao receber o Path Do banco de dados já automaticamente criar as tabelas necessarias
        }

        #region Metodos
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void timerSegundos_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            lblDataHora.Text = dataHora.ToLongDateString() + " || " + dataHora.ToLongTimeString() + " ||";
        }

        private void cPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCPF ConsultarCPF = new FrmConsultaCPF();
            ConsultarCPF.ShowDialog();
        }

        private void cPFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastrarCPF CadastraCPF = new FrmCadastrarCPF();
            CadastraCPF.ShowDialog();
        }
        #endregion

    }
}
