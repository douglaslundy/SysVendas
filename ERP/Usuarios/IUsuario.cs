using ERP.Usuarios;
using System.Collections.Generic;

namespace ERP.Usuarios
{
    public interface IUsuario
    {
        void Adicionar(Usuario p);
        void Atualizar(Usuario p);
        void Remover(Usuario p);
        IList<Usuario> Listar();
    }
}
