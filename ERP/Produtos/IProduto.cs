using System.Collections.Generic;

namespace ERP.Produtos
{
    public interface IProduto
    {
        void Adicionar(Produto v);
        void Atualizar(Produto v);
        void Deletar(Produto v);
        IList<Produto> Listar();
    }
}
