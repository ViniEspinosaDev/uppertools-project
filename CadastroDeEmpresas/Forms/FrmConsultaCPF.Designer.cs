namespace CadastroDeEmpresas.Forms
{
    partial class FrmConsultaCPF
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
            this.grpBoxConsultaCPF = new System.Windows.Forms.GroupBox();
            this.txtBoxAux = new System.Windows.Forms.TextBox();
            this.dataGridViewConsulCPF = new System.Windows.Forms.DataGridView();
            this.grpBoxConsultaCPFbuttons = new System.Windows.Forms.GroupBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnConsultaCPFsair = new System.Windows.Forms.Button();
            this.btnConsultaCPFalterar = new System.Windows.Forms.Button();
            this.btnConsultaCPFentrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTxtConsultaCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsultaNOME = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBoxConsultaCPF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulCPF)).BeginInit();
            this.grpBoxConsultaCPFbuttons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxConsultaCPF
            // 
            this.grpBoxConsultaCPF.Controls.Add(this.txtBoxAux);
            this.grpBoxConsultaCPF.Controls.Add(this.dataGridViewConsulCPF);
            this.grpBoxConsultaCPF.Location = new System.Drawing.Point(12, 12);
            this.grpBoxConsultaCPF.Name = "grpBoxConsultaCPF";
            this.grpBoxConsultaCPF.Size = new System.Drawing.Size(823, 352);
            this.grpBoxConsultaCPF.TabIndex = 2;
            this.grpBoxConsultaCPF.TabStop = false;
            this.grpBoxConsultaCPF.Text = "Listando Dados";
            // 
            // txtBoxAux
            // 
            this.txtBoxAux.Location = new System.Drawing.Point(824, -10);
            this.txtBoxAux.Name = "txtBoxAux";
            this.txtBoxAux.Size = new System.Drawing.Size(10, 22);
            this.txtBoxAux.TabIndex = 6;
            this.txtBoxAux.Visible = false;
            // 
            // dataGridViewConsulCPF
            // 
            this.dataGridViewConsulCPF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulCPF.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewConsulCPF.Name = "dataGridViewConsulCPF";
            this.dataGridViewConsulCPF.RowHeadersWidth = 51;
            this.dataGridViewConsulCPF.RowTemplate.Height = 24;
            this.dataGridViewConsulCPF.Size = new System.Drawing.Size(811, 325);
            this.dataGridViewConsulCPF.TabIndex = 0;
            // 
            // grpBoxConsultaCPFbuttons
            // 
            this.grpBoxConsultaCPFbuttons.Controls.Add(this.btnMostrarTodos);
            this.grpBoxConsultaCPFbuttons.Controls.Add(this.btnConsultaCPFsair);
            this.grpBoxConsultaCPFbuttons.Controls.Add(this.btnConsultaCPFalterar);
            this.grpBoxConsultaCPFbuttons.Controls.Add(this.btnConsultaCPFentrar);
            this.grpBoxConsultaCPFbuttons.Location = new System.Drawing.Point(12, 364);
            this.grpBoxConsultaCPFbuttons.Name = "grpBoxConsultaCPFbuttons";
            this.grpBoxConsultaCPFbuttons.Size = new System.Drawing.Size(316, 103);
            this.grpBoxConsultaCPFbuttons.TabIndex = 1;
            this.grpBoxConsultaCPFbuttons.TabStop = false;
            this.grpBoxConsultaCPFbuttons.Text = "Funções";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(112, 21);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(198, 26);
            this.btnMostrarTodos.TabIndex = 2;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnConsultaCPFsair
            // 
            this.btnConsultaCPFsair.Location = new System.Drawing.Point(218, 53);
            this.btnConsultaCPFsair.Name = "btnConsultaCPFsair";
            this.btnConsultaCPFsair.Size = new System.Drawing.Size(92, 38);
            this.btnConsultaCPFsair.TabIndex = 5;
            this.btnConsultaCPFsair.Text = "Sair";
            this.btnConsultaCPFsair.UseVisualStyleBackColor = true;
            this.btnConsultaCPFsair.Click += new System.EventHandler(this.btnConsultaCPFsair_Click);
            // 
            // btnConsultaCPFalterar
            // 
            this.btnConsultaCPFalterar.Location = new System.Drawing.Point(112, 53);
            this.btnConsultaCPFalterar.Name = "btnConsultaCPFalterar";
            this.btnConsultaCPFalterar.Size = new System.Drawing.Size(92, 38);
            this.btnConsultaCPFalterar.TabIndex = 4;
            this.btnConsultaCPFalterar.Text = "Excluir";
            this.btnConsultaCPFalterar.UseVisualStyleBackColor = true;
            this.btnConsultaCPFalterar.Click += new System.EventHandler(this.btnConsultaCPFalterar_Click);
            // 
            // btnConsultaCPFentrar
            // 
            this.btnConsultaCPFentrar.Location = new System.Drawing.Point(6, 53);
            this.btnConsultaCPFentrar.Name = "btnConsultaCPFentrar";
            this.btnConsultaCPFentrar.Size = new System.Drawing.Size(92, 38);
            this.btnConsultaCPFentrar.TabIndex = 3;
            this.btnConsultaCPFentrar.Text = "Visualizar";
            this.btnConsultaCPFentrar.UseVisualStyleBackColor = true;
            this.btnConsultaCPFentrar.Click += new System.EventHandler(this.btnConsultaCPFentrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.mskTxtConsultaCPF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConsultaNOME);
            this.groupBox1.Location = new System.Drawing.Point(334, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 103);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // mskTxtConsultaCPF
            // 
            this.mskTxtConsultaCPF.Location = new System.Drawing.Point(90, 69);
            this.mskTxtConsultaCPF.Mask = "000,000,000-00";
            this.mskTxtConsultaCPF.Name = "mskTxtConsultaCPF";
            this.mskTxtConsultaCPF.Size = new System.Drawing.Size(99, 22);
            this.mskTxtConsultaCPF.TabIndex = 9;
            this.mskTxtConsultaCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTxtConsultaCPF_MaskInputRejected);
            this.mskTxtConsultaCPF.Click += new System.EventHandler(this.mskTxtConsultaCPF_Click);
            this.mskTxtConsultaCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTxtConsultaCPF_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtConsultaNOME
            // 
            this.txtConsultaNOME.Location = new System.Drawing.Point(90, 38);
            this.txtConsultaNOME.Name = "txtConsultaNOME";
            this.txtConsultaNOME.Size = new System.Drawing.Size(212, 22);
            this.txtConsultaNOME.TabIndex = 7;
            this.txtConsultaNOME.Click += new System.EventHandler(this.txtConsultaNOME_Click);
            this.txtConsultaNOME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultaNOME_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(323, 53);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(163, 36);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "* Enter p/ pesquisar *";
            // 
            // FrmConsultaCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxConsultaCPFbuttons);
            this.Controls.Add(this.grpBoxConsultaCPF);
            this.MaximumSize = new System.Drawing.Size(865, 518);
            this.MinimumSize = new System.Drawing.Size(865, 518);
            this.Name = "FrmConsultaCPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultando CPF";
            this.Load += new System.EventHandler(this.FrmConsultaCPF_Load);
            this.grpBoxConsultaCPF.ResumeLayout(false);
            this.grpBoxConsultaCPF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulCPF)).EndInit();
            this.grpBoxConsultaCPFbuttons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBoxConsultaCPF;
        private System.Windows.Forms.DataGridView dataGridViewConsulCPF;
        private System.Windows.Forms.GroupBox grpBoxConsultaCPFbuttons;
        private System.Windows.Forms.Button btnConsultaCPFsair;
        private System.Windows.Forms.Button btnConsultaCPFalterar;
        private System.Windows.Forms.Button btnConsultaCPFentrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskTxtConsultaCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsultaNOME;
        private System.Windows.Forms.TextBox txtBoxAux;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
    }
}