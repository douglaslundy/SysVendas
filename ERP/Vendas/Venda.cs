using ERP.Clientes;
using ERP.ItensVendas;
using ERP.ObjetosValor;
using ERP.Usuarios;
using System;
using System.Collections.Generic;

namespace ERP.Vendas
{
    public class Venda
    {
        public int Id { get; set; }
        public Guid CodigoVenda { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int? ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public IList<ItensVenda> ItensVenda { get; set; }
        public decimal TotalVenda { get; set; }
        public decimal TotalPago { get; set; }
        public decimal Troco { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public TipoVenda TipoVenda { get; set; }
        public decimal Desconto { get; set; }
        public Status PagamentoRealizado { get; set; }
        public decimal PagamentoDinheiro { get; set; }
        public decimal PagamentoCartaoCredito { get; set; }
        public decimal PagamentoCartaoDebito { get; set; }
        public decimal PagamentoCheque { get; set; }

        internal object ListarVendasAPagasPorCliente(int clienteId)
        {
            var Vendas = new VendaDAO();
            return Vendas.ListarVendasAPagasPorCliente(clienteId);
        }
        
        public void Salvar(Venda venda)
        {
            var Venda = new VendaDAO();
            Venda.Adicionar(venda);
        }

        public IList<Venda> ListarVendasAPrazoPorCliente(int clienteId)
        {
            var Vendas = new VendaDAO();
            return Vendas.ListarVendasAPrazoPorCliente(clienteId);
        }

        public Venda ExibirVendaPorCliente(int clienteId, int vendaId)
        {
            return new VendaDAO().ExibirVendaPorCliente(clienteId, vendaId);
        }

        public Venda ExibirVendaPorCodigo(Guid codigoVenda)
        {
            return new VendaDAO().ExibirVendaPorCodigo(codigoVenda);
        }

        public void Atualiza(Venda venda)
        {
            var Venda = new VendaDAO();
            Venda.Atualizar(venda);
        }


        public IList<Venda> ListarAll(DateTime dataInicio, DateTime dataFim)
        {
            var Vendas = new VendaDAO();
            return Vendas.ListarAll( dataInicio,  dataFim);
        }

        public Guid PegaCodigo(int vendaId)
        {
            return new VendaDAO().PegaCodigo(vendaId);
        }
    }
}
