using CadastroEmpresasLibrary.Classes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CadastroDeEmpresas.Forms
{
    public partial class FrmVisualizarCPF : Form
    {
        public FrmVisualizarCPF()
        {
            InitializeComponent();
        }

        public void VisualizaCPF(string cpf)
        {
            try
            {
                PessoaFisica pes = new PessoaFisica();
                Endereco end = new Endereco();
                Contato con = new Contato();

                pes.HasCpf(cpf);
                end.Select(pes.EnderecoId);
                con.Select(pes.ContatoId);
                

                txtNome.Text = pes.Nome;
                mskTxtCPF.Text = pes.CPF;
                mskTxtNascimento.Text = pes.DataNascimento.ToString();

                txtEmail.Text = con.Email;
                txtCelular.Text = con.Celular;
                txtTelefone.Text = con.Telefone;

                txtCEP.Text = end.CEP;
                txtCidade.Text = end.Cidade;
                txtUF.Text = end.UF;
                txtBairro.Text = end.Bairro;
                txtLogradouro.Text = end.Logradouro;
                txtNumero.Text = end.Numero;
                txtComplemento.Text = end.Complemento;
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVisualizarCPF_Load(object sender, EventArgs e)
        {

        }
    }
}
