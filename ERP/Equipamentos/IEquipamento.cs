using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Equipamentos
{
    public interface IEquipamento
    {
        void Adicionar(Equipamento e);
        void Atualizar(Equipamento e);
        void Remover(Equipamento e);
        IList<Equipamento> Listar();
    }
}
