using System.Collections.Generic;

namespace ERP.ItensVendas
{
    public interface IItensVenda
    {
        void Adicionar(ItensVenda v);
        void Atualizar(ItensVenda v);
        void Deletar(ItensVenda v);
        IList<ItensVenda> Listar();
    }
}
