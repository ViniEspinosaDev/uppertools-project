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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.cadastroEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroEmpresa = new CadastroDeEmpresas.CadastroEmpresa();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cNPJToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cNPJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.timerSegundos = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEmpresa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1171, 28);
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
            // cPFToolStripMenuItem1
            // 
            this.cPFToolStripMenuItem1.Name = "cPFToolStripMenuItem1";
            this.cPFToolStripMenuItem1.Size = new System.Drawing.Size(124, 26);
            this.cPFToolStripMenuItem1.Text = "CPF";
            this.cPFToolStripMenuItem1.Click += new System.EventHandler(this.cPFToolStripMenuItem1_Click);
            // 
            // cNPJToolStripMenuItem1
            // 
            this.cNPJToolStripMenuItem1.Name = "cNPJToolStripMenuItem1";
            this.cNPJToolStripMenuItem1.Size = new System.Drawing.Size(124, 26);
            this.cNPJToolStripMenuItem1.Text = "CNPJ";
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 614);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1171, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblDataHora
            // 
            this.lblDataHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDataHora.Location = new System.Drawing.Point(12, 621);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(559, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 366);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novidades";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(24, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sobre";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(568, 18);
            this.label16.TabIndex = 17;
            this.label16.Text = "========================================================";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(330, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "• Retorna Endereço";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(147, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "• Consulta por CEP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Correios API: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(568, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "========================================================";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "• Consulta Todos CNPJ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "• Consulta Todos CPF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "• Consulta por Razão Social";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "• Consulta por Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "• Consulta por CNPJ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "• Consulta por CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "• Cadastra Pessoa Jurídica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "• Cadastra Pessoa Fisica ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Banco de Dados: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(568, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "========================================================";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUNÇÕES ATUAIS";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contatos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(498, 18);
            this.label17.TabIndex = 33;
            this.label17.Text = "=================================================";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(333, 229);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 17);
            this.label18.TabIndex = 32;
            this.label18.Text = "• Retorna Endereço";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(150, 229);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 17);
            this.label19.TabIndex = 31;
            this.label19.Text = "• Consulta por CEP";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 229);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 17);
            this.label20.TabIndex = 30;
            this.label20.Text = "Correios API: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(23, 201);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(498, 18);
            this.label21.TabIndex = 29;
            this.label21.Text = "=================================================";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(333, 173);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(155, 17);
            this.label22.TabIndex = 28;
            this.label22.Text = "• Consulta Todos CNPJ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(150, 173);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(146, 17);
            this.label23.TabIndex = 27;
            this.label23.Text = "• Consulta Todos CPF";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(333, 142);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(184, 17);
            this.label24.TabIndex = 26;
            this.label24.Text = "• Consulta por Razão Social";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(150, 142);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(138, 17);
            this.label25.TabIndex = 25;
            this.label25.Text = "• Consulta por Nome";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(150, 110);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(231, 17);
            this.label27.TabIndex = 23;
            this.label27.Text = "• E-Mail: vini.espinosa1@gmail.com";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(150, 79);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(244, 17);
            this.label29.TabIndex = 21;
            this.label29.Text = "• Nome: Vinícius Espinosa de Oliveira";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(23, 79);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(111, 17);
            this.label30.TabIndex = 20;
            this.label30.Text = "Desenvolvedor: ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(23, 50);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(498, 18);
            this.label31.TabIndex = 19;
            this.label31.Text = "=================================================";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(23, 24);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(83, 17);
            this.label32.TabIndex = 18;
            this.label32.Text = "CONTATO";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(544, 302);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Em Breve";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1171, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1189, 692);
            this.MinimumSize = new System.Drawing.Size(761, 495);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vinicius Espinosa - Uppertools";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEmpresa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
    }
}

