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
    public partial class Frm_valor_cliente_pagou : Form
    {
        Frm_efetuar_pagamentos_compras_cliente EfetuarPagamento;
        public Frm_valor_cliente_pagou(Frm_efetuar_pagamentos_compras_cliente efetuarPagamento)
        {
            InitializeComponent();
            EfetuarPagamento = efetuarPagamento;
        }

        private void Frm_valor_cliente_pagou_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F12:
                    InformaValorPago();
                    break;
            }
        }

        private void Frm_valor_cliente_pagou_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                InformaValorPago();
            }
        }

        public void ValidaDecimal()
        {
            try
            {
                RegraDecimal();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Informe um valor válido \n " + ex.Message,"Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_valor_pago.Text = "";
            }
        }

        public void RegraDecimal()
        {
            if ((txt_valor_pago.Text.Split(',').Length - 1) > 1)
                throw new Exception("Por favor informe um valor decimal");
        }

        private void txt_valor_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaDecimal();
        }

        private void txt_valor_pago_KeyUp(object sender, KeyEventArgs e)
        {
            ValidaDecimal();
        }

        public void InformaValorPago()
        {
            try
            {
                EfetuarPagamento.InformaValorPago(decimal.Parse(txt_valor_pago.Text));
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao informar o valor pago pelo cliente \n " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_valor_pago.Text = "";
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            InformaValorPago();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
