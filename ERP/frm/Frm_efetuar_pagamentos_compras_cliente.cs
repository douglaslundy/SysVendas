using ERP.Clientes;
using ERP.ObjetosValor;
using ERP.SessaoUsuario;
using ERP.Vendas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ERP.frm
{
    public partial class Frm_efetuar_pagamentos_compras_cliente : Form
    {

        Frm_lista_clientes ListaClientes;
        int clienteId;
        decimal SaldoTotalAPagar;

        public Frm_efetuar_pagamentos_compras_cliente(Frm_lista_clientes listaClientes, int id)
        {
            InitializeComponent();
            clienteId = id;
            ListarVendasDoCliente(clienteId);
            PegaCliente(clienteId);

            ListaClientes = listaClientes;

        }

        private void PegaCliente(int clienteId)
        {
            lb_cliente.Text = "Cliente: " + new Cliente().PesquisarPorId(clienteId).NomeCompleto.ToString();
        }

        private void ListarVendasDoCliente(int clienteId)
        {
            var Vendas = new Venda().ListarVendasAPrazoPorCliente(clienteId);
            vendaBindingSource.DataSource = Vendas;
            TotalDebitosDoCliente(Vendas);

        }

        private void Frm_efetuar_pagamentos_compras_cliente_KeyDown(object sender, KeyEventArgs e)
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
                    AbrirFormDeValorPago();
                    break;
            }
        }

        private void TotalDebitosDoCliente(IList<Venda> vendas)
        {
            var total = decimal.Parse("0.00");
            foreach (var dados in vendas)
            {
                total += dados.TotalVenda - dados.TotalPago;
            }

            SaldoTotalAPagar = total;
            lb_total_pagar.Text = "Total Débitos: " + total.ToString("c");
        }


        public void AbrirFormDetalhaVenda()
        {
            try
            {
                var vendaId = int.Parse(dgv_vendas.CurrentRow.Cells[0].Value.ToString());
                var DetalhaVenda = new Frm_detalhar_venda(clienteId, vendaId);
                DetalhaVenda.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InformaValorPago(decimal valorPago)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Confirma o Valor pago pelo cliente? \n"
                + valorPago.ToString("c"), "Confirma o Valor?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    if (valorPago >= SaldoTotalAPagar)
                    {
                        var troco = valorPago - SaldoTotalAPagar;

                        ReceberTodasAsVendas(SaldoTotalAPagar);

                        MessageBox.Show("Pagamento Realizado com sucesso \n " +
                            "Troco : " + troco.ToString("c"),
                            "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if(valorPago < SaldoTotalAPagar)
                    {
                        RealizaNovaVendaValorRestante(SaldoTotalAPagar - valorPago, valorPago);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao informar o valor pago pelo cliente \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RealizaNovaVendaValorRestante(decimal ValorVenda, decimal ValorPago)
        {
            ReceberParcialmenteAsVendas(ValorPago);

            //var venda = new Venda
            //{
            //    CodigoVenda = Guid.NewGuid(),
            //    PagamentoRealizado = Status.Nao,
            //    TipoVenda = TipoVenda.A_Prazo,
            //    DataVenda = DateTime.Now,
            //    DataVencimento = DateTime.Now.AddDays(30),
            //    TotalVenda = ValorVenda,
            //    ClienteId = clienteId,
            //    UsuarioId = Sessao.Id
            //};

            //venda.Salvar(venda);

            //MessageBox.Show("Pagamento Realizado com sucesso \n " +
            //                "Foi gerado uma nova venda com valor restante de: " + ValorVenda.ToString("c"),
            //                "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);


            MessageBox.Show("Pagamento Parcial Realizado com sucesso \n " +
                            "Foi Recebido de suas dividas o valor de : " + ValorPago.ToString("c"),
                            "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);


            ListarVendasDoCliente(clienteId);
        }

        public void ReceberTodasAsVendas(decimal ValorSaldoDevedorPago)
        {
            try
            {
                var Vendas = new Venda().ListarVendasAPrazoPorCliente(clienteId);
                foreach (var venda in Vendas)
                {
                    venda.PagamentoRealizado = Status.Sim;
                    venda.DataPagamento = DateTime.Now;
                    venda.PagamentoDinheiro = venda.TotalVenda;
                    venda.TotalVenda += venda.TotalPago;
                    venda.TotalPago += venda.TotalVenda;
                    venda.Atualiza(venda);
                    
                }

                AtualizarSaldoCliente(ValorSaldoDevedorPago);
                ListarVendasDoCliente(clienteId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao Receber Vendas \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReceberParcialmenteAsVendas(decimal ValorPago)
        {
            try
            {
                // valor parcial pago 
                decimal parcial = ValorPago;

                var Vendas = new Venda().ListarVendasAPrazoPorCliente(clienteId);
                foreach (var venda in Vendas)
                {
                    if (parcial >= (venda.TotalVenda - venda.TotalPago))
                    {
                        parcial -= (venda.TotalVenda - venda.TotalPago);

                        venda.PagamentoRealizado = Status.Sim;
                        venda.DataPagamento = DateTime.Now;
                        venda.PagamentoDinheiro = venda.TotalVenda;
                        //venda.TotalVenda = venda.TotalVenda;
                        venda.TotalPago = venda.TotalVenda;
                        venda.Atualiza(venda);


                    } else if(parcial < venda.TotalVenda)
                    {
                        venda.DataPagamento = DateTime.Now;
                        venda.DataVencimento = DateTime.Now.AddDays(30);
                        venda.PagamentoDinheiro = parcial;
                        //venda.TotalVenda = venda.TotalVenda - parcial;
                        venda.TotalPago = venda.TotalPago + parcial;
                        venda.Atualiza(venda);
                        parcial = 0;
                    }

                }

                AtualizarSaldoCliente(ValorPago);
                ListarVendasDoCliente(clienteId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao Receber Vendas \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizarSaldoCliente(decimal ValorSaldoDevedorPago)
        {
            try
            {
                var Cliente = new Cliente().PesquisarPorId(clienteId);
                Cliente.SaldoDebitos -= ValorSaldoDevedorPago;
                Cliente.Atualizar(Cliente);
                ListaClientes.ListaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao Atualizar Saldo devedor do cliente \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void AbrirFormDeValorPago()
        {
            try
            {
                var InformarValorPago = new Frm_valor_cliente_pagou(this);
                InformarValorPago.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_detalhar_compra_Click(object sender, EventArgs e)
        {
            AbrirFormDetalhaVenda();
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            AbrirFormDeValorPago();
        }
    }
}
