namespace ERP.frm
{
    partial class Frm_efetuar_pagamentos_compras_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_efetuar_pagamentos_compras_cliente));
            this.btn_detalhar_compra = new System.Windows.Forms.Button();
            this.lb_vendas = new System.Windows.Forms.Label();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.lb_total_pagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.dgv_vendas = new System.Windows.Forms.DataGridView();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_detalhar_compra
            // 
            this.btn_detalhar_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalhar_compra.Location = new System.Drawing.Point(256, 313);
            this.btn_detalhar_compra.Name = "btn_detalhar_compra";
            this.btn_detalhar_compra.Size = new System.Drawing.Size(156, 37);
            this.btn_detalhar_compra.TabIndex = 33;
            this.btn_detalhar_compra.Text = "[ F5 ] - Detalhar";
            this.btn_detalhar_compra.UseVisualStyleBackColor = true;
            this.btn_detalhar_compra.Click += new System.EventHandler(this.btn_detalhar_compra_Click);
            // 
            // lb_vendas
            // 
            this.lb_vendas.AutoSize = true;
            this.lb_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vendas.Location = new System.Drawing.Point(6, 9);
            this.lb_vendas.Name = "lb_vendas";
            this.lb_vendas.Size = new System.Drawing.Size(151, 20);
            this.lb_vendas.TabIndex = 26;
            this.lb_vendas.Text = "Vendas a receber";
            this.lb_vendas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_pagar
            // 
            this.btn_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.Location = new System.Drawing.Point(437, 313);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(142, 37);
            this.btn_pagar.TabIndex = 32;
            this.btn_pagar.Text = "[ F12 ] - Pagar";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // lb_total_pagar
            // 
            this.lb_total_pagar.AutoSize = true;
            this.lb_total_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_pagar.ForeColor = System.Drawing.Color.Red;
            this.lb_total_pagar.Location = new System.Drawing.Point(6, 321);
            this.lb_total_pagar.Name = "lb_total_pagar";
            this.lb_total_pagar.Size = new System.Drawing.Size(164, 20);
            this.lb_total_pagar.TabIndex = 31;
            this.lb_total_pagar.Text = "Total a Pagar = R$ ";
            this.lb_total_pagar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "[ Esc ] - Sair";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_cliente);
            this.panel1.Location = new System.Drawing.Point(10, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 39);
            this.panel1.TabIndex = 30;
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cliente.Location = new System.Drawing.Point(9, 9);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(65, 20);
            this.lb_cliente.TabIndex = 0;
            this.lb_cliente.Text = "Cliente";
            this.lb_cliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.idDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.totalVendaDataGridViewTextBoxColumn,
            this.TotalPago,
            this.tipoVendaDataGridViewTextBoxColumn,
            this.dataVendaDataGridViewTextBoxColumn,
            this.codigoVendaDataGridViewTextBoxColumn});
            this.dgv_vendas.DataSource = this.vendaBindingSource;
            this.dgv_vendas.Location = new System.Drawing.Point(10, 92);
            this.dgv_vendas.Name = "dgv_vendas";
            this.dgv_vendas.ReadOnly = true;
            this.dgv_vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_vendas.Size = new System.Drawing.Size(569, 205);
            this.dgv_vendas.TabIndex = 29;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(ERP.Vendas.Venda);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataVencimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "Data de vencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVencimentoDataGridViewTextBoxColumn.Width = 130;
            // 
            // totalVendaDataGridViewTextBoxColumn
            // 
            this.totalVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalVendaDataGridViewTextBoxColumn.DataPropertyName = "TotalVenda";
            this.totalVendaDataGridViewTextBoxColumn.HeaderText = "Total Venda";
            this.totalVendaDataGridViewTextBoxColumn.Name = "totalVendaDataGridViewTextBoxColumn";
            this.totalVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TotalPago
            // 
            this.TotalPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TotalPago.DataPropertyName = "TotalPago";
            this.TotalPago.HeaderText = "Total já Pago";
            this.TotalPago.Name = "TotalPago";
            this.TotalPago.ReadOnly = true;
            this.TotalPago.Width = 110;
            // 
            // tipoVendaDataGridViewTextBoxColumn
            // 
            this.tipoVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipoVendaDataGridViewTextBoxColumn.DataPropertyName = "TipoVenda";
            this.tipoVendaDataGridViewTextBoxColumn.HeaderText = "Tipo da venda";
            this.tipoVendaDataGridViewTextBoxColumn.Name = "tipoVendaDataGridViewTextBoxColumn";
            this.tipoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoVendaDataGridViewTextBoxColumn.Width = 130;
            // 
            // dataVendaDataGridViewTextBoxColumn
            // 
            this.dataVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataVendaDataGridViewTextBoxColumn.DataPropertyName = "DataVenda";
            this.dataVendaDataGridViewTextBoxColumn.HeaderText = "Data da venda";
            this.dataVendaDataGridViewTextBoxColumn.Name = "dataVendaDataGridViewTextBoxColumn";
            this.dataVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVendaDataGridViewTextBoxColumn.Width = 120;
            // 
            // codigoVendaDataGridViewTextBoxColumn
            // 
            this.codigoVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codigoVendaDataGridViewTextBoxColumn.DataPropertyName = "CodigoVenda";
            this.codigoVendaDataGridViewTextBoxColumn.HeaderText = "Código da venda";
            this.codigoVendaDataGridViewTextBoxColumn.Name = "codigoVendaDataGridViewTextBoxColumn";
            this.codigoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoVendaDataGridViewTextBoxColumn.Width = 250;
            // 
            // Frm_efetuar_pagamentos_compras_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.btn_detalhar_compra);
            this.Controls.Add(this.lb_vendas);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.lb_total_pagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_vendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_efetuar_pagamentos_compras_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Efetuar Pagamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_efetuar_pagamentos_compras_cliente_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_detalhar_compra;
        private System.Windows.Forms.Label lb_vendas;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label lb_total_pagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.DataGridView dgv_vendas;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoVendaDataGridViewTextBoxColumn;
    }
}