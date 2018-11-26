using ERP.ObjetosValor;
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
    public partial class Frm_entrada_estoque : Form
    {
        public Frm_entrada_estoque()
        {
            InitializeComponent();
            ListaProdutos();
            FechaForm();
        }

        public void LimparTextbox(Control controle)
        {
            foreach (Control ctle in controle.Controls)
            {
                if (ctle is TextBox)
                {
                    ((TextBox)ctle).Text = string.Empty;
                }
                else if (ctle.Controls.Count > 0)
                {
                    LimparTextbox(ctle);
                }
            }
        }

        private void Frm_entrada_estoque_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F4:
                    AbrirParaEdicao(dgv_produtos.CurrentRow.Cells[0].Value.ToString());
                    break;

                case Keys.F12:
                    AtualizaEstoque();
                    break;
            }
        }

        private void txt_qdt_entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValorTotal.BloqueiaLetrasECaracteresEspeciaisMenosVirgula(sender, e);
        }

        public void AbreForm()
        {
            txt_qdt_entrada.Enabled = true;
            btn_gravar.Enabled = true;
            txt_qdt_entrada.Focus();
        }

        public void FechaForm()
        {
            txt_qdt_entrada.Enabled = false;
            btn_gravar.Enabled = false;
        }

        public void ListaProdutos()
        {
            try
            {
                var produtos = new Produto();
                produtoBindingSource.DataSource = produtos.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hove um problema ao listar produtos \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AbrirParaEdicao(string codigo)
        {
            try
            {
                if (codigo == "")
                    throw new Exception("Produto Inválido");

                var produto = new Produto();
                produto = produto.PesquisaProdutoPorCodigo(codigo);
                AbreForm();
                txt_codigo.Text = produto.CodigoProduto;
                txt_nome.Text = produto.NomeProduto;               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao carregar os dados para edição \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AtualizaEstoque()
        {
            try
            {
                if (txt_codigo.Text == "")
                    throw new Exception("Produto Inválido");

                var produto = new Produto();
                produto = produto.PesquisaProdutoPorCodigo(txt_codigo.Text);
                produto.Estoque += decimal.Parse(txt_qdt_entrada.Text);
                produto.Atualizar(produto);

                MessageBox.Show("Estoque atualizado com sucesso \n", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTextbox(this);
                FechaForm();
                ListaProdutos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao carregar os dados para edição \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txt_produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rb_codigo.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08 )
                {
                    e.Handled = true;
                }

                if (e.KeyChar == 13)
                {
                    AbrirParaEdicao(txt_produto.Text);
                }
            }
            else
            {
                var produto = new Produto();

                if (string.IsNullOrEmpty(txt_produto.Text))
                    produtoBindingSource.DataSource = produto.Listar();

                produtoBindingSource.DataSource = produto.PesquisaProdutosPorNome(txt_produto.Text);
            }
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            AbrirParaEdicao(dgv_produtos.CurrentRow.Cells[0].Value.ToString());
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            AtualizaEstoque();
        }
    }
}
