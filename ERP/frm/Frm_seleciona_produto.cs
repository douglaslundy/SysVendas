using ERP.frm;
using ERP.Produtos;
using System;
using System.Windows.Forms;

namespace SysVendas.frm
{
    public partial class Frm_seleciona_produto : Form
    {
        Frm_pdv PDV;
        string Txt_codigo_pdv;
        public Frm_seleciona_produto(Frm_pdv pdv, string txt_codigo_pdv)
        {
            InitializeComponent();
            PDV = pdv;
            Txt_codigo_pdv = txt_codigo_pdv;
        }

        private void btn_cancelar_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }

        private void Frm_seleciona_produto_Load(object sender, System.EventArgs e)
        {
            ListarProdutos();
        }

        public void ListarProdutos()
        {
            try
            {

                var Produtos = new Produto();
                produtoBindingSource.DataSource = Produtos.PesquisaProdutosPorNome(txt_nome_produto.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve uma falha ao listar os produtos \n" + ex.Message, "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsereProduto()
        {
            try
            {
                string codigo =  Txt_codigo_pdv;
                codigo += dgv_produtos.CurrentRow.Cells[0].Value.ToString();
                PDV.InsereProdutoCarrinho(codigo);
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao informar o produto \n" + ex.Message, "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_seleciona_produto_KeyDown(object sender, KeyEventArgs e)
        {
            ListarProdutos();

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F12:
                    InsereProduto();
                    break;
            }
        }

        private void btn_selecionar_ok_Click(object sender, EventArgs e)
        {
            InsereProduto();
        }
    }
}
