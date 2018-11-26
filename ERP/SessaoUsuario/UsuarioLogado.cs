using ERP.ObjetosValor;
using ERP.Usuarios;

namespace ERP.SessaoUsuario
{
    public class UsuarioLogado
    {
        public Usuario RetornaUsuarioLogado()
        {
            var User = new Usuario();
                User.Id = Sessao.Id;
                User.NomeCompleto =  NomeCompleto.Criar(Sessao.Nome, Sessao.Sobrenome);
                User.Login = Sessao.Login;
                User.Senha = Sessao.Senha;
                User.Endereco = Sessao.Endereco;
                User.Telefone = Telefone.Criar(Sessao.DDD, Sessao.Telefone);
                User.Status = Sessao.Status;
            return User;
        }
    }
}
