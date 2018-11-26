namespace ERP.frm
{
    partial class Frm_pdv
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_pdv));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_relogio = new System.Windows.Forms.Label();
            this.dgv_produtos_na_venda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrinhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.lb_desconto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_pesquisar_produtos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_nome_produto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sub_total = new System.Windows.Forms.TextBox();
            this.btn_desconto = new System.Windows.Forms.Button();
            this.btn_remover_produtos = new System.Windows.Forms.Button();
            this.btn_finalizar_venda = new System.Windows.Forms.Button();
            this.txt_valor_total = new System.Windows.Forms.Label();
            this.listViewCaixa = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_preco_unitario = new System.Windows.Forms.TextBox();
            this.txt_qdt_produtos = new System.Windows.Forms.TextBox();
            this.txt_codigo_produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.timer_relogio_pdv = new System.Windows.Forms.Timer(this.components);
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_operador = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos_na_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_relogio);
            this.panel1.Controls.Add(this.dgv_produtos_na_venda);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lb_desconto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_pesquisar_produtos);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lb_nome_produto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_sub_total);
            this.panel1.Controls.Add(this.btn_desconto);
            this.panel1.Controls.Add(this.btn_remover_produtos);
            this.panel1.Controls.Add(this.btn_finalizar_venda);
            this.panel1.Controls.Add(this.txt_valor_total);
            this.panel1.Controls.Add(this.listViewCaixa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_preco_unitario);
            this.panel1.Controls.Add(this.txt_qdt_produtos);
            this.panel1.Controls.Add(this.txt_codigo_produto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Location = new System.Drawing.Point(92, 81);
            this.panel1.MaximumSize = new System.Drawing.Size(800, 600);
            this.panel1.MinimumSize = new System.Drawing.Size(783, 559);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 482);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 39);
            this.label11.TabIndex = 53;
            this.label11.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 52;
            this.label3.Text = "Total:";
            // 
            // lb_relogio
            // 
            this.lb_relogio.AutoSize = true;
            this.lb_relogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_relogio.ForeColor = System.Drawing.Color.Blue;
            this.lb_relogio.Location = new System.Drawing.Point(458, 555);
            this.lb_relogio.Name = "lb_relogio";
            this.lb_relogio.Size = new System.Drawing.Size(96, 29);
            this.lb_relogio.TabIndex = 51;
            this.lb_relogio.Text = "relogio";
            // 
            // dgv_produtos_na_venda
            // 
            this.dgv_produtos_na_venda.AllowUserToAddRows = false;
            this.dgv_produtos_na_venda.AllowUserToDeleteRows = false;
            this.dgv_produtos_na_venda.AllowUserToResizeColumns = false;
            this.dgv_produtos_na_venda.AllowUserToResizeRows = false;
            this.dgv_produtos_na_venda.AutoGenerateColumns = false;
            this.dgv_produtos_na_venda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_produtos_na_venda.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_produtos_na_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos_na_venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_produtos_na_venda.DataSource = this.carrinhoBindingSource;
            this.dgv_produtos_na_venda.Location = new System.Drawing.Point(17, 174);
            this.dgv_produtos_na_venda.Name = "dgv_produtos_na_venda";
            this.dgv_produtos_na_venda.ReadOnly = true;
            this.dgv_produtos_na_venda.Size = new System.Drawing.Size(516, 242);
            this.dgv_produtos_na_venda.TabIndex = 50;
            this.dgv_produtos_na_venda.TabStop = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NumeroItem";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ítem";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 52;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 230;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.valorUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            this.valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorUnitarioDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantidade";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "QDT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SubTotal";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // carrinhoBindingSource
            // 
            this.carrinhoBindingSource.DataSource = typeof(ERP.Carrinhos.Carrinho);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(627, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "[ Esc ] - Sair";
            // 
            // lb_desconto
            // 
            this.lb_desconto.AutoSize = true;
            this.lb_desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_desconto.ForeColor = System.Drawing.Color.Red;
            this.lb_desconto.Location = new System.Drawing.Point(37, 550);
            this.lb_desconto.Name = "lb_desconto";
            this.lb_desconto.Size = new System.Drawing.Size(62, 29);
            this.lb_desconto.TabIndex = 48;
            this.lb_desconto.Text = "0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(548, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Produtos";
            // 
            // btn_pesquisar_produtos
            // 
            this.btn_pesquisar_produtos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_pesquisar_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar_produtos.Location = new System.Drawing.Point(544, 473);
            this.btn_pesquisar_produtos.Name = "btn_pesquisar_produtos";
            this.btn_pesquisar_produtos.Size = new System.Drawing.Size(65, 48);
            this.btn_pesquisar_produtos.TabIndex = 3;
            this.btn_pesquisar_produtos.Text = "[ F7 ]";
            this.btn_pesquisar_produtos.UseVisualStyleBackColor = true;
            this.btn_pesquisar_produtos.Click += new System.EventHandler(this.btn_pesquisar_produtos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(709, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Finalizar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(628, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Remover";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Desconto";
            // 
            // lb_nome_produto
            // 
            this.lb_nome_produto.AutoSize = true;
            this.lb_nome_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_produto.Location = new System.Drawing.Point(26, 105);
            this.lb_nome_produto.Name = "lb_nome_produto";
            this.lb_nome_produto.Size = new System.Drawing.Size(307, 33);
            this.lb_nome_produto.TabIndex = 42;
            this.lb_nome_produto.Text = "Nome do produto ----";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "SubTotal:";
            // 
            // txt_sub_total
            // 
            this.txt_sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub_total.Location = new System.Drawing.Point(539, 373);
            this.txt_sub_total.Name = "txt_sub_total";
            this.txt_sub_total.Size = new System.Drawing.Size(224, 40);
            this.txt_sub_total.TabIndex = 0;
            this.txt_sub_total.TabStop = false;
            // 
            // btn_desconto
            // 
            this.btn_desconto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desconto.Location = new System.Drawing.Point(464, 473);
            this.btn_desconto.Name = "btn_desconto";
            this.btn_desconto.Size = new System.Drawing.Size(65, 48);
            this.btn_desconto.TabIndex = 2;
            this.btn_desconto.Text = "[ F2 ]";
            this.btn_desconto.UseVisualStyleBackColor = true;
            this.btn_desconto.Click += new System.EventHandler(this.btn_desconto_Click);
            // 
            // btn_remover_produtos
            // 
            this.btn_remover_produtos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_remover_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover_produtos.Location = new System.Drawing.Point(622, 473);
            this.btn_remover_produtos.Name = "btn_remover_produtos";
            this.btn_remover_produtos.Size = new System.Drawing.Size(65, 48);
            this.btn_remover_produtos.TabIndex = 4;
            this.btn_remover_produtos.Text = "[ F8 ]";
            this.btn_remover_produtos.UseVisualStyleBackColor = true;
            this.btn_remover_produtos.Click += new System.EventHandler(this.btn_remover_produtos_Click);
            // 
            // btn_finalizar_venda
            // 
            this.btn_finalizar_venda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_finalizar_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar_venda.Location = new System.Drawing.Point(702, 473);
            this.btn_finalizar_venda.Name = "btn_finalizar_venda";
            this.btn_finalizar_venda.Size = new System.Drawing.Size(65, 48);
            this.btn_finalizar_venda.TabIndex = 5;
            this.btn_finalizar_venda.Text = "[ F12 ]";
            this.btn_finalizar_venda.UseVisualStyleBackColor = true;
            this.btn_finalizar_venda.Click += new System.EventHandler(this.btn_finalizar_venda_Click);
            // 
            // txt_valor_total
            // 
            this.txt_valor_total.AutoSize = true;
            this.txt_valor_total.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_valor_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_total.Location = new System.Drawing.Point(81, 462);
            this.txt_valor_total.Name = "txt_valor_total";
            this.txt_valor_total.Size = new System.Drawing.Size(162, 73);
            this.txt_valor_total.TabIndex = 36;
            this.txt_valor_total.Text = "0,00";
            // 
            // listViewCaixa
            // 
            this.listViewCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCaixa.Location = new System.Drawing.Point(32, 174);
            this.listViewCaixa.Name = "listViewCaixa";
            this.listViewCaixa.Size = new System.Drawing.Size(410, 239);
            this.listViewCaixa.TabIndex = 0;
            this.listViewCaixa.TabStop = false;
            this.listViewCaixa.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Preço Unitário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantidade:";
            // 
            // txt_preco_unitario
            // 
            this.txt_preco_unitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preco_unitario.Location = new System.Drawing.Point(539, 272);
            this.txt_preco_unitario.Name = "txt_preco_unitario";
            this.txt_preco_unitario.Size = new System.Drawing.Size(224, 40);
            this.txt_preco_unitario.TabIndex = 0;
            this.txt_preco_unitario.TabStop = false;
            // 
            // txt_qdt_produtos
            // 
            this.txt_qdt_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qdt_produtos.Location = new System.Drawing.Point(539, 174);
            this.txt_qdt_produtos.Name = "txt_qdt_produtos";
            this.txt_qdt_produtos.Size = new System.Drawing.Size(224, 40);
            this.txt_qdt_produtos.TabIndex = 0;
            this.txt_qdt_produtos.TabStop = false;
            // 
            // txt_codigo_produto
            // 
            this.txt_codigo_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_produto.Location = new System.Drawing.Point(117, 44);
            this.txt_codigo_produto.Name = "txt_codigo_produto";
            this.txt_codigo_produto.Size = new System.Drawing.Size(646, 47);
            this.txt_codigo_produto.TabIndex = 1;
            this.txt_codigo_produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_produto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código:";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(8, 6);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(228, 25);
            this.Titulo.TabIndex = 13;
            this.Titulo.Text = "PDV - Ponto de Venda";
            // 
            // timer_relogio_pdv
            // 
            this.timer_relogio_pdv.Tick += new System.EventHandler(this.timer_relogio_pdv_Tick);
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(121, 733);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(68, 20);
            this.lb_usuario.TabIndex = 54;
            this.lb_usuario.Text = "usuario";
            // 
            // lb_operador
            // 
            this.lb_operador.AutoSize = true;
            this.lb_operador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_operador.Location = new System.Drawing.Point(12, 733);
            this.lb_operador.Name = "lb_operador";
            this.lb_operador.Size = new System.Drawing.Size(111, 20);
            this.lb_operador.TabIndex = 55;
            this.lb_operador.Text = "Operador(a):";
            // 
            // Frm_pdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.lb_operador);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_pdv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_pdv";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_pdv_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_pdv_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos_na_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_relogio;
        private System.Windows.Forms.DataGridView dgv_produtos_na_venda;
        protected internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_desconto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_pesquisar_produtos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_nome_produto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sub_total;
        private System.Windows.Forms.Button btn_desconto;
        private System.Windows.Forms.Button btn_remover_produtos;
        private System.Windows.Forms.Button btn_finalizar_venda;
        private System.Windows.Forms.Label txt_valor_total;
        private System.Windows.Forms.ListView listViewCaixa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_preco_unitario;
        private System.Windows.Forms.TextBox txt_qdt_produtos;
        private System.Windows.Forms.TextBox txt_codigo_produto;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Timer timer_relogio_pdv;
        protected internal System.Windows.Forms.Label lb_usuario;
        protected internal System.Windows.Forms.Label lb_operador;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carrinhoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}