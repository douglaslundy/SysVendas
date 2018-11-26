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
    public partial class Frm_inform_prazo_da_venda : Form
    {
        Frm_finalizar_venda Finaliza;

        public Frm_inform_prazo_da_venda(Frm_finalizar_venda finaliza)
        {
            InitializeComponent();
            Finaliza =  finaliza;
    }

        private void Frm_inform_prazo_da_venda_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F12:
                    InformaDIasPrazo();
                    break;
            }
        }


        public void InformaDIasPrazo()
        {
            try
            {
                if (txt_dias_prazo_venda.Text == "")
                    throw new Exception("Informe um valor válido ou digite 0");

                var dataVencimento = DateTime.Now.AddDays(int.Parse(txt_dias_prazo_venda.Text));

                Finaliza.DataVencimento = dataVencimento;
                Finaliza.PrazoInformado = true;
                Finaliza.AtualizaLabelDataVencimento(dataVencimento);
                Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve uma falha ao informar prazo \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            InformaDIasPrazo();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txt_dias_prazo_venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08  && e.KeyChar != 48)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                InformaDIasPrazo();
            }
        }
    }
}
