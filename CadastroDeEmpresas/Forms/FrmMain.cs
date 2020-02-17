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

namespace CadastroDeEmpresas
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

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
    }
}
