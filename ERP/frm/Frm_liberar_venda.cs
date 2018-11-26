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
    public partial class Frm_liberar_venda : Form
    {

        Frm_finalizar_venda Finaliza;
        public Frm_liberar_venda(Frm_finalizar_venda finaliza)
        {
            InitializeComponent();
            Finaliza = finaliza;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Finaliza.Dispose();
            Dispose();
        }

        private void Frm_liberar_venda_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Finaliza.Dispose();
                    Dispose();
                    break;

                case Keys.F12:
                    Dispose();
                    break;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
