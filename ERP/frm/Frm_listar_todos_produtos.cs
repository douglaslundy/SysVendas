using ERP.Produtos;
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
    public partial class Frm_listar_todos_produtos : Form
    {

        decimal capitalEstocado = decimal.Parse("0,00");
        decimal capitalTotal = decimal.Parse("0,00");
        public Frm_listar_todos_produtos()
        {
            InitializeComponent();
            ListaProdutos();
        }

        private void Frm_listar_todos_produtos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;
            }
        }

        private void ListaProdutos()
        {
            try
            {
                var Produtos = new Produto();
                produtoBindingSource.DataSource = Produtos.Listar();
                
                foreach(var P in Produtos.Listar())
                {
                    capitalEstocado += P.PrecoPago * P.Estoque;
                    capitalTotal += P.PrecoVenda * P.Estoque;
                }

                lb_qdt_produtos_cadastrados.Text = "Produtos Cadastrados: " + Produtos.Listar().Count().ToString();
                lb_capital_estocado.Text = "Total de Capital Investido: " + capitalEstocado.ToString("c");
                lb_total_produtos_estocado.Text = "Total de Capital a Apurar: " + capitalTotal.ToString("c");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hove um problema ao listar produtos \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
