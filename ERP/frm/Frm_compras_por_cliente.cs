using ERP.Clientes;
using ERP.Vendas;
using System;
using System.Windows.Forms;

namespace ERP.frm
{
    public partial class Frm_compras_por_cliente : Form
    {

        Frm_lista_clientes ListaClientes;
        int clienteId;


        public Frm_compras_por_cliente(Frm_lista_clientes listaClientes, int id)
        {
            InitializeComponent();
            clienteId = id;
            ListarVendasDoCliente(clienteId);
            PegaCliente(clienteId);

            ListaClientes = listaClientes;
        }


        private void PegaCliente(int clienteId)
        {
            lb_cliente.Text = "Cliente: " + new Cliente().PesquisarPorId(clienteId).NomeCompleto.ToString();
        }

        private void ListarVendasDoCliente(int clienteId)
        {
            var Vendas = new Venda().ListarVendasAPagasPorCliente(clienteId);
            vendaBindingSource.DataSource = Vendas;
        }

        private void btn_detalhar_compra_Click(object sender, EventArgs e)
        {
            AbrirFormDetalhaVenda();
        }

        public void AbrirFormDetalhaVenda()
        {
            try
            {
                var vendaId = int.Parse(dgv_vendas.CurrentRow.Cells[0].Value.ToString());
                var DetalhaVenda = new Frm_detalhar_venda(clienteId, vendaId);
                DetalhaVenda.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_compras_por_cliente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F5:
                    AbrirFormDetalhaVenda();
                    break;
            }
        }
        private void ExibirVendaPorCliente(int clienteId, int vendaId)
        {
            try
            {
                var Venda = new Venda().ExibirVendaPorCliente(clienteId, vendaId);
                vendaBindingSource.DataSource = Venda;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao Exibir Venda \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ExibirVendaPorCliente(clienteId, int.Parse(txt_numero_venda.Text));
        }

        private void Frm_compras_por_cliente_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
