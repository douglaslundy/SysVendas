using ERP.ObjetosValor;
using System;
using System.Windows.Forms;
using ERP.Produtos;
namespace ERP.frm
{
    public partial class Frm_cadastrar_produto : Form
    {
        public Frm_cadastrar_produto()
        {
            InitializeComponent();
        }

        private void Frm_cadastrar_produto_Load(object sender, EventArgs e)
        {

            ListaProdutos();
            FechaForm();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            CadastrarProduto();
        }

        private void Frm_cadastrar_produto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;
                case Keys.F4:
                    AbrirParaEdicao(dgv_produtos.CurrentRow.Cells[0].Value.ToString());
                    break;
                case Keys.F10:
                    DeletarProduto();
                    break;
                case Keys.F12:
                    CadastrarProduto();
                    break;

            }
        }

        public void CadastrarProduto()
        {
            try
            {

                var produto = new Produto();

                if (produto.VerificaSeProdutoJaCadastrado(txt_codigo.Text))
                {
                    produto = produto.PesquisaProdutoPorCodigo(txt_codigo.Text);
                    CarregarDadosDoForm(produto);

                    produto.Atualizar(produto);
                    MessageBox.Show("Produto Atualizado com sucesso!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTextbox(this);
                    ListaProdutos();
                    FechaForm();
                }
                else
                {
                    CarregarDadosDoForm(produto);
                    produto.Salvar(produto);
                    MessageBox.Show("Produto Cadastrado com sucesso!");
                    LimparTextbox(this);
                    ListaProdutos();
                    FechaForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao cadastrar o produto \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregarDadosDoForm(Produto produto)
        {
            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
                throw new ArgumentException("Código do produto é obrigatório");

            if (txt_codigo.Text.Length > 20)
                throw new ArgumentException("Codigo do produto é muito grande");

            if (string.IsNullOrWhiteSpace(txt_nome.Text))
                throw new ArgumentException("Nome do produto é obrigatório");

            if (txt_nome.Text.Length > 50)
                throw new ArgumentException("Nome do produto é muito grande");

            if (string.IsNullOrWhiteSpace(txt_estoque.ToString()))
                throw new ArgumentException("Estoque do produto não pode ficar vazio");

            if (txt_preco_pago.Text.Trim() == string.Empty)
                throw new Exception("O Campo preço pago é obrigatório");

            if (txt_preco_venda.Text.Trim() == string.Empty)
                throw new Exception("O Campo preço venda é obrigatório");

            if (txt_estoque.Text.Trim() == string.Empty)
                throw new Exception("O Campo estoque é obrigatório");

            produto.CodigoProduto = txt_codigo.Text;
            produto.NomeProduto = txt_nome.Text;
            produto.PrecoPago = decimal.Parse(txt_preco_pago.Text);
            produto.PrecoVenda = decimal.Parse(txt_preco_venda.Text);
            produto.Estoque = decimal.Parse(txt_estoque.Text);
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

        private void txt_preco_venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValorTotal.BloqueiaLetrasECaracteresEspeciaisMenosVirgula(sender, e);
        }

        private void txt_preco_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValorTotal.BloqueiaLetrasECaracteresEspeciaisMenosVirgula(sender, e);
        }

        private void txt_estoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValorTotal.BloqueiaLetrasECaracteresEspeciaisMenosVirgula(sender, e);
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

        public void AbreForm()
        {
            txt_codigo.Enabled = false;
            txt_nome.Enabled = true;
            txt_preco_pago.Enabled = true;
            txt_preco_venda.Enabled = true;
            txt_estoque.Enabled = true;
            btn_gravar.Enabled = true;
        }

        public void AbreFormEdicao()
        {
            txt_codigo.Enabled = false;
            txt_nome.Enabled = true;
            txt_preco_pago.Enabled = true;
            txt_preco_venda.Enabled = true;
            txt_estoque.Enabled = false;
            btn_gravar.Enabled = true;
            btn_excluir.Visible = true;
            btn_excluir.Enabled = true;
        }

        public void FechaForm()
        {
            txt_codigo.Enabled = true;
            txt_nome.Enabled = false;
            txt_preco_pago.Enabled = false;
            txt_preco_venda.Enabled = false;
            txt_estoque.Enabled = false;
            btn_gravar.Enabled = false;
            btn_excluir.Visible = false;
            btn_excluir.Enabled = false;
            txt_codigo.Focus();
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == 13)
                {
                    var Produto = new Produto();
                    if (Produto.VerificaSeProdutoJaCadastrado(txt_codigo.Text))
                        MessageBox.Show("Este produto já foi cadastrado", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        AbreForm();
                    txt_nome.Focus();

                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Houve um problema ao verificar produto \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rb_codigo.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08)
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

        private void btn_abrir_para_edicao_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirParaEdicao(dgv_produtos.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao selecionar produto" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AbrirParaEdicao(string codigo)
        {
            try
            {
                var produto = new Produto();
                produto = produto.PesquisaProdutoPorCodigo(codigo);
                AbreFormEdicao();
                txt_codigo.Text = produto.CodigoProduto;
                txt_nome.Text = produto.NomeProduto;
                txt_preco_pago.Text = produto.PrecoPago.ToString();
                txt_preco_venda.Text = produto.PrecoVenda.ToString();
                txt_estoque.Text = produto.Estoque.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao carregar os dados para edição \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {            
            DeletarProduto();               
        }

        private void DeletarProduto()
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Tem Certeza que deseja Excluir o produto?", "Excluir produto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    var produto = new Produto();
                    produto = produto.PesquisaProdutoPorCodigo(txt_codigo.Text);
                    produto.Deletar(produto); MessageBox.Show("Produto deletado com sucesso! \n", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaProdutos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao deletar o produto \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
