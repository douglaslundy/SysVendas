using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ERP.ItensVendas
{
    public class ItensVendaDAO : IItensVenda
    {
        SysVendasContexto contexto;

        public ItensVendaDAO()
        {
            var Contexto = new SysVendasContexto();
            this.contexto = Contexto;
        }

        public void Adicionar(ItensVenda v)
        {
            contexto.ItensVendas.Add(v);
            contexto.SaveChanges();
        }

        public void Atualizar(ItensVenda v)
        {
            throw new System.NotImplementedException();
        }

        public void Deletar(ItensVenda v)
        {
            throw new System.NotImplementedException();
        }

        public IList<ItensVenda> Listar()
        {
            throw new System.NotImplementedException();
        }

        public IList<ItensVenda> ExibirItensDaVenda(Guid vendaId)
        {
            return contexto.ItensVendas
                .Where(i => i.CodigoVenda == vendaId)
                .Include(p => p.Produto).OrderByDescending(a => a.Id)
                    .ToList();
        }

        public IList<ItensVenda> ExibirItensDaVendaPorId(int vendaId)
        {
            return contexto.ItensVendas
                .Where(i => i.Id == vendaId)
                .Include(p => p.Produto).OrderByDescending(a => a.Id)
                    .ToList();
        }
    }
}
