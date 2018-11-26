using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysVendas.frm;

namespace ERP.frm
{
    public partial class Frm_inicializa : Form
    {
        public Frm_inicializa()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 5;
            }
            else
            {
                timer1.Enabled = false;
                Frm_login Login = new Frm_login(this);
                Login.Show();
                this.Visible = false;

            }
        }
    }
}
