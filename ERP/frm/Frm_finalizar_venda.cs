using ERP.Carrinhos;
using ERP.Clientes;
using ERP.ItensVendas;
using ERP.ObjetosValor;
using ERP.Produtos;
using ERP.SessaoUsuario;
using ERP.Vendas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ERP.frm
{
    public partial class Frm_finalizar_venda : Form
    {
        Frm_pdv Pdv;
        public DateTime DataVencimento = DateTime.Now;
        public bool PrazoInformado = false;
        decimal TotalAPagar = decimal.Parse("0,00");
        Guid CodigoVenda;

        // 0 equivale a venda a vista
        TipoVenda TipoVenda = TipoVenda.A_Vista;



        public Frm_finalizar_venda(Frm_pdv pdv)
        {
            InitializeComponent();
            Pdv = pdv;
            PegaTotal();
            lb_total_apagar.Text = TotalAPagar.ToString();
        }

        public void PegaTotal()
        {
            TotalAPagar = Pdv.RetornaValorTotal();
            txt_dinheiro.Text = TotalAPagar.ToString();
        }

        private void Frm_finalizar_venda_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F7:
                    AbreFormCadastrarClientes();
                    break;

                case Keys.F10:
                    AbreFormSelecionaCliente();
                    break;

                case Keys.F12:
                    FinalizaVenda();
                    break;
            }            

        }

        

        private void VerificaSeDecimalValido(string txt)
        {
            if ((txt.Split(',').Length - 1) > 1)
                throw new Exception("Por favor informe um valor decimal");
        }

        public void CalcularTotalPago()
        {
            try
            {

                ValidaTextBox();

                decimal total = Convert.ToDecimal(Convert.ToDecimal(txt_dinheiro.Text) 
                                                + Convert.ToDecimal(txt_cartao_credito.Text)
                                                + Convert.ToDecimal(txt_cartao_debito.Text) 
                                                + Convert.ToDecimal(txt_cheque.Text));

                txt_total_pago.Text = total.ToString();
                decimal troco = Convert.ToDecimal(total - TotalAPagar);
                lb_valor_troco.Text = troco.ToString();

                if(TipoVenda == TipoVenda.A_Vista)
                    InformaSeTrocoOuFalta(troco);
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Houve uma Falha ao calcular os valores " + e.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_dinheiro.Text = "0,00";
                txt_cartao_credito.Text = "0,00";
                txt_cartao_debito.Text = "0,00";
                txt_cheque.Text = "0,00";
            }
        }


        public void InformaSeTrocoOuFalta(decimal troco)
        {
            if (troco < 0)
            {
                lb_titulo_troco.Text = "FALTA:";
            }
            else
            {
                lb_titulo_troco.Text = "TROCO:";
            }
        }

        public void ValidaTextBox()
        {
            if (txt_dinheiro.Text == "")
                txt_dinheiro.Text = "0,00";

            if (txt_cartao_credito.Text == "")
                txt_cartao_credito.Text = "0,00";

            if (txt_cartao_debito.Text == "")
                txt_cartao_debito.Text = "0,00";

            if (txt_cheque.Text == "")
                txt_cheque.Text = "0,00";
        }

        private void txt_dinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            CalcularTotalPago();
        }

        private void txt_cartao_credito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            CalcularTotalPago();
        }

        private void txt_cartao_debito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            CalcularTotalPago();
        }

        private void txt_cheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != 08 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            CalcularTotalPago();
        }

        private void txt_dinheiro_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularTotalPago();
        }

        private void txt_cartao_credito_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularTotalPago();
        }

        private void txt_cartao_debito_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularTotalPago();
        }

        private void txt_cheque_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularTotalPago();
        }

        private void btn_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            AbreFormCadastrarClientes();
        }

        public void AbreFormCadastrarClientes()
        {
            try
            {
                var CadastrarClientes = new Frm_cadastrar_cliente();
                CadastrarClientes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_finalizar_venda_Click(object sender, EventArgs e)
        {
            FinalizaVenda();
        }

        private void CarregarDadosDoForm(Venda venda)
        {
            try
            {
                // venda a vista == 0
                // pagamento realizado sim == 0

                venda.UsuarioId = Sessao.Id;
                venda.CodigoVenda = Guid.NewGuid();
                CodigoVenda = venda.CodigoVenda;
                venda.TotalVenda = decimal.Parse(lb_total_apagar.Text);
                venda.TotalPago = decimal.Parse(txt_total_pago.Text);
                venda.Troco = decimal.Parse(lb_valor_troco.Text);
                venda.DataVenda = DateTime.Now;
                venda.Desconto = Pdv.Desconto;
                venda.PagamentoDinheiro = decimal.Parse(txt_dinheiro.Text);
                venda.PagamentoCartaoCredito = decimal.Parse(txt_cartao_credito.Text);
                venda.PagamentoCartaoDebito = decimal.Parse(txt_cartao_debito.Text);
                venda.PagamentoCheque = decimal.Parse(txt_cheque.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao carregar dados do formulário \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsereClienteNaVenda(int id)
        {
            try
            {
                if (id == 0)
                    throw new Exception("Selecione um cliente válido");

                var Cliente = new Cliente();
                Cliente = Cliente.PesquisarPorId(id);

                if (Cliente.Limite < (TotalAPagar + Cliente.SaldoDebitos))
                    LiberarVendaComLimiteExcedido();

                TipoVenda = TipoVenda.A_Prazo;

                txt_id_cliente.Text = id.ToString();
                txt_cliente.Text = Cliente.NomeCompleto.ToString();
                txt_endereco.Text = Cliente.Endereco;
                txt_telefone.Text = Cliente.Telefone.ToString();

                lb_titulo_troco.Text = "Venda a Prazo";
                lb_titulo_troco.ForeColor = Color.Red;
                lb_valor_troco.Visible = false;

                lb_data_vencimento.Visible = true;
                lb_data_vencimento.Text = "Data \n de vencimento";

                txt_dinheiro.Text = "0,00";
                txt_cartao_credito.Text = "0,00";
                txt_cartao_debito.Text = "0,00";
                txt_cheque.Text = "0,00";
                txt_total_pago.Text = "0,00";

                txt_dinheiro.Enabled = false;
                txt_cartao_credito.Enabled = false;
                txt_cartao_debito.Enabled = false;
                txt_cheque.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao inserir cliente na venda \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void LiberarVendaComLimiteExcedido()
        {
            try
            {
                var Liberar = new Frm_liberar_venda(this);
                Liberar.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VendaAvista(Venda venda)
        {
            venda.TipoVenda = TipoVenda.A_Vista;
            venda.DataVencimento = DateTime.Now;
            venda.DataPagamento = DateTime.Now;
            venda.PagamentoRealizado = Status.Sim;
            venda.ClienteId = 0;
        }

        public void VendaAPrazo(Venda venda)
        {
            if (TipoVenda == TipoVenda.A_Prazo)
            {
                AbrirFormDeInformaPrazo();
            }
        }


        public void AtualizaLabelDataVencimento(DateTime data)
        {
            lb_data_vencimento.Text = data.ToString("dd/MM/yyyy");
        }


        private void AbrirFormDeInformaPrazo()
        {
            try
            {
                var InformaPrazo = new Frm_inform_prazo_da_venda(this);
                InformaPrazo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VincularProdutosVenda()
        {
            try
            {
                var Carrinho = new Carrinho();

                foreach(var item in Carrinho.Listar())
                {
                    SalvarItem(item);
                    AtualizaEstoque(item.ProdutoId, item.Quantidade);
                }

                Carrinho.RemoveTodosItens();
                Pdv.ListaProdutosCarrinho();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao vincular produtos na venda \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizaEstoque(int produtoId, decimal quantidade)
        {
            var produto = new Produto();
            produto = produto.PesquisarPorId(produtoId);

            produto.Estoque -= quantidade;

            produto.Atualizar(produto);
        }

        public void SalvarItem(Carrinho itemCarrinho)
        {
            var Item = new ItensVenda
            {
                NumeroItem = itemCarrinho.NumeroItem,
                ProdutoId = itemCarrinho.ProdutoId,
                Quantidade = itemCarrinho.Quantidade,
                SubTotal = itemCarrinho.SubTotal,
                CodigoVenda = CodigoVenda,
                PrecoProduto = itemCarrinho.ValorUnitario
            };

            Item.Salvar(Item);

        }


        public void FinalizaVenda()
        {
            try
            {
                var venda = new Venda();

                CarregarDadosDoForm(venda);
                
                if(TipoVenda == TipoVenda.A_Vista)
                {
                    VendaAvista(venda);
                    SalvarVenda(venda);
                }
                else if (TipoVenda == TipoVenda.A_Prazo && PrazoInformado == false)
                {
                    VendaAPrazo(venda);
                }


                if (PrazoInformado)
                {

                    venda.TipoVenda = TipoVenda.A_Prazo;
                    venda.ClienteId = int.Parse(txt_id_cliente.Text);

                    venda.DataVencimento = DataVencimento;
                    venda.PagamentoRealizado = Status.Nao;

                    SalvarVenda(venda);
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao finalizar esta venda \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void AtualizaSaldoDevedorCliente(int clienteId)
        {
            var cliente = new Cliente();
            cliente = cliente.PesquisarPorId(clienteId);
            cliente.SaldoDebitos += TotalAPagar;
            cliente.Atualizar(cliente);
        }

        public void SalvarVenda(Venda venda)
        {
            if (txt_id_cliente.Text != "")
                AtualizaSaldoDevedorCliente(int.Parse(txt_id_cliente.Text));

            venda.Salvar(venda);
            Pdv.Desconto = 0;
            VincularProdutosVenda();
            Pdv.LimparTextbox(Pdv);
            AbreFormImprimir();
            Dispose();
        }


        public void AbreFormImprimir()
        {
            try
            {
                var Deseja_imprimir_cupon = new Frm_deseja_imprimir_cupon(CodigoVenda);
                Deseja_imprimir_cupon.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void  AbreFormSelecionaCliente()
        {
            try
            {
                var SelecionaCliente = new Frm_selecionar_cliente(this);
                SelecionaCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_selecionar_cliente_Click(object sender, EventArgs e)
        {
            AbreFormSelecionaCliente();
        }
    }
}
