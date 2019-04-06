using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Balancas
{
    public class BalancaDAO : IBalanca
    {
        SysVendasContexto contexto;
        public BalancaDAO()
        {
            var Contexto = new SysVendasContexto();
            this.contexto = Contexto;
        }

        public void Atualizar(Balanca b)
        {
            contexto.Balancas.Update(b);
            contexto.SaveChanges();
        }

        internal void Cadastrar(Balanca b)
        {
            contexto.Balancas.Add(b);
            contexto.SaveChanges();
        }

        public bool TemCadastrado()
        {
            if (contexto.Balancas.Count() >= 1)
                return true;
            return false;
        }

        public Balanca PegaDados()
        {
            //return contexto.Balancas.Single();
            return contexto.Balancas.First();
        }
    }
}
