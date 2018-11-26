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
            throw new NotImplementedException();
        }

        public void Atualizar(Equipamento e)
        {
            throw new NotImplementedException();
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
    }
}
