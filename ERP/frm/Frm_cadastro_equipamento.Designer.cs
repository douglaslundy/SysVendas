namespace ERP.frm
{
    partial class Frm_cadastro_equipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cadastro_equipamento));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_equipamentos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoInstalacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.equipamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_gravar = new System.Windows.Forms.Button();
            this.txt_Caid = new System.Windows.Forms.TextBox();
            this.txt_Cartao = new System.Windows.Forms.TextBox();
            this.lbCaid = new System.Windows.Forms.Label();
            this.lbCartao = new System.Windows.Forms.Label();
            this.lb_NomeCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_CPF = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "[ Esc ] - Sair";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cliente:";
            // 
            // dgv_equipamentos
            // 
            this.dgv_equipamentos.AllowUserToAddRows = false;
            this.dgv_equipamentos.AllowUserToDeleteRows = false;
            this.dgv_equipamentos.AutoGenerateColumns = false;
            this.dgv_equipamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_equipamentos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_equipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_equipamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.NomeUsuario,
            this.caidDataGridViewTextBoxColumn,
            this.cartaoDataGridViewTextBoxColumn,
            this.EnderecoInstalacao,
            this.ativoDataGridViewCheckBoxColumn});
            this.dgv_equipamentos.DataSource = this.equipamentoBindingSource;
            this.dgv_equipamentos.Location = new System.Drawing.Point(12, 189);
            this.dgv_equipamentos.Name = "dgv_equipamentos";
            this.dgv_equipamentos.ReadOnly = true;
            this.dgv_equipamentos.Size = new System.Drawing.Size(760, 169);
            this.dgv_equipamentos.TabIndex = 35;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NomeUsuario.DataPropertyName = "NomeUsuario";
            this.NomeUsuario.HeaderText = "Nome do usuario";
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.ReadOnly = true;
            this.NomeUsuario.Width = 150;
            // 
            // caidDataGridViewTextBoxColumn
            // 
            this.caidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.caidDataGridViewTextBoxColumn.DataPropertyName = "Caid";
            this.caidDataGridViewTextBoxColumn.HeaderText = "Caid";
            this.caidDataGridViewTextBoxColumn.Name = "caidDataGridViewTextBoxColumn";
            this.caidDataGridViewTextBoxColumn.ReadOnly = true;
            this.caidDataGridViewTextBoxColumn.Width = 150;
            // 
            // cartaoDataGridViewTextBoxColumn
            // 
            this.cartaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cartaoDataGridViewTextBoxColumn.DataPropertyName = "Cartao";
            this.cartaoDataGridViewTextBoxColumn.HeaderText = "Cartão";
            this.cartaoDataGridViewTextBoxColumn.Name = "cartaoDataGridViewTextBoxColumn";
            this.cartaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cartaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // EnderecoInstalacao
            // 
            this.EnderecoInstalacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EnderecoInstalacao.DataPropertyName = "EnderecoInstalacao";
            this.EnderecoInstalacao.HeaderText = "Endereco da instalacao";
            this.EnderecoInstalacao.Name = "EnderecoInstalacao";
            this.EnderecoInstalacao.ReadOnly = true;
            this.EnderecoInstalacao.Width = 150;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn.Width = 60;
            // 
            // equipamentoBindingSource
            // 
            this.equipamentoBindingSource.DataSource = typeof(ERP.Equipamentos.Equipamento);
            // 
            // btn_gravar
            // 
            this.btn_gravar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.Location = new System.Drawing.Point(638, 374);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(134, 36);
            this.btn_gravar.TabIndex = 36;
            this.btn_gravar.Text = "[ F12 ] - Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // txt_Caid
            // 
            this.txt_Caid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Caid.Location = new System.Drawing.Point(16, 137);
            this.txt_Caid.Name = "txt_Caid";
            this.txt_Caid.Size = new System.Drawing.Size(205, 26);
            this.txt_Caid.TabIndex = 2;
            // 
            // txt_Cartao
            // 
            this.txt_Cartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cartao.Location = new System.Drawing.Point(227, 137);
            this.txt_Cartao.Name = "txt_Cartao";
            this.txt_Cartao.Size = new System.Drawing.Size(205, 26);
            this.txt_Cartao.TabIndex = 3;
            // 
            // lbCaid
            // 
            this.lbCaid.AutoSize = true;
            this.lbCaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaid.Location = new System.Drawing.Point(12, 114);
            this.lbCaid.Name = "lbCaid";
            this.lbCaid.Size = new System.Drawing.Size(52, 20);
            this.lbCaid.TabIndex = 39;
            this.lbCaid.Text = "CAID";
            // 
            // lbCartao
            // 
            this.lbCartao.AutoSize = true;
            this.lbCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartao.Location = new System.Drawing.Point(223, 114);
            this.lbCartao.Name = "lbCartao";
            this.lbCartao.Size = new System.Drawing.Size(81, 20);
            this.lbCartao.TabIndex = 40;
            this.lbCartao.Text = "CARTÂO";
            // 
            // lb_NomeCliente
            // 
            this.lb_NomeCliente.AutoSize = true;
            this.lb_NomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeCliente.Location = new System.Drawing.Point(88, 14);
            this.lb_NomeCliente.Name = "lb_NomeCliente";
            this.lb_NomeCliente.Size = new System.Drawing.Size(297, 20);
            this.lb_NomeCliente.TabIndex = 41;
            this.lb_NomeCliente.Text = "Aqui vai o nome completo do cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "CPF:";
            // 
            // lb_CPF
            // 
            this.lb_CPF.AutoSize = true;
            this.lb_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CPF.Location = new System.Drawing.Point(495, 14);
            this.lb_CPF.Name = "lb_CPF";
            this.lb_CPF.Size = new System.Drawing.Size(119, 20);
            this.lb_CPF.TabIndex = 43;
            this.lb_CPF.Text = "00000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "ENDEREÇO";
            // 
            // txt_endereco
            // 
            this.txt_endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endereco.Location = new System.Drawing.Point(438, 137);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(334, 26);
            this.txt_endereco.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "NOME DO USUÁRIO";
            // 
            // txt_usuario
            // 
            this.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(16, 80);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(334, 26);
            this.txt_usuario.TabIndex = 1;
            // 
            // btn_abrir
            // 
            this.btn_abrir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_abrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir.Location = new System.Drawing.Point(638, 70);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(126, 36);
            this.btn_abrir.TabIndex = 48;
            this.btn_abrir.Text = "[ F4 ] - Abrir";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(492, 374);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(122, 36);
            this.btn_excluir.TabIndex = 49;
            this.btn_excluir.Text = "[ F10 ] - Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Visible = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // Frm_cadastro_equipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 422);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.lb_CPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_NomeCliente);
            this.Controls.Add(this.lbCartao);
            this.Controls.Add(this.lbCaid);
            this.Controls.Add(this.txt_Cartao);
            this.Controls.Add(this.txt_Caid);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.dgv_equipamentos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_cadastro_equipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Equipamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_cadastro_equipamento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_equipamentos;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.TextBox txt_Caid;
        private System.Windows.Forms.TextBox txt_Cartao;
        private System.Windows.Forms.Label lbCaid;
        private System.Windows.Forms.Label lbCartao;
        private System.Windows.Forms.Label lb_NomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_CPF;
        private System.Windows.Forms.BindingSource equipamentoBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn caidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoInstalacao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.Button btn_excluir;
    }
}