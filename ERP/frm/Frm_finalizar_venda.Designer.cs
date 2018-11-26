namespace ERP.frm
{
    partial class Frm_finalizar_venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_finalizar_venda));
            this.btn_esc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.btn_selecionar_cliente = new System.Windows.Forms.Button();
            this.btn_finalizar_venda = new System.Windows.Forms.Button();
            this.txt_dinheiro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cartao_credito = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cartao_debito = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cheque = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_total_pago = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_cadastrar_cliente = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_total_apagar = new System.Windows.Forms.Label();
            this.lb_titulo_troco = new System.Windows.Forms.Label();
            this.lb_valor_troco = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.lb_data_vencimento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_esc
            // 
            this.btn_esc.Location = new System.Drawing.Point(5, 473);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(61, 32);
            this.btn_esc.TabIndex = 39;
            this.btn_esc.Text = "[ Esc ]";
            this.btn_esc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "TOTAL A PAGAR: R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cliente:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(76, 98);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(360, 22);
            this.txt_cliente.TabIndex = 45;
            this.txt_cliente.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 243, 5);
            this.label3.Size = new System.Drawing.Size(425, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Dados do cliente para venda a prazo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(10, 186);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 247, 5);
            this.label4.Size = new System.Drawing.Size(424, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "INFORMAÇÕES DE PAGAMENTO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Endereço:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Enabled = false;
            this.txt_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endereco.Location = new System.Drawing.Point(76, 129);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(360, 22);
            this.txt_endereco.TabIndex = 47;
            this.txt_endereco.TabStop = false;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Enabled = false;
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(76, 159);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(174, 22);
            this.txt_telefone.TabIndex = 46;
            this.txt_telefone.TabStop = false;
            // 
            // btn_selecionar_cliente
            // 
            this.btn_selecionar_cliente.Location = new System.Drawing.Point(243, 473);
            this.btn_selecionar_cliente.Name = "btn_selecionar_cliente";
            this.btn_selecionar_cliente.Size = new System.Drawing.Size(61, 32);
            this.btn_selecionar_cliente.TabIndex = 42;
            this.btn_selecionar_cliente.Text = "[ F10 ]";
            this.btn_selecionar_cliente.UseVisualStyleBackColor = true;
            this.btn_selecionar_cliente.Click += new System.EventHandler(this.btn_selecionar_cliente_Click);
            // 
            // btn_finalizar_venda
            // 
            this.btn_finalizar_venda.Location = new System.Drawing.Point(372, 473);
            this.btn_finalizar_venda.Name = "btn_finalizar_venda";
            this.btn_finalizar_venda.Size = new System.Drawing.Size(61, 32);
            this.btn_finalizar_venda.TabIndex = 44;
            this.btn_finalizar_venda.Text = "[ F12 ]";
            this.btn_finalizar_venda.UseVisualStyleBackColor = true;
            this.btn_finalizar_venda.Click += new System.EventHandler(this.btn_finalizar_venda_Click);
            // 
            // txt_dinheiro
            // 
            this.txt_dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dinheiro.Location = new System.Drawing.Point(332, 219);
            this.txt_dinheiro.Name = "txt_dinheiro";
            this.txt_dinheiro.Size = new System.Drawing.Size(104, 31);
            this.txt_dinheiro.TabIndex = 31;
            this.txt_dinheiro.Text = "0,00";
            this.txt_dinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dinheiro_KeyPress);
            this.txt_dinheiro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dinheiro_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Dinheiro:";
            // 
            // txt_cartao_credito
            // 
            this.txt_cartao_credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cartao_credito.Location = new System.Drawing.Point(332, 267);
            this.txt_cartao_credito.Name = "txt_cartao_credito";
            this.txt_cartao_credito.Size = new System.Drawing.Size(104, 31);
            this.txt_cartao_credito.TabIndex = 33;
            this.txt_cartao_credito.Text = "0,00";
            this.txt_cartao_credito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cartao_credito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cartao_credito_KeyPress);
            this.txt_cartao_credito.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_cartao_credito_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(246, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Cartão Créd:";
            // 
            // txt_cartao_debito
            // 
            this.txt_cartao_debito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cartao_debito.Location = new System.Drawing.Point(332, 314);
            this.txt_cartao_debito.Name = "txt_cartao_debito";
            this.txt_cartao_debito.Size = new System.Drawing.Size(104, 31);
            this.txt_cartao_debito.TabIndex = 35;
            this.txt_cartao_debito.Text = "0,00";
            this.txt_cartao_debito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cartao_debito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cartao_debito_KeyPress);
            this.txt_cartao_debito.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_cartao_debito_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(246, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Cartão Déb:";
            // 
            // txt_cheque
            // 
            this.txt_cheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cheque.Location = new System.Drawing.Point(332, 360);
            this.txt_cheque.Name = "txt_cheque";
            this.txt_cheque.Size = new System.Drawing.Size(104, 31);
            this.txt_cheque.TabIndex = 37;
            this.txt_cheque.Text = "0,00";
            this.txt_cheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cheque_KeyPress);
            this.txt_cheque.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_cheque_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(246, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Cheque:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 510);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Cancelar:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(219, 510);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Selecionar Cliente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(355, 510);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Finalizar Venda:";
            // 
            // txt_total_pago
            // 
            this.txt_total_pago.Enabled = false;
            this.txt_total_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_pago.Location = new System.Drawing.Point(331, 407);
            this.txt_total_pago.Name = "txt_total_pago";
            this.txt_total_pago.Size = new System.Drawing.Size(104, 31);
            this.txt_total_pago.TabIndex = 55;
            this.txt_total_pago.TabStop = false;
            this.txt_total_pago.Text = "0,00";
            this.txt_total_pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(245, 416);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "TOTAL:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label15.Location = new System.Drawing.Point(10, 445);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(145, 2, 145, 2);
            this.label15.Size = new System.Drawing.Size(423, 17);
            this.label15.TabIndex = 57;
            this.label15.Text = "Atalhos - Menu de Opções";
            // 
            // btn_cadastrar_cliente
            // 
            this.btn_cadastrar_cliente.Location = new System.Drawing.Point(122, 473);
            this.btn_cadastrar_cliente.Name = "btn_cadastrar_cliente";
            this.btn_cadastrar_cliente.Size = new System.Drawing.Size(61, 32);
            this.btn_cadastrar_cliente.TabIndex = 40;
            this.btn_cadastrar_cliente.Text = "[ F7 ]";
            this.btn_cadastrar_cliente.UseVisualStyleBackColor = true;
            this.btn_cadastrar_cliente.Click += new System.EventHandler(this.btn_cadastrar_cliente_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(104, 510);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "Cadastrar Cliente:";
            // 
            // lb_total_apagar
            // 
            this.lb_total_apagar.AutoSize = true;
            this.lb_total_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_apagar.ForeColor = System.Drawing.Color.Red;
            this.lb_total_apagar.Location = new System.Drawing.Point(282, 0);
            this.lb_total_apagar.Name = "lb_total_apagar";
            this.lb_total_apagar.Size = new System.Drawing.Size(84, 37);
            this.lb_total_apagar.TabIndex = 59;
            this.lb_total_apagar.Text = "0,00";
            // 
            // lb_titulo_troco
            // 
            this.lb_titulo_troco.AutoSize = true;
            this.lb_titulo_troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo_troco.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lb_titulo_troco.Location = new System.Drawing.Point(20, 261);
            this.lb_titulo_troco.Name = "lb_titulo_troco";
            this.lb_titulo_troco.Size = new System.Drawing.Size(89, 31);
            this.lb_titulo_troco.TabIndex = 60;
            this.lb_titulo_troco.Text = "Troco";
            // 
            // lb_valor_troco
            // 
            this.lb_valor_troco.AutoSize = true;
            this.lb_valor_troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor_troco.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lb_valor_troco.Location = new System.Drawing.Point(20, 314);
            this.lb_valor_troco.Name = "lb_valor_troco";
            this.lb_valor_troco.Size = new System.Drawing.Size(71, 31);
            this.lb_valor_troco.TabIndex = 61;
            this.lb_valor_troco.Text = "0,00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "Código:";
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Enabled = false;
            this.txt_id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_cliente.Location = new System.Drawing.Point(76, 66);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(93, 22);
            this.txt_id_cliente.TabIndex = 63;
            this.txt_id_cliente.TabStop = false;
            // 
            // lb_data_vencimento
            // 
            this.lb_data_vencimento.AutoSize = true;
            this.lb_data_vencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_vencimento.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lb_data_vencimento.Location = new System.Drawing.Point(20, 345);
            this.lb_data_vencimento.Name = "lb_data_vencimento";
            this.lb_data_vencimento.Size = new System.Drawing.Size(273, 31);
            this.lb_data_vencimento.TabIndex = 64;
            this.lb_data_vencimento.Text = "Data de vencimento";
            this.lb_data_vencimento.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_data_vencimento);
            this.panel1.Controls.Add(this.txt_id_cliente);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lb_valor_troco);
            this.panel1.Controls.Add(this.lb_titulo_troco);
            this.panel1.Controls.Add(this.lb_total_apagar);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btn_cadastrar_cliente);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_total_pago);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_cheque);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_cartao_debito);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_cartao_credito);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_dinheiro);
            this.panel1.Controls.Add(this.btn_finalizar_venda);
            this.panel1.Controls.Add(this.btn_selecionar_cliente);
            this.panel1.Controls.Add(this.txt_telefone);
            this.panel1.Controls.Add(this.txt_endereco);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_cliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_esc);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 538);
            this.panel1.TabIndex = 23;
            // 
            // Frm_finalizar_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 562);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_finalizar_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar Venda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_finalizar_venda_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_esc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Button btn_selecionar_cliente;
        private System.Windows.Forms.Button btn_finalizar_venda;
        private System.Windows.Forms.TextBox txt_dinheiro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cartao_credito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cartao_debito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cheque;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_total_pago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_cadastrar_cliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_total_apagar;
        private System.Windows.Forms.Label lb_titulo_troco;
        private System.Windows.Forms.Label lb_valor_troco;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.Label lb_data_vencimento;
        private System.Windows.Forms.Panel panel1;
    }
}