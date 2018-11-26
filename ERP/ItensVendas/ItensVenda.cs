using ERP.Produtos;
using System;
using System.Collections.Generic;

namespace ERP.ItensVendas
{
    public class ItensVenda
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int NumeroItem { get; set; }
        public decimal Quantidade { get; set; }
        public decimal PrecoProduto { get; set; }
        public decimal SubTotal { get; set; }
        public Guid CodigoVenda { get; set; }

        public void Salvar(ItensVenda item)
        {
            var Item = new ItensVendaDAO();
            Item.Adicionar(item);
        }

        public IList<ItensVenda> ExibirItensDaVenda(Guid vendaId)
        {
            return new ItensVendaDAO().ExibirItensDaVenda(vendaId);
        }

        public IList<ItensVenda> ExibirItensDaVendaPorId(int vendaId)
        {
            return new ItensVendaDAO().ExibirItensDaVendaPorId(vendaId);
        }
    }
}
