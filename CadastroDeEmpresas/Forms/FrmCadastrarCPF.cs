using CadastroDeEmpresasLibrary.Classes;
using CadastroEmpresasLibrary.Classes;
using CadastroEmpresasLibrary.Exceptions;
using CadastroEmpresasLibrary.Metodos;
using Correios;
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
    public partial class FrmCadastrarCPF : Form
    {
        string aux;
        public FrmCadastrarCPF()
        {
            InitializeComponent();
            aux = null;
        }

        private void txtCEP_Enter(object sender, EventArgs e)
        {
            txtCEP.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUF.Text = txtTelefone.Text = txtNumero.Text = txtNome.Text = txtLogradouro.Text = txtEmail.Text  = "";
            txtComplemento.Text = txtCidade.Text = txtCEP.Text = txtCelular.Text = txtBairro.Text = "";
            mskTxtNascimento.Text = mskTxtCPF.Text = null;
        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            CorreiosApi consultaCorreio = new CorreiosApi();
            try
            {
                var busca = consultaCorreio.consultaCEP(txtCEP.Text);

                aux = busca.cep;

                txtCidade.Text = busca.cidade;
                txtUF.Text = busca.uf;
                txtBairro.Text = busca.bairro;
                txtLogradouro.Text = busca.end;
                txtComplemento.Text = busca.complemento;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnBuscarCEP_Click(sender, e);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNumero.Text))
                {
                    throw new ValidacaoException("Campo de número não pode ser vazio!");
                }

                Funcoes func = new Funcoes();
                Endereco auxEndereco = new Endereco();
                PessoaFisica pessoa = new PessoaFisica();

                if (!pessoa.HasCpf(mskTxtCPF.Text))
                {
                    
                    pessoa.CPF = mskTxtCPF.Text;
                    pessoa.Nome = txtNome.Text;
                    pessoa.Telefone = txtTelefone.Text;
                    pessoa.Celular = txtCelular.Text;
                    pessoa.DataNascimento = DateTime.Parse(mskTxtNascimento.Text);
                    pessoa.Email = txtEmail.Text;

                    int nextid = pessoa._Proximo();

                    auxEndereco.ID = nextid;
                    auxEndereco.CEP = aux;
                    auxEndereco.Bairro = txtBairro.Text;
                    auxEndereco.Cidade = txtCidade.Text;
                    auxEndereco.Complemento = txtComplemento.Text;
                    auxEndereco.Logradouro = txtLogradouro.Text;
                    auxEndereco.Numero = txtNumero.Text;
                    auxEndereco.UF = txtUF.Text;

                    pessoa.Dispose();
                    auxEndereco.Insert();
                }
                else
                {
                    throw new ValidacaoException("CPF Já cadastrado!");
                }

                MessageBox.Show("Cadastro criado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro1)
            {
                MessageBox.Show(erro1.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja sair?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                button2_Click(sender, e);
                this.Close();
            }
        }
    }
}
