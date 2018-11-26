using ERP.Carrinhos;
using ERP.Produtos;
using ERP.SessaoUsuario;
using ERP.Usuarios;
using System;
using System.Windows.Forms;
using SysVendas.frm;

namespace ERP.frm
{
    public partial class Frm_pdv : Form
    {
        Usuario Usuario;
        public decimal Desconto = decimal.Parse("0,00");

        public Frm_pdv()
        {
            InitializeComponent();
            ListaProdutosCarrinho();
            Usuario = new UsuarioLogado().RetornaUsuarioLogado();
            timer_relogio_pdv.Start();
        }

        private void timer_relogio_pdv_Tick(object sender, EventArgs e)
        {
            DateTime relogio = DateTime.Now;
            lb_relogio.Text = relogio.ToString();
        }

        private void Frm_pdv_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F2:
                    AbrirFormDesconto();
                    break;

                case Keys.F7:
                    AbrirFormSelecionarProduto();
                    break;

                case Keys.F8:
                    AbreFormRemoverProduto();
                    break;

                case Keys.F12:
                    AbreFormFinalizaVenda();
                    break;
            }
        }

        public void ListaProdutosCarrinho()
        {
            try
            {
                txt_codigo_produto.Text = "";
                txt_codigo_produto.Focus();
                var produtos = new Carrinho();
                carrinhoBindingSource.DataSource = produtos.Listar();
                AtualizaValorTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao atualizar carrinho \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public decimal RetornaValorTotal()
        {
            AtualizaValorTotal();
            return decimal.Parse(txt_valor_total.Text);

        }

        public void AtualizaValorTotal()
        {
            try
            {
                AtualizaValorTotalComDesconto(Desconto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao atualizar os dados \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void AtualizaValorTotalComDesconto(decimal valorDesconto)
        {
            try
            {
                Desconto = valorDesconto;
                var Carrinho = new Carrinho();
                decimal valorTotal = Carrinho.AtualizarValorTotal();

                if (valorTotal <= 0)
                    Desconto = 0;

                if (valorTotal > 0 && valorDesconto > valorTotal)
                    throw new Exception("O desconto não pode ser maior que o total da venda");

                txt_valor_total.Text = (valorTotal - valorDesconto).ToString();
                
                if(Desconto > 0)
                    lb_desconto.Visible = true;
                else
                    lb_desconto.Visible = false;

                lb_desconto.Text = Desconto.ToString("C");
            }
            catch(Exception ex)
            {
                Desconto = 0;
                MessageBox.Show("Houve uma falha ao atualizar valores \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Frm_pdv_Load(object sender, EventArgs e)
        {
            lb_usuario.Text = Usuario.Login;
            lb_desconto.Text = "";
            lb_nome_produto.Text = "";
        }

        private void txt_codigo_produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08 && e.KeyChar != 42 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                try
                {
                    if (txt_codigo_produto.Text == "")
                    {
                        var buscarProdutoPorNome = new Frm_seleciona_produto(this, txt_codigo_produto.Text);
                        buscarProdutoPorNome.Show();
                    }
                    else
                    {
                        InserirProdutoCarrinho(txt_codigo_produto.Text);
                    }
                }
                catch (Exception ex)
                {
                    LimparTextbox(this);
                }
            }
        }

        private decimal PegaQuantidade(string codigo)
        {
            if (codigo.Contains("*"))
            {

                string texto = codigo;
                string[] colunas = texto.Split('*');

                return decimal.Parse(colunas[0]);
            }
            else
            {
                return 1;
            }
        }

        private string PegaCodigo(string codigo)
        {
            if (codigo.Contains("*"))
            {

                string texto = codigo;
                string[] colunas = texto.Split('*');

                return colunas[1];
            }
            else
            {
                return codigo;
            }
        }

        public void LimparTextbox(Control controle)
        {
            foreach (Control ctle in controle.Controls)
            {
                if (ctle is TextBox)
                {
                    ((TextBox)ctle).Text = string.Empty;
                    txt_codigo_produto.Focus();
                    lb_nome_produto.Text = "";
                    txt_preco_unitario.Text = "";
                    txt_qdt_produtos.Text = "";
                    txt_sub_total.Text = "";
                    lb_desconto.Text = "";
                }
                else if (ctle.Controls.Count > 0)
                {
                    LimparTextbox(ctle);
                    txt_codigo_produto.Focus();
                    lb_nome_produto.Text = "";
                    txt_preco_unitario.Text = "";
                    txt_qdt_produtos.Text = "";
                    txt_sub_total.Text = "";
                }
            }
        }

        public void InsereProdutoCarrinho(string codigo)
        {
            InserirProdutoCarrinho(codigo);
        }

        
        public void SubtraiEstoque()
        {

        }

        private void InserirProdutoCarrinho(string codigo)
        {
            try
            {
                lb_nome_produto.Text = "";
                var Produto = new Produto();
                if (Produto.VerificaSeProdutoJaCadastrado(PegaCodigo(codigo)))
                {
                    Produto = Produto.PesquisaProdutoPorCodigo(PegaCodigo(codigo));

                    var Carrinho = new Carrinho();
                    Carrinho.ProdutoId = Produto.Id;
                    Carrinho.ValorUnitario = Produto.PrecoVenda;
                    Carrinho.Quantidade = PegaQuantidade(codigo);
                    Carrinho.SubTotal = Produto.PrecoVenda * PegaQuantidade(codigo);
                    Carrinho.NumeroItem = Carrinho.NumeroItenASerCadastrado();
                    Carrinho.UsuarioId = Usuario.Id;
                    Carrinho.InsereProdutoNoCarrinho(Carrinho);

                    lb_nome_produto.Text = Produto.NomeProduto;
                    txt_preco_unitario.Text = Produto.PrecoVenda.ToString("C");
                    txt_qdt_produtos.Text = PegaQuantidade(codigo).ToString();
                    txt_sub_total.Text = (Produto.PrecoVenda * PegaQuantidade(codigo)).ToString("C");
                    ListaProdutosCarrinho();
                }
                else
                {                    
                    LimparTextbox(this);
                    lb_nome_produto.Text = "Produto não cadastrado";
                    AbrirFormProdutoNaoCadastrado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao inserir o produto na compra \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparTextbox(this);
            }
        }

        private void btn_pesquisar_produtos_Click(object sender, EventArgs e)
        {
            AbrirFormSelecionarProduto();
        }

        public void AbrirFormSelecionarProduto()
        {
            try
            {
                var SelecionaProduto = new Frm_seleciona_produto(this, txt_codigo_produto.Text);
                SelecionaProduto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparTextbox(this);
            }
        }

        public void AbrirFormDesconto()
        {
            try
            {
                var Desconto = new Frm_desconto(this);
                Desconto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparTextbox(this);
            }
        }

        public void AbrirFormProdutoNaoCadastrado()
        {
            try
            {
                var NaoCadastrado = new Frm_produto_não_cadastrado();
                NaoCadastrado.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparTextbox(this);
            }
        }

        private void btn_remover_produtos_Click(object sender, EventArgs e)
        {
            AbreFormRemoverProduto();
        }

        public void AbreFormRemoverProduto()
        {
            try
            {
                var RemoverItem = new Frm_remover_item_pdv(this);
                RemoverItem.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparTextbox(this);
            }
        }

        private void btn_desconto_Click(object sender, EventArgs e)
        {
            AbrirFormDesconto();
        }

        private void btn_finalizar_venda_Click(object sender, EventArgs e)
        {
            AbreFormFinalizaVenda();
        }

        public void AbreFormFinalizaVenda()
        {
            try
            {
                if (new Carrinho().Listar().Count == 0)
                    throw new Exception("Insira pelo menos 1 produto para finalizar a venda");

                var FinalizarVenda = new Frm_finalizar_venda(this);
                FinalizarVenda.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparTextbox(this);
            }
        }
    }
}
