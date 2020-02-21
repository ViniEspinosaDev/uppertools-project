namespace CadastroDeEmpresas.Forms
{
    partial class FrmCadastraCNPJ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtAbertura = new System.Windows.Forms.MaskedTextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(537, 426);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(146, 36);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 426);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(146, 36);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(689, 426);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(146, 36);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtCEP);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(823, 159);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtComplemento);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtNumero);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtLogradouro);
            this.groupBox4.Controls.Add(this.txtBairro);
            this.groupBox4.Controls.Add(this.txtUF);
            this.groupBox4.Controls.Add(this.txtCidade);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(275, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(542, 128);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrando Informações do CEP";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(110, 96);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.ReadOnly = true;
            this.txtComplemento.Size = new System.Drawing.Size(426, 22);
            this.txtComplemento.TabIndex = 15;
            this.txtComplemento.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(456, 62);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(80, 22);
            this.txtNumero.TabIndex = 14;
            this.txtNumero.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(423, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Nº:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(98, 62);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.ReadOnly = true;
            this.txtLogradouro.Size = new System.Drawing.Size(319, 22);
            this.txtLogradouro.TabIndex = 23;
            this.txtLogradouro.TabStop = false;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(391, 25);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(145, 22);
            this.txtBairro.TabIndex = 22;
            this.txtBairro.TabStop = false;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(272, 25);
            this.txtUF.Name = "txtUF";
            this.txtUF.ReadOnly = true;
            this.txtUF.Size = new System.Drawing.Size(57, 22);
            this.txtUF.TabIndex = 21;
            this.txtUF.TabStop = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(68, 25);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(162, 22);
            this.txtCidade.TabIndex = 20;
            this.txtCidade.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Logradouro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Bairro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "UF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cidade:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(74, 66);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.ReadOnly = true;
            this.txtCEP.Size = new System.Drawing.Size(139, 22);
            this.txtCEP.TabIndex = 11;
            this.txtCEP.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "CEP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFantasia);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.mskTxtCNPJ);
            this.groupBox1.Controls.Add(this.mskTxtAbertura);
            this.groupBox1.Controls.Add(this.txtRazaoSocial);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 233);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Empresa";
            // 
            // mskTxtCNPJ
            // 
            this.mskTxtCNPJ.Location = new System.Drawing.Point(654, 36);
            this.mskTxtCNPJ.Mask = "00.000.000/0000-00";
            this.mskTxtCNPJ.Name = "mskTxtCNPJ";
            this.mskTxtCNPJ.Size = new System.Drawing.Size(145, 22);
            this.mskTxtCNPJ.TabIndex = 0;
            this.mskTxtCNPJ.ValidatingType = typeof(System.DateTime);
            // 
            // mskTxtAbertura
            // 
            this.mskTxtAbertura.Location = new System.Drawing.Point(709, 74);
            this.mskTxtAbertura.Mask = "00/00/0000";
            this.mskTxtAbertura.Name = "mskTxtAbertura";
            this.mskTxtAbertura.ReadOnly = true;
            this.mskTxtAbertura.Size = new System.Drawing.Size(90, 22);
            this.mskTxtAbertura.TabIndex = 3;
            this.mskTxtAbertura.TabStop = false;
            this.mskTxtAbertura.ValidatingType = typeof(System.DateTime);
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(114, 36);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.ReadOnly = true;
            this.txtRazaoSocial.Size = new System.Drawing.Size(481, 22);
            this.txtRazaoSocial.TabIndex = 1;
            this.txtRazaoSocial.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtTelefone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMensagem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTipo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtSituacao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(16, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(92, 29);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            this.txtSituacao.Size = new System.Drawing.Size(213, 22);
            this.txtSituacao.TabIndex = 5;
            this.txtSituacao.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Situação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Abertura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razão Social:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Fantasia:";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(114, 74);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.ReadOnly = true;
            this.txtFantasia.Size = new System.Drawing.Size(481, 22);
            this.txtFantasia.TabIndex = 6;
            this.txtFantasia.TabStop = false;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(396, 29);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(213, 22);
            this.txtTipo.TabIndex = 11;
            this.txtTipo.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(329, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "Tipo:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(92, 67);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ReadOnly = true;
            this.txtMensagem.Size = new System.Drawing.Size(213, 22);
            this.txtMensagem.TabIndex = 13;
            this.txtMensagem.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mensagem:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(396, 65);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(213, 22);
            this.txtTelefone.TabIndex = 15;
            this.txtTelefone.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefone:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(669, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 16;
            this.label16.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(625, 65);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(142, 22);
            this.txtStatus.TabIndex = 17;
            this.txtStatus.TabStop = false;
            // 
            // FrmCadastraCNPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 471);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(865, 518);
            this.MinimumSize = new System.Drawing.Size(865, 518);
            this.Name = "FrmCadastraCNPJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar CNPJ";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskTxtCNPJ;
        private System.Windows.Forms.MaskedTextBox mskTxtAbertura;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label16;
    }
}