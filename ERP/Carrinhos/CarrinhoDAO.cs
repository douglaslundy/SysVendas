using ERP.Produtos;
using ERP.SessaoUsuario;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Carrinhos
{
    public class CarrinhoDAO : ICarrinho
    {
        SysVendasContexto contexto;
        public CarrinhoDAO()
        {
            var Contexto = new SysVendasContexto();
            this.contexto = Contexto;
        }
        public void Adicionar(Carrinho p)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(Carrinho p)
        {
            contexto.Carrinhos.Update(p);
            contexto.SaveChanges();
        }

        public IList<Carrinho> Listar()
        {
            return
            contexto.Carrinhos.Where(p => p.UsuarioId == Sessao.Id)
               .Include(p => p.Produto).OrderByDescending(n => n.NumeroItem).ToList();
        }

        public void Remover(Carrinho p)
        {
            throw new System.NotImplementedException();
        }

        public int NumeroItenASerCadastrado()
        {
            return contexto.Carrinhos.Where(p => p.UsuarioId == Sessao.Id).Count() + 1;
        }

        public void RemoveTodosItens()
        {
            contexto.Carrinhos.RemoveRange(contexto.Carrinhos.Where( p =>  p.UsuarioId == Sessao.Id).ToList());
            contexto.SaveChanges();
        }

        public void InsereProdutoNoCarrinho(Carrinho produto)
        {
            contexto.Carrinhos.Add(produto);
            contexto.SaveChanges();
        }

        public void RemoveItem(int item)
        {
            if (contexto.Carrinhos.Where(p => p.NumeroItem == item && p.UsuarioId == Sessao.Id).Count() == 0)
                throw new Exception("O ítem informado não existe");

            var Item = contexto.Carrinhos.Where(p => p.NumeroItem == item && p.UsuarioId == Sessao.Id).FirstOrDefault();
            contexto.Carrinhos.Remove(Item);
            contexto.SaveChanges();
        }

        internal void AtualizarValorTotal()
        {
            throw new NotImplementedException();
        }

        public IList<Carrinho> RetornaItensASeremRenumerados(int item)
        {
            return contexto.Carrinhos.Where(p => p.NumeroItem > item && p.UsuarioId == Sessao.Id).ToList();
        }
    }
}
