namespace ERP.frm
{
    partial class Frm_inform_prazo_da_venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_inform_prazo_da_venda));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_dias_prazo_venda = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(157, 102);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(98, 45);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Esc - Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_dias_prazo_venda
            // 
            this.txt_dias_prazo_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dias_prazo_venda.Location = new System.Drawing.Point(35, 54);
            this.txt_dias_prazo_venda.Name = "txt_dias_prazo_venda";
            this.txt_dias_prazo_venda.Size = new System.Drawing.Size(220, 31);
            this.txt_dias_prazo_venda.TabIndex = 5;
            this.txt_dias_prazo_venda.Text = "30";
            this.txt_dias_prazo_venda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dias_prazo_venda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dias_prazo_venda_KeyPress);
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(35, 102);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 45);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "F12 - OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dias de Prazo:";
            // 
            // Frm_inform_prazo_da_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_dias_prazo_venda);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_inform_prazo_da_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informar Prazo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_inform_prazo_da_venda_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_dias_prazo_venda;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
    }
}