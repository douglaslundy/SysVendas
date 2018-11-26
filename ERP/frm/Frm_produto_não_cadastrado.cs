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
    public partial class Frm_produto_não_cadastrado : Form
    {

        int num1;
        int num2;

        public Frm_produto_não_cadastrado()
        {
            InitializeComponent();
            txt_resposta.Focus();
            txt_resposta.Select();
            geraCharada();
        }

        private void txt_resposta_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.F12:
                    testaCharada();
                    break;
            }

        }

        private void btn_finalizar_venda_Click(object sender, EventArgs e)
        {
            testaCharada();
        }

        public void geraCharada()
        {
            try
            {
                txt_resposta.Focus();
                Random randNum = new Random();

                num1 = randNum.Next(1, 10);
                num2 = randNum.Next(1, 10);

                lb_1.Text = num1.ToString();
                lb_2.Text = num2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao gerar a charada \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void testaCharada()
        {
            try
            {
                if ((num1 + num2) == Convert.ToInt32(txt_resposta.Text))
                {
                    this.Close();
                }
                else
                {
                    lb_resposta_errada.Text = "Resposta errada tente novamente!";
                    lb_resposta_errada.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao testar a charada \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void BloqueiaLetrasECaracteresEspeciais(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txt_resposta_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloqueiaLetrasECaracteresEspeciais(sender, e);
        }
    }
}
