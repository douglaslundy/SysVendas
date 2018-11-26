using ERP.Vendas;
using System.Collections.Generic;

namespace ERP.Vendas
{
    public interface IVenda
    {
        void Adicionar(Venda v);
        void Atualizar(Venda v);
        void Deletar(Venda v);
        IList<Venda> Listar();
    }
}
