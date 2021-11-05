namespace GPS1Visual
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.textBoxMostra = new System.Windows.Forms.TextBox();
            this.textBoxRetorno = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.textBoxPorta = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelEnvio = new System.Windows.Forms.Label();
            this.labelPorta = new System.Windows.Forms.Label();
            this.textBoxGPSNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.listBoxGPS = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.pesquisarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOVISUALGPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearDados = new System.Windows.Forms.Button();
            this.listBoxAutoComplete = new System.Windows.Forms.ListBox();
            this.buttonBuscarPlaca = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIniciar.Location = new System.Drawing.Point(593, 33);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // textBoxMostra
            // 
            this.textBoxMostra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMostra.Location = new System.Drawing.Point(265, 61);
            this.textBoxMostra.Multiline = true;
            this.textBoxMostra.Name = "textBoxMostra";
            this.textBoxMostra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMostra.Size = new System.Drawing.Size(403, 457);
            this.textBoxMostra.TabIndex = 2;
            // 
            // textBoxRetorno
            // 
            this.textBoxRetorno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRetorno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRetorno.Location = new System.Drawing.Point(475, 532);
            this.textBoxRetorno.Name = "textBoxRetorno";
            this.textBoxRetorno.Size = new System.Drawing.Size(112, 20);
            this.textBoxRetorno.TabIndex = 3;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnviar.Location = new System.Drawing.Point(593, 530);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 4;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // textBoxPorta
            // 
            this.textBoxPorta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPorta.Location = new System.Drawing.Point(487, 35);
            this.textBoxPorta.Name = "textBoxPorta";
            this.textBoxPorta.Size = new System.Drawing.Size(100, 20);
            this.textBoxPorta.TabIndex = 5;
            this.textBoxPorta.Text = "7500";
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(272, 535);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "ID";
            // 
            // labelEnvio
            // 
            this.labelEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEnvio.AutoSize = true;
            this.labelEnvio.Location = new System.Drawing.Point(435, 535);
            this.labelEnvio.Name = "labelEnvio";
            this.labelEnvio.Size = new System.Drawing.Size(34, 13);
            this.labelEnvio.TabIndex = 8;
            this.labelEnvio.Text = "Envio";
            // 
            // labelPorta
            // 
            this.labelPorta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPorta.AutoSize = true;
            this.labelPorta.Location = new System.Drawing.Point(446, 38);
            this.labelPorta.Name = "labelPorta";
            this.labelPorta.Size = new System.Drawing.Size(32, 13);
            this.labelPorta.TabIndex = 9;
            this.labelPorta.Text = "Porta";
            // 
            // textBoxGPSNum
            // 
            this.textBoxGPSNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGPSNum.Location = new System.Drawing.Point(32, 54);
            this.textBoxGPSNum.Name = "textBoxGPSNum";
            this.textBoxGPSNum.ReadOnly = true;
            this.textBoxGPSNum.Size = new System.Drawing.Size(61, 20);
            this.textBoxGPSNum.TabIndex = 10;
            this.textBoxGPSNum.Text = "0";
            this.textBoxGPSNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "GPS Conectados";
            // 
            // comboBoxID
            // 
            this.comboBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(294, 532);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(135, 21);
            this.comboBoxID.TabIndex = 12;
            // 
            // listBoxGPS
            // 
            this.listBoxGPS.FormattingEnabled = true;
            this.listBoxGPS.Location = new System.Drawing.Point(32, 120);
            this.listBoxGPS.Name = "listBoxGPS";
            this.listBoxGPS.Size = new System.Drawing.Size(160, 69);
            this.listBoxGPS.TabIndex = 13;
            this.listBoxGPS.DoubleClick += new System.EventHandler(this.listBoxGPS_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Localização do GPS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarToolStripMenuItem1});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.pesquisarClienteToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(293, 6);
            // 
            // pesquisarClienteToolStripMenuItem
            // 
            this.pesquisarClienteToolStripMenuItem.Name = "pesquisarClienteToolStripMenuItem";
            this.pesquisarClienteToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.pesquisarClienteToolStripMenuItem.Text = "Pesquisar,alterar e excluir dados do cliente";
            this.pesquisarClienteToolStripMenuItem.Click += new System.EventHandler(this.pesquisarClienteToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOVISUALGPSToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreOVISUALGPSToolStripMenuItem
            // 
            this.sobreOVISUALGPSToolStripMenuItem.Name = "sobreOVISUALGPSToolStripMenuItem";
            this.sobreOVISUALGPSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreOVISUALGPSToolStripMenuItem.Text = "Sobre o GPS Tracker";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxAutoComplete);
            this.groupBox1.Controls.Add(this.buttonBuscarPlaca);
            this.groupBox1.Controls.Add(this.textBoxPesquisa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxGPSNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBoxGPS);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 529);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPS";
            // 
            // buttonClearDados
            // 
            this.buttonClearDados.Location = new System.Drawing.Point(265, 32);
            this.buttonClearDados.Name = "buttonClearDados";
            this.buttonClearDados.Size = new System.Drawing.Size(124, 22);
            this.buttonClearDados.TabIndex = 20;
            this.buttonClearDados.Text = "Limpar dados enviados";
            this.buttonClearDados.UseVisualStyleBackColor = true;
            this.buttonClearDados.Click += new System.EventHandler(this.buttonClearDados_Click);
            // 
            // listBoxAutoComplete
            // 
            this.listBoxAutoComplete.FormattingEnabled = true;
            this.listBoxAutoComplete.Location = new System.Drawing.Point(32, 259);
            this.listBoxAutoComplete.Name = "listBoxAutoComplete";
            this.listBoxAutoComplete.Size = new System.Drawing.Size(160, 95);
            this.listBoxAutoComplete.TabIndex = 19;
            this.listBoxAutoComplete.Visible = false;
            this.listBoxAutoComplete.DoubleClick += new System.EventHandler(this.listBoxAutoComplete_DoubleClick);
            // 
            // buttonBuscarPlaca
            // 
            this.buttonBuscarPlaca.Location = new System.Drawing.Point(155, 236);
            this.buttonBuscarPlaca.Name = "buttonBuscarPlaca";
            this.buttonBuscarPlaca.Size = new System.Drawing.Size(37, 23);
            this.buttonBuscarPlaca.TabIndex = 18;
            this.buttonBuscarPlaca.Text = "Ir";
            this.buttonBuscarPlaca.UseVisualStyleBackColor = true;
            this.buttonBuscarPlaca.Click += new System.EventHandler(this.buttonBuscarPlaca_Click);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(32, 238);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(119, 20);
            this.textBoxPesquisa.TabIndex = 17;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Localizar por Placa";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.salvarToolStripMenuItem1.Text = "&Salvar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 568);
            this.Controls.Add(this.buttonClearDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.labelPorta);
            this.Controls.Add(this.labelEnvio);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxPorta);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxRetorno);
            this.Controls.Add(this.textBoxMostra);
            this.Controls.Add(this.buttonIniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GPS Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.TextBox textBoxMostra;
        private System.Windows.Forms.TextBox textBoxRetorno;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.TextBox textBoxPorta;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelEnvio;
        private System.Windows.Forms.Label labelPorta;
        private System.Windows.Forms.TextBox textBoxGPSNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.ListBox listBoxGPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxAutoComplete;
        private System.Windows.Forms.Button buttonBuscarPlaca;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOVISUALGPSToolStripMenuItem;
        private System.Windows.Forms.Button buttonClearDados;
        private System.Windows.Forms.ToolStripSeparator salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem1;
    }
}

