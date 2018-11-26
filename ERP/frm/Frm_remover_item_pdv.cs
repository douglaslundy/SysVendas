using ERP.Carrinhos;
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
    public partial class Frm_remover_item_pdv : Form
    {
        Frm_pdv Pdv;
        public Frm_remover_item_pdv(Frm_pdv pdv)
        {
            InitializeComponent();
            Pdv = pdv;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Frm_remover_item_pdv_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;
                case Keys.F12:
                    Remove_item();
                    break;
            }
        }

        public void Remove_item()
        {
            try { 
                    var Carrinho = new Carrinho();

                    if (txt_item_remove.Text == "0")
                    {
                        Carrinho.RemoveTodosItens();

                        MessageBox.Show("Todos os items foram removidos com sucesso!", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pdv.Desconto = decimal.Parse("0,00");
                    Pdv.ListaProdutosCarrinho();
                        Pdv.LimparTextbox(Pdv);
                        Dispose();
                    }
                    else if (txt_item_remove.Text != "")
                    {
                        Carrinho.RemoveItem(int.Parse(txt_item_remove.Text));

                        Carrinho.AtualizaNumeroDosItens(Carrinho.RetornaItensASeremRenumerados(int.Parse(txt_item_remove.Text)));

                        MessageBox.Show("Ítem removido com sucesso", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Pdv.ListaProdutosCarrinho();
                        Pdv.LimparTextbox(Pdv);
                        Dispose();
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve uma falha ao remover o Ítem informado \n" + ex.Message, "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Pdv.LimparTextbox(Pdv);
                Dispose();
            }

        }

        private void txt_item_remove_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                Remove_item();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Remove_item();
        }
    }
}
