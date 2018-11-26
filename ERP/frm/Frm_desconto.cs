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
    public partial class Frm_desconto : Form
    {
        Frm_pdv Pdv;
        public Frm_desconto(Frm_pdv pdv)
        {
            InitializeComponent();
            Pdv = pdv;
        }

        private void Frm_desconto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;
                case Keys.F12:
                    AplicaDesconto();
                    break;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            AplicaDesconto();
        }

        private void Frm_desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                AplicaDesconto();
            }
        }

        private void AplicaDesconto()
        {
            try
            {
                if ((txt_desconto.Text.Split(',').Length - 1) > 1)
                    throw new Exception("Por favor informe um valor decimal");
                Pdv.AtualizaValorTotalComDesconto(decimal.Parse(txt_desconto.Text));
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao aplicar desconto \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
