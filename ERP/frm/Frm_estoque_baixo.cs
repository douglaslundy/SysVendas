using ERP.ObjetosValor;
using ERP.Produtos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ERP.frm
{
    public partial class Frm_estoque_baixo : Form
    {
        public Frm_estoque_baixo()
        {
            InitializeComponent();
            Listar();
        }

        private void Frm_estoque_baixo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;
            }
        }
        

        private void txt_estoque_abaixo_que_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValorTotal.BloqueiaLetrasECaracteresEspeciaisMenosVirgula(sender, e);
        }

        public void Listar()
        {
            try
            {
                var produtos = new Produto();
                produtoBindingSource.DataSource = produtos.Listar();
                CalculaLbs(produtos.Listar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao listar Produtos \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarPorEstoque()
        {
            try
            {
                if (txt_estoque_abaixo_que.Text == "")
                    throw new Exception("Digite um valor válido no estoque");
                var produtos = new Produto();
                produtoBindingSource.DataSource = produtos.ListarPorEstoque(decimal.Parse(txt_estoque_abaixo_que.Text));
                CalculaLbs(produtos.ListarPorEstoque(decimal.Parse(txt_estoque_abaixo_que.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao listar Produtos \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalculaLbs(IList<Produto> produtos)
        {
            try
            {
                decimal produtosCadastrados = decimal.Parse("0,00");
                decimal totalEstocado = decimal.Parse("0,00");
                decimal totalApurar = decimal.Parse("0,00");

                foreach (var p in produtos)
                {
                    produtosCadastrados ++;
                    totalEstocado += p.PrecoPago * p.Estoque;
                    totalApurar += p.PrecoVenda * p.Estoque; 
                }

                lb_qdt_produtos_encontrados.Text = "Produtos Cadastrados: " + produtosCadastrados.ToString();
                lb_capital_estocado.Text = "Capital Estocado: " +totalEstocado.ToString("c");
                lb_total_produtos_estocado.Text = "Total produtos estocados:  " + totalApurar.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao listar Produtos \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ListarPorEstoque();
        }
    }
}
