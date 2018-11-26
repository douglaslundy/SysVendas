using ERP.Vendas;
using System;
using System.Windows.Forms;

namespace ERP.frm
{
    public partial class Frm_listar_vendas : Form
    {
        public Frm_listar_vendas()
        {
            InitializeComponent();
            dtp_data_inicial.Value = DateTime.Parse("01/" + DateTime.Now.Date.Month + "/" + DateTime.Now.Date.Year);
            ListarVendasAll();
        }

        private void ListarVendasAll()
        {
            try
            {
                decimal TotalVendas = decimal.Parse("0,00");

                var Venda = new Venda().ListarAll(dtp_data_inicial.Value, dtp_datafinal.Value);
                vendaBindingSource.DataSource = Venda;

                foreach(var v in Venda)
                {
                    TotalVendas += v.TotalVenda;
                }

                lb_total_das_vendas.Text = "Total das vendas: " + TotalVendas.ToString("c");
            }
            catch (Exception ex)
            {
                itensVendaBindingSource.DataSource = null;
                MessageBox.Show("Houve uma falha ao Exibir Venda \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_listar_vendas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F5:
                    AbrirFormDetalhaVenda();
                    break;

                case Keys.F12:
                    AbreFormImprimirCupon();
                    break;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            ListarVendasAll();
        }


        public void AbrirFormDetalhaVenda()
        {
            try
            {
                var vendaId = int.Parse(dgv_vendas.CurrentRow.Cells[0].Value.ToString());
                var clienteId = int.Parse(dgv_vendas.CurrentRow.Cells[1].Value.ToString());

                var DetalhaVenda = new Frm_detalhar_venda(clienteId, vendaId);
                DetalhaVenda.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_detalha_venda_Click(object sender, EventArgs e)
        {
            AbrirFormDetalhaVenda();
        }

        public void AbreFormImprimirCupon()
        {
            try
            {
                var vendaId = int.Parse(dgv_vendas.CurrentRow.Cells[0].Value.ToString());
                var codigoVenda = new Venda().PegaCodigo(vendaId);

                Frm_deseja_imprimir_cupon Imprimir = new Frm_deseja_imprimir_cupon(codigoVenda);
                Imprimir.Show();
            }
            catch(Exception ex)
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
