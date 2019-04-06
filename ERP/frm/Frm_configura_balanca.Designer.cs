namespace ERP.frm
{
    partial class Frm_configura_balanca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_configura_balanca));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_digito_inicial = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_inicio_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fim_codigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fim_peso_ou_valor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_inicio_peso_ou_valor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tamanho_total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkHabilitar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(40, 464);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(153, 55);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "[ Esc ] - Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_digito_inicial
            // 
            this.txt_digito_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_digito_inicial.Location = new System.Drawing.Point(590, 172);
            this.txt_digito_inicial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_digito_inicial.Name = "txt_digito_inicial";
            this.txt_digito_inicial.Size = new System.Drawing.Size(108, 30);
            this.txt_digito_inicial.TabIndex = 18;
            this.txt_digito_inicial.Text = "2";
            this.txt_digito_inicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(757, 464);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(153, 55);
            this.btn_ok.TabIndex = 19;
            this.btn_ok.Text = "[ F12 ] - OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Digito Inicial que identifica Código gerado pela balança:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tamanho total do codigo de barras:";
            // 
            // txt_inicio_codigo
            // 
            this.txt_inicio_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inicio_codigo.Location = new System.Drawing.Point(140, 295);
            this.txt_inicio_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_inicio_codigo.Name = "txt_inicio_codigo";
            this.txt_inicio_codigo.Size = new System.Drawing.Size(108, 30);
            this.txt_inicio_codigo.TabIndex = 24;
            this.txt_inicio_codigo.Text = "0";
            this.txt_inicio_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Código produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Inicia em:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(267, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Termina em:";
            // 
            // txt_fim_codigo
            // 
            this.txt_fim_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fim_codigo.Location = new System.Drawing.Point(408, 293);
            this.txt_fim_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fim_codigo.Name = "txt_fim_codigo";
            this.txt_fim_codigo.Size = new System.Drawing.Size(108, 30);
            this.txt_fim_codigo.TabIndex = 28;
            this.txt_fim_codigo.Text = "5";
            this.txt_fim_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 410);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Termina em:";
            // 
            // txt_fim_peso_ou_valor
            // 
            this.txt_fim_peso_ou_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fim_peso_ou_valor.Location = new System.Drawing.Point(408, 402);
            this.txt_fim_peso_ou_valor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fim_peso_ou_valor.Name = "txt_fim_peso_ou_valor";
            this.txt_fim_peso_ou_valor.Size = new System.Drawing.Size(108, 30);
            this.txt_fim_peso_ou_valor.TabIndex = 33;
            this.txt_fim_peso_ou_valor.Text = "12";
            this.txt_fim_peso_ou_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 410);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Inicia em:";
            // 
            // txt_inicio_peso_ou_valor
            // 
            this.txt_inicio_peso_ou_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inicio_peso_ou_valor.Location = new System.Drawing.Point(140, 402);
            this.txt_inicio_peso_ou_valor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_inicio_peso_ou_valor.Name = "txt_inicio_peso_ou_valor";
            this.txt_inicio_peso_ou_valor.Size = new System.Drawing.Size(108, 30);
            this.txt_inicio_peso_ou_valor.TabIndex = 31;
            this.txt_inicio_peso_ou_valor.Text = "6";
            this.txt_inicio_peso_ou_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 369);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 31);
            this.label9.TabIndex = 30;
            this.label9.Text = "Peso ou Valor";
            // 
            // txt_tamanho_total
            // 
            this.txt_tamanho_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tamanho_total.Location = new System.Drawing.Point(390, 201);
            this.txt_tamanho_total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tamanho_total.Name = "txt_tamanho_total";
            this.txt_tamanho_total.Size = new System.Drawing.Size(108, 30);
            this.txt_tamanho_total.TabIndex = 35;
            this.txt_tamanho_total.Text = "13";
            this.txt_tamanho_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(540, 38);
            this.label4.TabIndex = 36;
            this.label4.Text = "Configuração do leitor de Balança";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Habilitar balança";
            // 
            // chkHabilitar
            // 
            this.chkHabilitar.AutoSize = true;
            this.chkHabilitar.Location = new System.Drawing.Point(215, 101);
            this.chkHabilitar.Name = "chkHabilitar";
            this.chkHabilitar.Size = new System.Drawing.Size(82, 21);
            this.chkHabilitar.TabIndex = 38;
            this.chkHabilitar.Text = "Habilitar";
            this.chkHabilitar.UseVisualStyleBackColor = true;
            // 
            // Frm_configura_balanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 532);
            this.Controls.Add(this.chkHabilitar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tamanho_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_fim_peso_ou_valor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_inicio_peso_ou_valor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_fim_codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_inicio_codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_digito_inicial);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_configura_balanca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Balanca";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_configura_balanca_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_digito_inicial;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_inicio_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fim_codigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fim_peso_ou_valor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_inicio_peso_ou_valor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tamanho_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkHabilitar;
    }
}