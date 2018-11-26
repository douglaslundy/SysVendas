using ERP.Clientes;
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
    public partial class Frm_clientes_inadimplentes : Form
    {
        public Frm_clientes_inadimplentes()
        {
            InitializeComponent();
            ListaClientesInadimplentes();
        }

        private void Frm_clientes_inadimplentes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;
            }
        }

        public void ListaClientesInadimplentes()
        {
            try {
                    var clientes = new Cliente();
                    clienteBindingSource.DataSource = clientes.ListaClientesInadinplentes(txt_cliente.Text);
                    CalculaLb(clientes.ListaClientesInadinplentes(txt_cliente.Text));

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Houve um problema ao listar clientes \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        public void CalculaLb(IList<Cliente> clientes)
        {
            try
            {
                decimal TotalDevedor = decimal.Parse("0,00");
                foreach (var dados in clientes)
                {
                    TotalDevedor += dados.SaldoDebitos;
                }

                lb_total_clientes.Text = "Total de clientes: " + clientes.Count();
                lb_total_debitos.Text = "Total a receber: " + TotalDevedor.ToString("c");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao listar clientes \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void txt_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ListaClientesInadimplentes();
        }
    }
}
