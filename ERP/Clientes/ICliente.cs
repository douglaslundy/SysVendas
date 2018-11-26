using System.Collections.Generic;

namespace ERP.Clientes
{
    public interface ICliente
    {
        void Adicionar(Cliente p);
        void Atualizar(Cliente p);
        void Remover(Cliente p);
        IList<Cliente> Listar();
    }
}
