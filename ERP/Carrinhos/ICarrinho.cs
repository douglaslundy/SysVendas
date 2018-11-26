using System.Collections.Generic;

namespace ERP.Carrinhos
{
    public interface ICarrinho
    {
        void Adicionar(Carrinho p);
        void Atualizar(Carrinho p);
        void Remover(Carrinho p);
        IList<Carrinho> Listar();
    }
}
