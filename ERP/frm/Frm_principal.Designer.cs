namespace ERP.frm
{
    partial class Frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consolidadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesInadimplentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueBaixoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Pdv = new System.Windows.Forms.ToolStripButton();
            this.Backup = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.balancaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consolidadoToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.pDVToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1211, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.balancaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(332, 36);
            this.clientesToolStripMenuItem.Text = "[ F2 ] - Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(332, 36);
            this.produtosToolStripMenuItem.Text = "[ F3 ] - Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // consolidadoToolStripMenuItem
            // 
            this.consolidadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.clientesInadimplentesToolStripMenuItem,
            this.produtosToolStripMenuItem1,
            this.vendasToolStripMenuItem,
            this.estoqueBaixoToolStripMenuItem});
            this.consolidadoToolStripMenuItem.Name = "consolidadoToolStripMenuItem";
            this.consolidadoToolStripMenuItem.Size = new System.Drawing.Size(160, 36);
            this.consolidadoToolStripMenuItem.Text = "Consolidado";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(339, 36);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // clientesInadimplentesToolStripMenuItem
            // 
            this.clientesInadimplentesToolStripMenuItem.Name = "clientesInadimplentesToolStripMenuItem";
            this.clientesInadimplentesToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.clientesInadimplentesToolStripMenuItem.Text = "Clientes Inadimplentes";
            this.clientesInadimplentesToolStripMenuItem.Click += new System.EventHandler(this.clientesInadimplentesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(339, 36);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // estoqueBaixoToolStripMenuItem
            // 
            this.estoqueBaixoToolStripMenuItem.Name = "estoqueBaixoToolStripMenuItem";
            this.estoqueBaixoToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.estoqueBaixoToolStripMenuItem.Text = "Estoque Baixo";
            this.estoqueBaixoToolStripMenuItem.Click += new System.EventHandler(this.estoqueBaixoToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaEstoqueToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(112, 36);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // entradaEstoqueToolStripMenuItem
            // 
            this.entradaEstoqueToolStripMenuItem.Name = "entradaEstoqueToolStripMenuItem";
            this.entradaEstoqueToolStripMenuItem.Size = new System.Drawing.Size(253, 36);
            this.entradaEstoqueToolStripMenuItem.Text = "[ F5 ] - Entrada";
            this.entradaEstoqueToolStripMenuItem.Click += new System.EventHandler(this.entradaEstoqueToolStripMenuItem_Click);
            // 
            // pDVToolStripMenuItem
            // 
            this.pDVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDVToolStripMenuItem1});
            this.pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            this.pDVToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.pDVToolStripMenuItem.Text = "PDV";
            // 
            // pDVToolStripMenuItem1
            // 
            this.pDVToolStripMenuItem1.Name = "pDVToolStripMenuItem1";
            this.pDVToolStripMenuItem1.Size = new System.Drawing.Size(231, 36);
            this.pDVToolStripMenuItem1.Text = "[ F12 ] - PDV";
            this.pDVToolStripMenuItem1.Click += new System.EventHandler(this.pDVToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaveToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 36);
            this.toolStripMenuItem1.Text = "+";
            // 
            // chaveToolStripMenuItem
            // 
            this.chaveToolStripMenuItem.Name = "chaveToolStripMenuItem";
            this.chaveToolStripMenuItem.Size = new System.Drawing.Size(162, 36);
            this.chaveToolStripMenuItem.Text = "Chave";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(66, 36);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(135, 36);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pdv,
            this.Backup});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1211, 67);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Pdv
            // 
            this.Pdv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pdv.Image = ((System.Drawing.Image)(resources.GetObject("Pdv.Image")));
            this.Pdv.ImageTransparentColor = System.Drawing.Color.Black;
            this.Pdv.Name = "Pdv";
            this.Pdv.Size = new System.Drawing.Size(64, 64);
            this.Pdv.Text = "PDV";
            this.Pdv.Click += new System.EventHandler(this.Pdv_Click);
            // 
            // Backup
            // 
            this.Backup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Backup.Image = ((System.Drawing.Image)(resources.GetObject("Backup.Image")));
            this.Backup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(64, 64);
            this.Backup.Text = "Backup";
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(24, 127);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1157, 513);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 645);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1211, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(174, 20);
            this.toolStripStatusLabel1.Text = "Bem Vindo ao sysVendas";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(332, 36);
            this.toolStripMenuItem2.Text = "[ F4 ] - Funcionarios";
            // 
            // balancaToolStripMenuItem
            // 
            this.balancaToolStripMenuItem.Name = "balancaToolStripMenuItem";
            this.balancaToolStripMenuItem.Size = new System.Drawing.Size(332, 36);
            this.balancaToolStripMenuItem.Text = "[ F6 ] - Config Balança";
            this.balancaToolStripMenuItem.Click += new System.EventHandler(this.balancaToolStripMenuItem_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1211, 670);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1226, 706);
            this.Name = "Frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sysVendas - Sistema Comercial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_principal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consolidadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesInadimplentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueBaixoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Pdv;
        private System.Windows.Forms.ToolStripButton Backup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem balancaToolStripMenuItem;
    }
}