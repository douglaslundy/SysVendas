using ERP.ItensVendas;
using ERP.Vendas;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ERP.frm
{
    public partial class Frm_detalhar_venda : Form
    {
        int clienteId;
        int vendaId;
        public Frm_detalhar_venda(int cliente, int venda)
        {
            InitializeComponent();
            clienteId = cliente;
            vendaId = venda;
            ExibirVendaPorCliente(clienteId, vendaId);            
        }

        private void ExibirVendaPorCliente(int clienteId, int vendaId)
        {
            try
            {
                var Venda = new Venda().ExibirVendaPorCliente(clienteId, vendaId);
                vendaBindingSource.DataSource = Venda;
                itensVendaBindingSource.DataSource = new ItensVenda().ExibirItensDaVenda(Venda.CodigoVenda).ToList();
                lb_numero_venda.Text = "Venda Nº: " + vendaId;
            }
            catch (Exception ex)
            {
                itensVendaBindingSource.DataSource = null;
                MessageBox.Show("Houve uma falha ao Exibir Venda \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_detalhar_venda_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F12:
                    AbreFormImprimirCupon();
                    break;
            }            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                ExibirVendaPorCliente(clienteId, int.Parse(txt_numero_venda.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Informe o numero da venda \n", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Frm_detalhar_venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }


            if (e.KeyChar == 13)
            {
                ExibirVendaPorCliente(clienteId, int.Parse(txt_numero_venda.Text));
            }
        }


        public void AbreFormImprimirCupon()
        {
            try
            {
                var codigoVenda = new Venda().PegaCodigo(vendaId);

                Frm_deseja_imprimir_cupon Imprimir = new Frm_deseja_imprimir_cupon(codigoVenda);
                Imprimir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao imprimir cupon \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            AbreFormImprimirCupon();
        }
    }
}
