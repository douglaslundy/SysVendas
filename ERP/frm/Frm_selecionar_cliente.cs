using ERP.Clientes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ERP.frm
{
    public partial class Frm_selecionar_cliente : Form
    {
        Frm_finalizar_venda Finaliza;
        public Frm_selecionar_cliente(Frm_finalizar_venda finaliza)
        {
            InitializeComponent();
            ListarClientes();
            Finaliza = finaliza;
            txt_nome_cliente.Focus();
        }

       
        public void InsereCliente()
        {
            try
            {
                var id = dgv_cliente.CurrentRow.Cells[0].Value.ToString();
                Finaliza.InsereClienteNaVenda(int.Parse(id));
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao informar o produto \n" + ex.Message, "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ListarClientes()
        {
            try
            {
                clienteBindingSource.DataSource = new Cliente().PesquisarPorNomeOuCpf(txt_nome_cliente.Text).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um erro ao listar clientes \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_selecionar_ok_Click(object sender, EventArgs e)
        {
            InsereCliente();
        }

        private void Frm_selecionar_cliente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F12:
                    InsereCliente();
                    break;
            }
        }
        

        private void Frm_selecionar_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ListarClientes();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }


    }
}
