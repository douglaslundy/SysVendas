using System;
using System.Collections.Generic;
using System.Linq;
using ERP.Carrinhos;

namespace ERP.Produtos
{
    public class ProdutoDAO : IProduto
    {
        SysVendasContexto contexto;
        public ProdutoDAO()
        {
            var Contexto = new SysVendasContexto();
            this.contexto = Contexto;
        }
        public void Adicionar(Produto p)
        {
            contexto.Produtos.Add(p);
            contexto.SaveChanges();
        }

        public void Atualizar(Produto p)
        {
            contexto.Produtos.Update(p);
            contexto.SaveChanges();
        }

        public void Deletar(Produto p)
        {
            contexto.Produtos.Remove(p);
            contexto.SaveChanges();
        }

        public IList<Produto> Listar()
        {
            return contexto.Produtos.ToList();
        }

        public Produto PegaProduto(string codigo)
        {
            if (contexto.Produtos.Where(p => p.CodigoProduto == codigo).Count() == 0)
                throw new Exception("Produto não cadastrado");

            return contexto.Produtos.Where(p => p.CodigoProduto == codigo).FirstOrDefault();
        }

        public IList<Produto> ListarPorEstoque(decimal v)
        {
            return contexto.Produtos.Where(p => p.Estoque <= v).ToList();
        }

        public bool VerificaSeProdutoJaCadastrado(string codigo)
        {
            if (contexto.Produtos.Where(p => p.CodigoProduto == codigo).Count() > 0)
                return true;
            return false;
        }

        public IList<Produto> PesquisaProdutosPorNome(string nome)
        {
            return contexto.Produtos.Where(p => p.NomeProduto.Contains(nome)).ToList();
        }

        public Produto PesquisaProdutoPorCodigo(string codigo)
        {
            return contexto.Produtos.Where(p => p.CodigoProduto == codigo).FirstOrDefault();
        }

        public bool VerificaSeProdutoJaFoiVendido(Produto produto)
        {
            // testar depois
            //contexto.Produtos.Where(p => p.ItensVendas.Contains(p));
            if (contexto.ItensVendas.Where(i => i.Produto == produto).Count() > 0)
                return true;
            return false;
        }

        public Produto PesquisarPorId(int id)
        {
            return contexto.Produtos.Find(id);
        }
    }
}
