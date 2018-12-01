namespace ERP.frm
{
    partial class Frm_lista_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_lista_clientes));
            this.lb_total_debitosAReceber = new System.Windows.Forms.Label();
            this.btn_pagar_debitos = new System.Windows.Forms.Button();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.btn_compras_pendentes = new System.Windows.Forms.Button();
            this.btn_equipamentos = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDebitosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_total_debitosAReceber
            // 
            this.lb_total_debitosAReceber.AutoSize = true;
            this.lb_total_debitosAReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_debitosAReceber.Location = new System.Drawing.Point(12, 392);
            this.lb_total_debitosAReceber.Name = "lb_total_debitosAReceber";
            this.lb_total_debitosAReceber.Size = new System.Drawing.Size(168, 20);
            this.lb_total_debitosAReceber.TabIndex = 36;
            this.lb_total_debitosAReceber.Text = "Total a receber: R$ ";
            // 
            // btn_pagar_debitos
            // 
            this.btn_pagar_debitos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_pagar_debitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar_debitos.Location = new System.Drawing.Point(574, 376);
            this.btn_pagar_debitos.Name = "btn_pagar_debitos";
            this.btn_pagar_debitos.Size = new System.Drawing.Size(198, 36);
            this.btn_pagar_debitos.TabIndex = 35;
            this.btn_pagar_debitos.Text = "[ F12 ] - Compras a Pagar";
            this.btn_pagar_debitos.UseVisualStyleBackColor = true;
            this.btn_pagar_debitos.Click += new System.EventHandler(this.btn_pagar_debitos_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(16, 38);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(375, 26);
            this.txt_cliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "[ Esc ] - Sair";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Digite o Nome ou CPF";
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.AutoGenerateColumns = false;
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_clientes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.limiteDataGridViewTextBoxColumn,
            this.saldoDebitosDataGridViewTextBoxColumn});
            this.dgv_clientes.DataSource = this.clienteBindingSource;
            this.dgv_clientes.Location = new System.Drawing.Point(12, 83);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.Size = new System.Drawing.Size(760, 270);
            this.dgv_clientes.TabIndex = 30;
            // 
            // btn_compras_pendentes
            // 
            this.btn_compras_pendentes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_compras_pendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compras_pendentes.Location = new System.Drawing.Point(384, 376);
            this.btn_compras_pendentes.Name = "btn_compras_pendentes";
            this.btn_compras_pendentes.Size = new System.Drawing.Size(184, 36);
            this.btn_compras_pendentes.TabIndex = 37;
            this.btn_compras_pendentes.Text = "[ F4 ] - Compras Pagas";
            this.btn_compras_pendentes.UseVisualStyleBackColor = true;
            this.btn_compras_pendentes.Click += new System.EventHandler(this.btn_compras_pendentes_Click);
            // 
            // btn_equipamentos
            // 
            this.btn_equipamentos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_equipamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equipamentos.Location = new System.Drawing.Point(447, 33);
            this.btn_equipamentos.Name = "btn_equipamentos";
            this.btn_equipamentos.Size = new System.Drawing.Size(212, 36);
            this.btn_equipamentos.TabIndex = 38;
            this.btn_equipamentos.Text = "[ F3 ] - Equipamentos";
            this.btn_equipamentos.UseVisualStyleBackColor = true;
            this.btn_equipamentos.Click += new System.EventHandler(this.btn_equipamentos_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // nomeCompletoDataGridViewTextBoxColumn
            // 
            this.nomeCompletoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "Nome Completo";
            this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
            this.nomeCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeCompletoDataGridViewTextBoxColumn.Width = 300;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 110;
            // 
            // limiteDataGridViewTextBoxColumn
            // 
            this.limiteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.limiteDataGridViewTextBoxColumn.DataPropertyName = "Limite";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.limiteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.limiteDataGridViewTextBoxColumn.HeaderText = "Limite";
            this.limiteDataGridViewTextBoxColumn.Name = "limiteDataGridViewTextBoxColumn";
            this.limiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.limiteDataGridViewTextBoxColumn.Width = 110;
            // 
            // saldoDebitosDataGridViewTextBoxColumn
            // 
            this.saldoDebitosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.saldoDebitosDataGridViewTextBoxColumn.DataPropertyName = "SaldoDebitos";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.saldoDebitosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.saldoDebitosDataGridViewTextBoxColumn.HeaderText = "Saldo Devedor";
            this.saldoDebitosDataGridViewTextBoxColumn.Name = "saldoDebitosDataGridViewTextBoxColumn";
            this.saldoDebitosDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoDebitosDataGridViewTextBoxColumn.Width = 150;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(ERP.Clientes.Cliente);
            // 
            // Frm_lista_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 422);
            this.Controls.Add(this.btn_equipamentos);
            this.Controls.Add(this.btn_compras_pendentes);
            this.Controls.Add(this.lb_total_debitosAReceber);
            this.Controls.Add(this.btn_pagar_debitos);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_lista_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem -> Clientes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_lista_clientes_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_lista_clientes_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_total_debitosAReceber;
        private System.Windows.Forms.Button btn_pagar_debitos;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDebitosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_compras_pendentes;
        private System.Windows.Forms.Button btn_equipamentos;
    }
}