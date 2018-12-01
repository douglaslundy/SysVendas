using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Equipamentos
{
    class EquipamentoDAO : IEquipamento
    {
        SysVendasContexto contexto;

        public EquipamentoDAO()
        {
            var Contexto = new SysVendasContexto();
            this.contexto = Contexto;
        }

        public void Adicionar(Equipamento e)
        {
            contexto.Equipamentos.Add(e);
            contexto.SaveChanges();
        }

        public void Atualizar(Equipamento e)
        {
            contexto.Equipamentos.Update(e);
            contexto.SaveChanges();
        }

        public IList<Equipamento> Listar()
        {
            throw new NotImplementedException();
        }

        public void Remover(Equipamento e)
        {
            throw new NotImplementedException();
        }

        public IList<Equipamento> ListarEquipamentosPorCliente(int clienteId)
        {
            return contexto.Equipamentos
                .Where(v => v.ClienteId == clienteId).ToList();
        }

        public Equipamento PesquisarPorId(int id)
        {
            //return contexto.Equipamentos.Where(e => e.Id == id).First();
            return contexto.Equipamentos.Find(id);
        }

        public void Excluir(Equipamento equipamento)
        {
            contexto.Equipamentos.Remove(equipamento);
            contexto.SaveChanges();
        }
    }
}
