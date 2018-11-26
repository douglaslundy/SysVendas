namespace ERP.frm
{
    partial class Frm_detalhar_venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_detalhar_venda));
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numero_venda = new System.Windows.Forms.TextBox();
            this.lb_numero_venda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_itens_vendas = new System.Windows.Forms.DataGridView();
            this.numeroItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_vendas = new System.Windows.Forms.DataGridView();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trocoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens_vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(759, 393);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(98, 39);
            this.btn_imprimir.TabIndex = 41;
            this.btn_imprimir.Text = "F12 - Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(782, 11);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 27);
            this.btn_buscar.TabIndex = 40;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = " Nº da Venda: ";
            // 
            // txt_numero_venda
            // 
            this.txt_numero_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_venda.Location = new System.Drawing.Point(659, 11);
            this.txt_numero_venda.Name = "txt_numero_venda";
            this.txt_numero_venda.Size = new System.Drawing.Size(100, 26);
            this.txt_numero_venda.TabIndex = 38;
            // 
            // lb_numero_venda
            // 
            this.lb_numero_venda.AutoSize = true;
            this.lb_numero_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero_venda.Location = new System.Drawing.Point(22, 11);
            this.lb_numero_venda.Name = "lb_numero_venda";
            this.lb_numero_venda.Size = new System.Drawing.Size(95, 20);
            this.lb_numero_venda.TabIndex = 37;
            this.lb_numero_venda.Text = "Venda Nº  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ítens:";
            // 
            // dgv_itens_vendas
            // 
            this.dgv_itens_vendas.AllowUserToAddRows = false;
            this.dgv_itens_vendas.AllowUserToDeleteRows = false;
            this.dgv_itens_vendas.AutoGenerateColumns = false;
            this.dgv_itens_vendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_itens_vendas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_itens_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itens_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroItemDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.precoProdutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn});
            this.dgv_itens_vendas.DataSource = this.itensVendaBindingSource;
            this.dgv_itens_vendas.Location = new System.Drawing.Point(12, 163);
            this.dgv_itens_vendas.Name = "dgv_itens_vendas";
            this.dgv_itens_vendas.ReadOnly = true;
            this.dgv_itens_vendas.Size = new System.Drawing.Size(845, 217);
            this.dgv_itens_vendas.TabIndex = 35;
            // 
            // numeroItemDataGridViewTextBoxColumn
            // 
            this.numeroItemDataGridViewTextBoxColumn.DataPropertyName = "NumeroItem";
            this.numeroItemDataGridViewTextBoxColumn.HeaderText = "Ítem";
            this.numeroItemDataGridViewTextBoxColumn.Name = "numeroItemDataGridViewTextBoxColumn";
            this.numeroItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroItemDataGridViewTextBoxColumn.Width = 52;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.produtoDataGridViewTextBoxColumn.Width = 300;
            // 
            // precoProdutoDataGridViewTextBoxColumn
            // 
            this.precoProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.precoProdutoDataGridViewTextBoxColumn.DataPropertyName = "PrecoProduto";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.precoProdutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.precoProdutoDataGridViewTextBoxColumn.HeaderText = "Preco do produto";
            this.precoProdutoDataGridViewTextBoxColumn.Name = "precoProdutoDataGridViewTextBoxColumn";
            this.precoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoProdutoDataGridViewTextBoxColumn.Width = 120;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.subTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "Sub Total";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.subTotalDataGridViewTextBoxColumn.Width = 130;
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(ERP.ItensVendas.ItensVenda);
            // 
            // dgv_vendas
            // 
            this.dgv_vendas.AllowUserToAddRows = false;
            this.dgv_vendas.AllowUserToDeleteRows = false;
            this.dgv_vendas.AutoGenerateColumns = false;
            this.dgv_vendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_vendas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteDataGridViewTextBoxColumn,
            this.totalVendaDataGridViewTextBoxColumn,
            this.totalPagoDataGridViewTextBoxColumn,
            this.trocoDataGridViewTextBoxColumn,
            this.dataVendaDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.tipoVendaDataGridViewTextBoxColumn});
            this.dgv_vendas.DataSource = this.vendaBindingSource;
            this.dgv_vendas.Location = new System.Drawing.Point(12, 44);
            this.dgv_vendas.Name = "dgv_vendas";
            this.dgv_vendas.ReadOnly = true;
            this.dgv_vendas.Size = new System.Drawing.Size(845, 90);
            this.dgv_vendas.TabIndex = 34;
            this.dgv_vendas.TabStop = false;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 180;
            // 
            // totalVendaDataGridViewTextBoxColumn
            // 
            this.totalVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalVendaDataGridViewTextBoxColumn.DataPropertyName = "TotalVenda";
            this.totalVendaDataGridViewTextBoxColumn.HeaderText = "Total da venda";
            this.totalVendaDataGridViewTextBoxColumn.Name = "totalVendaDataGridViewTextBoxColumn";
            this.totalVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalVendaDataGridViewTextBoxColumn.Width = 110;
            // 
            // totalPagoDataGridViewTextBoxColumn
            // 
            this.totalPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalPagoDataGridViewTextBoxColumn.DataPropertyName = "TotalPago";
            this.totalPagoDataGridViewTextBoxColumn.HeaderText = "Total pago";
            this.totalPagoDataGridViewTextBoxColumn.Name = "totalPagoDataGridViewTextBoxColumn";
            this.totalPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPagoDataGridViewTextBoxColumn.Width = 110;
            // 
            // trocoDataGridViewTextBoxColumn
            // 
            this.trocoDataGridViewTextBoxColumn.DataPropertyName = "Troco";
            this.trocoDataGridViewTextBoxColumn.HeaderText = "Troco";
            this.trocoDataGridViewTextBoxColumn.Name = "trocoDataGridViewTextBoxColumn";
            this.trocoDataGridViewTextBoxColumn.ReadOnly = true;
            this.trocoDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataVendaDataGridViewTextBoxColumn
            // 
            this.dataVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataVendaDataGridViewTextBoxColumn.DataPropertyName = "DataVenda";
            this.dataVendaDataGridViewTextBoxColumn.HeaderText = "Data da venda";
            this.dataVendaDataGridViewTextBoxColumn.Name = "dataVendaDataGridViewTextBoxColumn";
            this.dataVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVendaDataGridViewTextBoxColumn.Width = 110;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "Data de vencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVencimentoDataGridViewTextBoxColumn.Width = 130;
            // 
            // tipoVendaDataGridViewTextBoxColumn
            // 
            this.tipoVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipoVendaDataGridViewTextBoxColumn.DataPropertyName = "TipoVenda";
            this.tipoVendaDataGridViewTextBoxColumn.HeaderText = "Tipo da venda";
            this.tipoVendaDataGridViewTextBoxColumn.Name = "tipoVendaDataGridViewTextBoxColumn";
            this.tipoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(ERP.Vendas.Venda);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(13, 392);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(114, 39);
            this.btn_cancelar.TabIndex = 33;
            this.btn_cancelar.Text = "Esc - Fechar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Frm_detalhar_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 443);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numero_venda);
            this.Controls.Add(this.lb_numero_venda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_itens_vendas);
            this.Controls.Add(this.dgv_vendas);
            this.Controls.Add(this.btn_cancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_detalhar_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhar Venda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_detalhar_venda_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_detalhar_venda_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens_vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numero_venda;
        private System.Windows.Forms.Label lb_numero_venda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_itens_vendas;
        private System.Windows.Forms.DataGridView dgv_vendas;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trocoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVendaDataGridViewTextBoxColumn;
    }
}