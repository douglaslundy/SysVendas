namespace ERP.frm
{
    partial class Frm_produto_não_cadastrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_produto_não_cadastrado));
            this.txt_resposta = new System.Windows.Forms.TextBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.btn_finalizar_venda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_resposta_errada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_resposta
            // 
            this.txt_resposta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resposta.Location = new System.Drawing.Point(36, 252);
            this.txt_resposta.Name = "txt_resposta";
            this.txt_resposta.Size = new System.Drawing.Size(224, 40);
            this.txt_resposta.TabIndex = 1;
            this.txt_resposta.TabStop = false;
            this.txt_resposta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_resposta_KeyDown);
            this.txt_resposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_resposta_KeyPress);
            // 
            // lb_1
            // 
            this.lb_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(32, 208);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(41, 29);
            this.lb_1.TabIndex = 23;
            this.lb_1.Text = "10";
            // 
            // btn_finalizar_venda
            // 
            this.btn_finalizar_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_finalizar_venda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_finalizar_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar_venda.Location = new System.Drawing.Point(318, 256);
            this.btn_finalizar_venda.Name = "btn_finalizar_venda";
            this.btn_finalizar_venda.Size = new System.Drawing.Size(125, 40);
            this.btn_finalizar_venda.TabIndex = 24;
            this.btn_finalizar_venda.Text = "[ F12 ] - OK";
            this.btn_finalizar_venda.UseVisualStyleBackColor = true;
            this.btn_finalizar_venda.Click += new System.EventHandler(this.btn_finalizar_venda_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 73);
            this.label1.TabIndex = 25;
            this.label1.Text = "Produto Não Cadastrado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(719, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Para Voltar ao Carrinho de Compras acerte a charada abaixo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_2
            // 
            this.lb_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_2.AutoSize = true;
            this.lb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.Location = new System.Drawing.Point(92, 208);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(41, 29);
            this.lb_2.TabIndex = 28;
            this.lb_2.Text = "10";
            // 
            // lb_resposta_errada
            // 
            this.lb_resposta_errada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_resposta_errada.AutoSize = true;
            this.lb_resposta_errada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resposta_errada.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_resposta_errada.Location = new System.Drawing.Point(31, 144);
            this.lb_resposta_errada.Name = "lb_resposta_errada";
            this.lb_resposta_errada.Size = new System.Drawing.Size(412, 29);
            this.lb_resposta_errada.TabIndex = 29;
            this.lb_resposta_errada.Text = "Resposta errada tente novamente!";
            this.lb_resposta_errada.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_produto_não_cadastrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_resposta_errada);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_finalizar_venda);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.txt_resposta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_produto_não_cadastrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_produto_não_cadastrado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_resposta;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Button btn_finalizar_venda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_resposta_errada;
        private System.Windows.Forms.Label label4;
    }
}