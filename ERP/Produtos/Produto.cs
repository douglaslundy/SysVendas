using ERP.Carrinhos;
using ERP.ItensVendas;
using System;
using System.Collections.Generic;

namespace ERP.Produtos
{
    public class Produto
    {
        public int Id { get; set; }
        public string CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal PrecoPago { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal Estoque { get; set; }
        public IList<Carrinho> Carrinho { get; set; }
        public IList<ItensVenda> ItensVendas { get; set; }

        public override string ToString()
        {
            return NomeProduto;
        }

        public void Salvar(Produto produto)
        {
            var Produto = new ProdutoDAO();
            Produto.Adicionar(produto);
        }

        public void Atualizar(Produto produto)
        {
            var Produto = new ProdutoDAO();
            Produto.Atualizar(produto);
        }

        public IList<Produto> ListarPorEstoque(decimal v)
        {
            var Produto = new ProdutoDAO();
            return Produto.ListarPorEstoque(v);
        }

        public IList<Produto> Listar()
        {
            var Produtos = new ProdutoDAO();
            return Produtos.Listar();
        }
        
        public bool VerificaSeProdutoJaCadastrado(string codigo)
        {

            if (string.IsNullOrEmpty(codigo))
                throw new ArgumentException("O Código não pode estar vazio");

        var Produtos = new ProdutoDAO();
            return Produtos.VerificaSeProdutoJaCadastrado(codigo);
        }

        public IList<Produto> PesquisaProdutosPorNome(string nome)
        {
            var Produtos = new ProdutoDAO();
            return Produtos.PesquisaProdutosPorNome(nome);
        }

        public Produto PesquisaProdutoPorCodigo(string codigo)
        {
            var Produto = new ProdutoDAO();
            return Produto.PesquisaProdutoPorCodigo(codigo);
        }

        public void Deletar(Produto produto)
        {
            if (VeiricaSeProdutoJaFoiVendido(produto))
                throw new Exception("Você não pode excluir esse produto pois ele ja foi inlcuido em alguma venda");

            var Produto = new ProdutoDAO();
            Produto.Deletar(produto);
        }

        private bool VeiricaSeProdutoJaFoiVendido(Produto produto)
        {
            var Produto = new ProdutoDAO();
            return Produto.VerificaSeProdutoJaFoiVendido(produto);
        }

        public Produto PesquisarPorId(int id)
        {
            var Produto = new ProdutoDAO();
            return Produto.PesquisarPorId(id);
        }
    }
}