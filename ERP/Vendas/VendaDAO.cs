using ERP.ObjetosValor;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Vendas
{
    public class VendaDAO : IVenda
    {
        SysVendasContexto contexto;

        public VendaDAO()
        {
            var Contexto = new SysVendasContexto();
            this.contexto = Contexto;
        }

        public void Adicionar(Venda v)
        {
            contexto.Vendas.Add(v);
            contexto.SaveChanges();
        }

        public void Atualizar(Venda v)
        {
            contexto.Vendas.Update(v);
            contexto.SaveChanges();
        }

        public void Deletar(Venda v)
        {
            throw new System.NotImplementedException();
        }

        public IList<Venda> Listar()
        {
            throw new System.NotImplementedException();
        }

        public IList<Venda> ListarVendasAPrazoPorCliente(int clienteId)
        {
            return contexto.Vendas
                .Where(v => v.ClienteId == clienteId 
                    && v.TipoVenda == TipoVenda.A_Prazo && v.PagamentoRealizado == Status.Nao)
                    .ToList();
        }

        internal IList<Venda> ListarVendasAPagasPorCliente(int clienteId)
        {
            return contexto.Vendas
                .Where(v => v.ClienteId == clienteId && v.PagamentoRealizado == Status.Sim)
                    .ToList();
        }

        public Venda ExibirVendaPorCliente(int clienteId, int vendaId)
        {
             return contexto.Vendas
                .Where(v => v.ClienteId == clienteId
                    && v.Id == vendaId)
                    .Include(cli => cli.Cliente.NomeCompleto)
                        .FirstOrDefault();
        }

        public IList<Venda> ListarAll(DateTime dataInicio, DateTime dataFim)
        {
            return contexto.Vendas
                .Where(v => v.DataVenda >= dataInicio && v.DataVenda <= dataFim)
                .Include(cli => cli.Cliente.NomeCompleto)
                .Include(user => user.Usuario.NomeCompleto)
                .OrderByDescending(v => v.Id)
                .ToList();
        }

        public Venda ExibirVendaPorCodigo(Guid codigoVenda)
        {
            return contexto.Vendas
                .Where(v => v.CodigoVenda == codigoVenda)
                    .Include(cli => cli.Cliente.NomeCompleto)
                        .FirstOrDefault();
        }

        public Guid PegaCodigo(int vendaId)
        {
            return
                contexto.Vendas
                .Where(v => v.Id == vendaId).FirstOrDefault().CodigoVenda;
        }
    }
}
