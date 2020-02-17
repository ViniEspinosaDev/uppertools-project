using CadastroDeEmpresasLibrary.Classes;
using CadastroEmpresasLibrary.Classes;
using CadastroEmpresasLibrary.Exceptions;
using CadastroEmpresasLibrary.Metodos;
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
    public partial class FrmConsultaCPF : Form
    {
        BindingSource dados = new BindingSource();
        public FrmConsultaCPF()
        {
            InitializeComponent();
            dataGridViewConsulCPF.AllowUserToAddRows = false;
            dataGridViewConsulCPF.AllowUserToDeleteRows = false;
            dados.DataSource = PessoaFisica.Todos();
            dataGridViewConsulCPF.DataSource = dados;
        }

        private void FrmConsultaCPF_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultaCPFsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxCPFcpf_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCPFcpf.Checked)
                checkBoxCPFnome.Checked = false;
        }

        private void checkBoxCPFnome_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCPFnome.Checked)
                checkBoxCPFcpf.Checked = false;
        }

        private void btnConsultaCPFalterar_Click(object sender, EventArgs e)
        {
            //Para obter o item atual da lista
            try
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse cadastro?", "CUIDADO!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ((PessoaFisica)dados.Current).ApagarBD();
                    int id = ((PessoaFisica)dados.Current).Id;
                    Endereco novo = new Endereco();
                    novo.ApagarBD(id);
                    MessageBox.Show("Cadastro Excluido com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERRO AO APAGAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dados.DataSource = PessoaFisica.Todos();
        }

        private void btnConsultaCPFentrar_Click(object sender, EventArgs e)
        {
            try
            {
                string auxCpf = ((PessoaFisica)dados.Current).CPF;

                FrmVisualizarCPF VisualizarCPF = new FrmVisualizarCPF();

                VisualizarCPF.VisualizaCPF(auxCpf);
                VisualizarCPF.ShowDialog();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultaGO_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxCPFnome.Checked)
                {
                    if (!string.IsNullOrEmpty(txtConsultaNOME.Text))
                    {
                        //Pesquisar e mostrar a partir do nome
                        Funcoes Func = new Funcoes();
                        string nome = Func.Maiuscula(txtConsultaNOME.Text);
                        txtConsultaNOME.Text = nome;

                        dados.DataSource = PessoaFisica.BuscaNome(nome);
                        dataGridViewConsulCPF.DataSource = dados;
                    }
                    else
                    {
                        throw new ValidacaoException("Check Box NOME marcada porém sem texto em 'NOME'!");
                    }
                }
                else if (checkBoxCPFcpf.Checked)
                {
                    if (!string.IsNullOrEmpty(mskTxtConsultaCPF.Text))
                    {
                        //Pesquisa e mostra a partir do CPF
                        PessoaFisica pf = new PessoaFisica();
                        bool tem = false;
                        tem = pf.HasCpf(mskTxtConsultaCPF.Text);

                        if (!tem)
                        {
                            throw new ValidacaoException("Não há cadastro com esse CPF");
                        }

                        dados.DataSource = pf;
                        dataGridViewConsulCPF.DataSource = dados;
                    }
                    else
                    {
                        throw new ValidacaoException("Check Box CPF marcada porém sem texto em 'CPF'!");
                    }
                }
                else
                {
                    throw new ValidacaoException("Nenhuma check box marcada!");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dados.DataSource = PessoaFisica.Todos();
            dataGridViewConsulCPF.DataSource = dados;
        }
    }
}
