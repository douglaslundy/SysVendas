namespace ERP.frm
{
    partial class Frm_cadastrar_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cadastrar_cliente));
            this.btn_abrir = new System.Windows.Forms.Button();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDebitosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelCadastroCliente = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_sobre_nome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ddd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.cb_inadimplente = new System.Windows.Forms.ComboBox();
            this.txt_limite = new System.Windows.Forms.TextBox();
            this.txt_observacoes = new System.Windows.Forms.TextBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.Inadimplente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.panelCadastroCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_abrir
            // 
            this.btn_abrir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_abrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir.Location = new System.Drawing.Point(646, 296);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(126, 36);
            this.btn_abrir.TabIndex = 14;
            this.btn_abrir.Text = "[ F4 ] - Abrir";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(49, 298);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(477, 29);
            this.txt_cliente.TabIndex = 13;
            this.txt_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Digite o Nome do Cliente ou CPF";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.limiteDataGridViewTextBoxColumn,
            this.saldoDebitosDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.clienteBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(9, 346);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(783, 245);
            this.dgvClientes.TabIndex = 15;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Codigo.DataPropertyName = "Id";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // nomeCompletoDataGridViewTextBoxColumn
            // 
            this.nomeCompletoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
            this.nomeCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeCompletoDataGridViewTextBoxColumn.Width = 160;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Width = 170;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 90;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfDataGridViewTextBoxColumn.Width = 90;
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
            this.limiteDataGridViewTextBoxColumn.Width = 80;
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
            this.saldoDebitosDataGridViewTextBoxColumn.Width = 105;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(ERP.Clientes.Cliente);
            // 
            // panelCadastroCliente
            // 
            this.panelCadastroCliente.AutoScroll = true;
            this.panelCadastroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadastroCliente.Controls.Add(this.label11);
            this.panelCadastroCliente.Controls.Add(this.txt_sobre_nome);
            this.panelCadastroCliente.Controls.Add(this.label10);
            this.panelCadastroCliente.Controls.Add(this.txt_ddd);
            this.panelCadastroCliente.Controls.Add(this.label9);
            this.panelCadastroCliente.Controls.Add(this.btn_excluir);
            this.panelCadastroCliente.Controls.Add(this.cb_inadimplente);
            this.panelCadastroCliente.Controls.Add(this.txt_limite);
            this.panelCadastroCliente.Controls.Add(this.txt_observacoes);
            this.panelCadastroCliente.Controls.Add(this.btn_gravar);
            this.panelCadastroCliente.Controls.Add(this.txt_cpf);
            this.panelCadastroCliente.Controls.Add(this.txt_telefone);
            this.panelCadastroCliente.Controls.Add(this.txt_rg);
            this.panelCadastroCliente.Controls.Add(this.txt_endereco);
            this.panelCadastroCliente.Controls.Add(this.txt_nome);
            this.panelCadastroCliente.Controls.Add(this.Inadimplente);
            this.panelCadastroCliente.Controls.Add(this.label8);
            this.panelCadastroCliente.Controls.Add(this.label7);
            this.panelCadastroCliente.Controls.Add(this.label6);
            this.panelCadastroCliente.Controls.Add(this.label5);
            this.panelCadastroCliente.Controls.Add(this.label3);
            this.panelCadastroCliente.Controls.Add(this.label2);
            this.panelCadastroCliente.Controls.Add(this.label1);
            this.panelCadastroCliente.Controls.Add(this.Titulo);
            this.panelCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCadastroCliente.Location = new System.Drawing.Point(9, 10);
            this.panelCadastroCliente.Name = "panelCadastroCliente";
            this.panelCadastroCliente.Size = new System.Drawing.Size(783, 257);
            this.panelCadastroCliente.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(153, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Sobre Nome";
            // 
            // txt_sobre_nome
            // 
            this.txt_sobre_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_sobre_nome.Location = new System.Drawing.Point(177, 58);
            this.txt_sobre_nome.Name = "txt_sobre_nome";
            this.txt_sobre_nome.Size = new System.Drawing.Size(166, 29);
            this.txt_sobre_nome.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(356, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "DDD";
            // 
            // txt_ddd
            // 
            this.txt_ddd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ddd.Location = new System.Drawing.Point(360, 117);
            this.txt_ddd.Name = "txt_ddd";
            this.txt_ddd.Size = new System.Drawing.Size(44, 29);
            this.txt_ddd.TabIndex = 6;
            this.txt_ddd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ddd_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(655, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "[ Esc ] - Sair";
            // 
            // btn_excluir
            // 
            this.btn_excluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(481, 212);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(122, 36);
            this.btn_excluir.TabIndex = 11;
            this.btn_excluir.Text = "[ F10 ] - Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Visible = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // cb_inadimplente
            // 
            this.cb_inadimplente.FormattingEnabled = true;
            this.cb_inadimplente.Items.AddRange(new object[] {
            "Sim",
            "Nao"});
            this.cb_inadimplente.Location = new System.Drawing.Point(360, 173);
            this.cb_inadimplente.Name = "cb_inadimplente";
            this.cb_inadimplente.Size = new System.Drawing.Size(163, 32);
            this.cb_inadimplente.TabIndex = 10;
            // 
            // txt_limite
            // 
            this.txt_limite.Location = new System.Drawing.Point(568, 117);
            this.txt_limite.Name = "txt_limite";
            this.txt_limite.Size = new System.Drawing.Size(156, 29);
            this.txt_limite.TabIndex = 8;
            this.txt_limite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_limite_KeyPress);
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_observacoes.Location = new System.Drawing.Point(15, 173);
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.Size = new System.Drawing.Size(328, 70);
            this.txt_observacoes.TabIndex = 9;
            // 
            // btn_gravar
            // 
            this.btn_gravar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.Location = new System.Drawing.Point(636, 212);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(126, 36);
            this.btn_gravar.TabIndex = 12;
            this.btn_gravar.Text = "[ F12 ] - Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // txt_cpf
            // 
            this.txt_cpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cpf.Location = new System.Drawing.Point(568, 58);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(194, 29);
            this.txt_cpf.TabIndex = 4;
            this.txt_cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cpf_KeyPress);
            // 
            // txt_telefone
            // 
            this.txt_telefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_telefone.Location = new System.Drawing.Point(417, 117);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(137, 29);
            this.txt_telefone.TabIndex = 7;
            this.txt_telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefone_KeyPress);
            // 
            // txt_rg
            // 
            this.txt_rg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_rg.Location = new System.Drawing.Point(360, 58);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(194, 29);
            this.txt_rg.TabIndex = 3;
            // 
            // txt_endereco
            // 
            this.txt_endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_endereco.Location = new System.Drawing.Point(15, 117);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(328, 29);
            this.txt_endereco.TabIndex = 5;
            // 
            // txt_nome
            // 
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.Location = new System.Drawing.Point(15, 58);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(156, 29);
            this.txt_nome.TabIndex = 1;
            // 
            // Inadimplente
            // 
            this.Inadimplente.AutoSize = true;
            this.Inadimplente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inadimplente.Location = new System.Drawing.Point(356, 151);
            this.Inadimplente.Name = "Inadimplente";
            this.Inadimplente.Size = new System.Drawing.Size(101, 20);
            this.Inadimplente.TabIndex = 9;
            this.Inadimplente.Text = "Inadimplente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Observações";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Limite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "RG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(1, -1);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(213, 25);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "Cadastro de Clientes";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // nomeCompletoDataGridViewTextBoxColumn1
            // 
            this.nomeCompletoDataGridViewTextBoxColumn1.DataPropertyName = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn1.HeaderText = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn1.Name = "nomeCompletoDataGridViewTextBoxColumn1";
            this.nomeCompletoDataGridViewTextBoxColumn1.Width = 104;
            // 
            // identidadeDataGridViewTextBoxColumn
            // 
            this.identidadeDataGridViewTextBoxColumn.DataPropertyName = "Identidade";
            this.identidadeDataGridViewTextBoxColumn.HeaderText = "Identidade";
            this.identidadeDataGridViewTextBoxColumn.Name = "identidadeDataGridViewTextBoxColumn";
            this.identidadeDataGridViewTextBoxColumn.Width = 82;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Width = 43;
            // 
            // usuarioIdDataGridViewTextBoxColumn
            // 
            this.usuarioIdDataGridViewTextBoxColumn.DataPropertyName = "UsuarioId";
            this.usuarioIdDataGridViewTextBoxColumn.HeaderText = "UsuarioId";
            this.usuarioIdDataGridViewTextBoxColumn.Name = "usuarioIdDataGridViewTextBoxColumn";
            this.usuarioIdDataGridViewTextBoxColumn.Width = 77;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.Width = 68;
            // 
            // vendasDataGridViewTextBoxColumn
            // 
            this.vendasDataGridViewTextBoxColumn.DataPropertyName = "Vendas";
            this.vendasDataGridViewTextBoxColumn.HeaderText = "Vendas";
            this.vendasDataGridViewTextBoxColumn.Name = "vendasDataGridViewTextBoxColumn";
            this.vendasDataGridViewTextBoxColumn.Width = 68;
            // 
            // Frm_cadastrar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.panelCadastroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_cadastrar_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.Frm_cadastrar_cliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_cadastrar_cliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.panelCadastroCliente.ResumeLayout(false);
            this.panelCadastroCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panelCadastroCliente;
        protected internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.ComboBox cb_inadimplente;
        private System.Windows.Forms.TextBox txt_limite;
        private System.Windows.Forms.TextBox txt_observacoes;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label Inadimplente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox txt_ddd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_sobre_nome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn identidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDebitosDataGridViewTextBoxColumn;
    }
}