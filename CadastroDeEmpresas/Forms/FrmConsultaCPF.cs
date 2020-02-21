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

        private void btnConsultaCPFalterar_Click(object sender, EventArgs e)
        {
            //Para obter o item atual da lista
            try
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse cadastro?", "CUIDADO!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ((PessoaFisica)dados.Current).Delete();
                    Endereco auxEnd = new Endereco();
                    auxEnd.EnderecoId = ((PessoaFisica)dados.Current).EnderecoId;
                    auxEnd.Delete();
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

        private void btnConsultaGO_Click(object sender, EventArgs e, int op)
        {
            try
            {
                if (op == 1)
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
                        throw new ValidacaoException("Insira um Nome");
                    }
                }
                else
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
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            Endereco end = new Endereco();
            PessoaFisica pes = new PessoaFisica();
            Contato con = new Contato();
            dados.DataSource = PessoaFisica.Todos();
            end.Select(pes.EnderecoId);
            con.Select(con.ContatoId);
            string x = dados.DataSource.ToString() + pes + con;
            dataGridViewConsulCPF.DataSource = x;
        }

        private void txtConsultaNOME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnConsultaGO_Click(sender, e, 1);
            }
        }

        private void mskTxtConsultaCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnConsultaGO_Click(sender, e, 2);
            }
        }

        private void txtConsultaNOME_Click(object sender, EventArgs e)
        {
            txtConsultaNOME.SelectAll();
        }

        private void mskTxtConsultaCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTxtConsultaCPF_Click(object sender, EventArgs e)
        {
            txtConsultaNOME.SelectAll();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtConsultaNOME.Text = mskTxtConsultaCPF.Text = "";
        }

        }
}
