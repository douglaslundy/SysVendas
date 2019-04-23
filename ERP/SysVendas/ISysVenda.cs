using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SysVendas
{
    public interface ISysVenda
    {
        void Adicionar(SysVenda s);
        void Atualizar(SysVenda s);
        void Remover(SysVenda s);
        IList<SysVenda> Listar();
    }
}
