namespace ERP.frm
{
    partial class Frm_listar_vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_listar_vendas));
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_datafinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_data_inicial = new System.Windows.Forms.DateTimePicker();
            this.lb_listagem_vendas = new System.Windows.Forms.Label();
            this.dgv_vendas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trocoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentoRealizadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_total_das_vendas = new System.Windows.Forms.Label();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_detalha_venda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(756, 504);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(98, 39);
            this.btn_imprimir.TabIndex = 52;
            this.btn_imprimir.Text = "F12 - Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrar.Location = new System.Drawing.Point(669, 9);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 28);
            this.btn_filtrar.TabIndex = 51;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Até:";
            // 
            // dtp_datafinal
            // 
            this.dtp_datafinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_datafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datafinal.Location = new System.Drawing.Point(522, 12);
            this.dtp_datafinal.Margin = new System.Windows.Forms.Padding(6);
            this.dtp_datafinal.Name = "dtp_datafinal";
            this.dtp_datafinal.Size = new System.Drawing.Size(110, 20);
            this.dtp_datafinal.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "De:";
            // 
            // dtp_data_inicial
            // 
            this.dtp_data_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data_inicial.Location = new System.Drawing.Point(336, 12);
            this.dtp_data_inicial.Name = "dtp_data_inicial";
            this.dtp_data_inicial.Size = new System.Drawing.Size(110, 20);
            this.dtp_data_inicial.TabIndex = 47;
            // 
            // lb_listagem_vendas
            // 
            this.lb_listagem_vendas.AutoSize = true;
            this.lb_listagem_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_listagem_vendas.Location = new System.Drawing.Point(22, 13);
            this.lb_listagem_vendas.Name = "lb_listagem_vendas";
            this.lb_listagem_vendas.Size = new System.Drawing.Size(173, 20);
            this.lb_listagem_vendas.TabIndex = 46;
            this.lb_listagem_vendas.Text = "Listagem de Vendas";
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
            this.ClienteId,
            this.usuarioDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.totalVendaDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.totalPagoDataGridViewTextBoxColumn,
            this.trocoDataGridViewTextBoxColumn,
            this.dataVendaDataGridViewTextBoxColumn,
            this.tipoVendaDataGridViewTextBoxColumn,
            this.pagamentoRealizadoDataGridViewTextBoxColumn});
            this.dgv_vendas.DataSource = this.vendaBindingSource;
            this.dgv_vendas.Location = new System.Drawing.Point(12, 46);
            this.dgv_vendas.Name = "dgv_vendas";
            this.dgv_vendas.ReadOnly = true;
            this.dgv_vendas.Size = new System.Drawing.Size(845, 445);
            this.dgv_vendas.TabIndex = 43;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 55;
            // 
            // ClienteId
            // 
            this.ClienteId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClienteId.DataPropertyName = "ClienteId";
            this.ClienteId.HeaderText = "";
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            this.ClienteId.Width = 5;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Caixa";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 130;
            // 
            // totalVendaDataGridViewTextBoxColumn
            // 
            this.totalVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalVendaDataGridViewTextBoxColumn.DataPropertyName = "TotalVenda";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.totalVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalVendaDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalVendaDataGridViewTextBoxColumn.Name = "totalVendaDataGridViewTextBoxColumn";
            this.totalVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalVendaDataGridViewTextBoxColumn.Width = 65;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            dataGridViewCellStyle2.Format = "C2";
            this.descontoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            this.descontoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descontoDataGridViewTextBoxColumn.Width = 78;
            // 
            // totalPagoDataGridViewTextBoxColumn
            // 
            this.totalPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalPagoDataGridViewTextBoxColumn.DataPropertyName = "TotalPago";
            dataGridViewCellStyle3.Format = "C2";
            this.totalPagoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalPagoDataGridViewTextBoxColumn.HeaderText = "Pago";
            this.totalPagoDataGridViewTextBoxColumn.Name = "totalPagoDataGridViewTextBoxColumn";
            this.totalPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPagoDataGridViewTextBoxColumn.Width = 65;
            // 
            // trocoDataGridViewTextBoxColumn
            // 
            this.trocoDataGridViewTextBoxColumn.DataPropertyName = "Troco";
            dataGridViewCellStyle4.Format = "C2";
            this.trocoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.trocoDataGridViewTextBoxColumn.HeaderText = "Troco";
            this.trocoDataGridViewTextBoxColumn.Name = "trocoDataGridViewTextBoxColumn";
            this.trocoDataGridViewTextBoxColumn.ReadOnly = true;
            this.trocoDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataVendaDataGridViewTextBoxColumn
            // 
            this.dataVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataVendaDataGridViewTextBoxColumn.DataPropertyName = "DataVenda";
            this.dataVendaDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataVendaDataGridViewTextBoxColumn.Name = "dataVendaDataGridViewTextBoxColumn";
            this.dataVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVendaDataGridViewTextBoxColumn.Width = 80;
            // 
            // tipoVendaDataGridViewTextBoxColumn
            // 
            this.tipoVendaDataGridViewTextBoxColumn.DataPropertyName = "TipoVenda";
            this.tipoVendaDataGridViewTextBoxColumn.HeaderText = "Venda";
            this.tipoVendaDataGridViewTextBoxColumn.Name = "tipoVendaDataGridViewTextBoxColumn";
            this.tipoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoVendaDataGridViewTextBoxColumn.Width = 63;
            // 
            // pagamentoRealizadoDataGridViewTextBoxColumn
            // 
            this.pagamentoRealizadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pagamentoRealizadoDataGridViewTextBoxColumn.DataPropertyName = "PagamentoRealizado";
            this.pagamentoRealizadoDataGridViewTextBoxColumn.HeaderText = "Foi paga?";
            this.pagamentoRealizadoDataGridViewTextBoxColumn.Name = "pagamentoRealizadoDataGridViewTextBoxColumn";
            this.pagamentoRealizadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(ERP.Vendas.Venda);
            // 
            // lb_total_das_vendas
            // 
            this.lb_total_das_vendas.AutoSize = true;
            this.lb_total_das_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_das_vendas.Location = new System.Drawing.Point(12, 523);
            this.lb_total_das_vendas.Name = "lb_total_das_vendas";
            this.lb_total_das_vendas.Size = new System.Drawing.Size(183, 20);
            this.lb_total_das_vendas.TabIndex = 53;
            this.lb_total_das_vendas.Text = "Total das vendas: R$ ";
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(ERP.ItensVendas.ItensVenda);
            // 
            // btn_detalha_venda
            // 
            this.btn_detalha_venda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_detalha_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalha_venda.Location = new System.Drawing.Point(539, 504);
            this.btn_detalha_venda.Name = "btn_detalha_venda";
            this.btn_detalha_venda.Size = new System.Drawing.Size(179, 39);
            this.btn_detalha_venda.TabIndex = 54;
            this.btn_detalha_venda.Text = "F5 - Detalhar Venda";
            this.btn_detalha_venda.UseVisualStyleBackColor = true;
            this.btn_detalha_venda.Click += new System.EventHandler(this.btn_detalha_venda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(746, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Esc - Fechar";
            // 
            // Frm_listar_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_detalha_venda);
            this.Controls.Add(this.lb_total_das_vendas);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_datafinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_data_inicial);
            this.Controls.Add(this.lb_listagem_vendas);
            this.Controls.Add(this.dgv_vendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_listar_vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Vendas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_listar_vendas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_datafinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_data_inicial;
        private System.Windows.Forms.Label lb_listagem_vendas;
        private System.Windows.Forms.DataGridView dgv_vendas;
        private System.Windows.Forms.Label lb_total_das_vendas;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.Button btn_detalha_venda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trocoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamentoRealizadoDataGridViewTextBoxColumn;
    }
}