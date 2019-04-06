using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Balancas
{
    public interface IBalanca
    {
        void Atualizar(Balanca b);
        Balanca PegaDados();
    }
}
