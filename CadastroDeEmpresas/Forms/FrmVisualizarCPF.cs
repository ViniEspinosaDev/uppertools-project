using CadastroDeEmpresasLibrary.Classes;
using CadastroEmpresasLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                PessoaFisica auxPessoa = new PessoaFisica();
                Endereco auxEndereco = new Endereco();

                auxPessoa.HasCpf(cpf);
                auxEndereco.Select(auxPessoa.Id);

                txtNome.Text = auxPessoa.Nome;
                mskTxtCPF.Text = auxPessoa.CPF;
                mskTxtNascimento.Text = auxPessoa.DataNascimento.ToString();
                txtEmail.Text = auxPessoa.Email;
                txtCelular.Text = auxPessoa.Celular;
                txtTelefone.Text = auxPessoa.Telefone;

                txtCEP.Text = auxEndereco.CEP;
                txtCidade.Text = auxEndereco.Cidade;
                txtUF.Text = auxEndereco.UF;
                txtBairro.Text = auxEndereco.Bairro;
                txtLogradouro.Text = auxEndereco.Logradouro;
                txtNumero.Text = auxEndereco.Numero;
                txtComplemento.Text = auxEndereco.Complemento;
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
