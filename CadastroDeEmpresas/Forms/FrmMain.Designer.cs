namespace CadastroDeEmpresas
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cadastroEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroEmpresa = new CadastroDeEmpresas.CadastroEmpresa();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cNPJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.timerSegundos = new System.Windows.Forms.Timer(this.components);
            this.cPFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cNPJToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEmpresa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastroEmpresaBindingSource
            // 
            this.cadastroEmpresaBindingSource.DataSource = this.cadastroEmpresa;
            this.cadastroEmpresaBindingSource.Position = 0;
            // 
            // cadastroEmpresa
            // 
            this.cadastroEmpresa.DataSetName = "CadastroEmpresa";
            this.cadastroEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPFToolStripMenuItem1,
            this.cNPJToolStripMenuItem1});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPFToolStripMenuItem,
            this.cNPJToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // cPFToolStripMenuItem
            // 
            this.cPFToolStripMenuItem.Name = "cPFToolStripMenuItem";
            this.cPFToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.cPFToolStripMenuItem.Text = "CPF";
            this.cPFToolStripMenuItem.Click += new System.EventHandler(this.cPFToolStripMenuItem_Click);
            // 
            // cNPJToolStripMenuItem
            // 
            this.cNPJToolStripMenuItem.Name = "cNPJToolStripMenuItem";
            this.cNPJToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.cNPJToolStripMenuItem.Text = "CNPJ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 527);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(976, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblDataHora
            // 
            this.lblDataHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDataHora.Location = new System.Drawing.Point(12, 534);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(48, 17);
            this.lblDataHora.TabIndex = 2;
            this.lblDataHora.Text = "          ";
            // 
            // timerSegundos
            // 
            this.timerSegundos.Enabled = true;
            this.timerSegundos.Interval = 1000;
            this.timerSegundos.Tick += new System.EventHandler(this.timerSegundos_Tick);
            // 
            // cPFToolStripMenuItem1
            // 
            this.cPFToolStripMenuItem1.Name = "cPFToolStripMenuItem1";
            this.cPFToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.cPFToolStripMenuItem1.Text = "CPF";
            this.cPFToolStripMenuItem1.Click += new System.EventHandler(this.cPFToolStripMenuItem1_Click);
            // 
            // cNPJToolStripMenuItem1
            // 
            this.cNPJToolStripMenuItem1.Name = "cNPJToolStripMenuItem1";
            this.cNPJToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.cNPJToolStripMenuItem1.Text = "CNPJ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 558);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vinicius Espinosa - Uppertools";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEmpresa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cadastroEmpresaBindingSource;
        private CadastroEmpresa cadastroEmpresa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Timer timerSegundos;
        private System.Windows.Forms.ToolStripMenuItem cPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cNPJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPFToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cNPJToolStripMenuItem1;
    }
}

