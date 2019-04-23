using ERP.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SysVendas
{
    public class SysVendaDAO : ISysVenda
    {

        SysVendasContexto contexto;
        public SysVendaDAO()
        {
            var Contexto = new SysVendasContexto();
            this.contexto = Contexto;
        }


        public void Adicionar(SysVenda s)
        {
            contexto.Sysvendas.Add(s);
            contexto.SaveChanges();
        }

        public void Atualizar(SysVenda s)
        {
            contexto.Sysvendas.Update(s);
            contexto.SaveChanges();
        }

        public IList<SysVenda> Listar()
        {
            throw new NotImplementedException();
        }

        public Boolean verificarSeExisteChaveAtiva()
        {
            var contador = contexto.Sysvendas.Where(a => a.DisponivelParaAtivar == Status.Nao && a.DisponivelParaUtilizar == Status.Sim).Count();

            if (contador > 0)
                return true;
            else
               return false;
        }

        public SysVenda PegaChavesEmUso()
        {
           return contexto.Sysvendas.Where(a => a.DisponivelParaAtivar == Status.Nao && a.DisponivelParaUtilizar == Status.Sim).SingleOrDefault();
        }

        public void Remover(SysVenda s)
        {
            contexto.Sysvendas.Remove(s);
            contexto.SaveChanges();
        }

        public SysVenda verificaChave(string chave)
        {
            return contexto.Sysvendas.First(a => a.Chave == chave & a.DisponivelParaUtilizar == Status.Nao & a.DisponivelParaAtivar == Status.Sim);
            
        }
    }
}
