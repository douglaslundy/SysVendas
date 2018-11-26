using System;
using System.Collections.Generic;
using ERP.Produtos;
using ERP.Usuarios;

namespace ERP.Carrinhos
{
    public class Carrinho
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int NumeroItem { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal SubTotal { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public void InsereProdutoNoCarrinho(Carrinho carrinho)
        {
            var Carrinho = new CarrinhoDAO();
            Carrinho.InsereProdutoNoCarrinho(carrinho);
        }

        public int NumeroItenASerCadastrado()
        {
            var Carrinho = new CarrinhoDAO();
            return Carrinho.NumeroItenASerCadastrado();
        }

        public IList<Carrinho> Listar()
        {
            var Carrinho = new CarrinhoDAO();
            return Carrinho.Listar();
        }

        public void RemoveTodosItens()
        {
            var Carrinho = new CarrinhoDAO();
            Carrinho.RemoveTodosItens();
        }

        public void RemoveItem(int item)
        {
            var Carrinho = new CarrinhoDAO();
            Carrinho.RemoveItem(item);
        }

        public IList<Carrinho> RetornaItensASeremRenumerados(int item)
        {
            var Carrinho = new CarrinhoDAO();
            return Carrinho.RetornaItensASeremRenumerados(item);
        }

        public decimal AtualizarValorTotal()
        {
            decimal total = decimal.Parse("0,00");
            var Carrinho = new CarrinhoDAO();

            foreach (var valor in Carrinho.Listar())
            {
                total += valor.SubTotal;
            }

            return total;
        }

        public void AtualizaNumeroDosItens(IList<Carrinho> itens)
        {
            var Carrinho = new CarrinhoDAO();

            foreach (var dado in itens)
            {
                dado.NumeroItem = dado.NumeroItem -1;
                Carrinho.Atualizar(dado);
            }            
        }
    }
}
