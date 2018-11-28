using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.frm
{
    public partial class Frm_barra_rolagem : Form
    {
        public Frm_barra_rolagem()
        {
            InitializeComponent();
        }

        private void Progress()
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                this.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Progress();

                if (timer1.Enabled == false)
                {
                    MessageBox.Show("O Backup foi realizado com sucesso!", "Backup foi realizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("O Backup não pode ser realizado?", "Erro ao realizar backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
