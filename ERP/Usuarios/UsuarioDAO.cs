using ERP.ItensVendas;
using ERP.ObjetosValor;
using ERP.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ERP.EntidadesDAO
{
    public class UsuarioDAO : IUsuario
    {
        SysVendasContexto contexto;

        public UsuarioDAO()
        {
            var Contexto = new SysVendasContexto();
            contexto = Contexto;
        }
        public void Adicionar(Usuario p)
        {
            contexto.Usuarios.Add(p);
            contexto.SaveChanges();
        }

        public void Atualizar(Usuario p)
        {
            contexto.Usuarios.Update(p);
            contexto.SaveChanges();
        }

        public IList<Usuario> Listar()
        {
            return contexto.Usuarios.Where(u => u.Status == true).ToList();
        }

        public Usuario VerificaCredenciais(string login, string senha)
        {
            if (contexto.Usuarios.Where(u => u.Login == login && u.Senha == senha && u.Status == true).Count() <= 0)
                throw new Exception("Usuario ou senha inválidos");

            return contexto.Usuarios.Where(u => u.Login == login && u.Senha == senha && u.Status == true).FirstOrDefault();
        }

        public void Remover(Usuario p)
        {
            throw new NotImplementedException();
        }

        internal bool VerificaSeUsuarioJaCadastrado(string login)
        {
            if (contexto.Usuarios.Where(p => p.Login == login && p.Status == true).Count() > 0)
                return true;
            return false;
        }

        public Usuario PesquisarPorId(int id)
        {
            return contexto.Usuarios.Find(id);
        }

        public IList<Usuario> PesquisarPorNome(string nome)
        {
            var dados = contexto.Usuarios
                .Where(u => u.Status == true);

            dados = dados
            .Where(u => u.NomeCompleto.Nome.Contains(nome) 
                || u.NomeCompleto.Sobrenome.Contains(nome)
                || u.Login.Contains(nome));
            return dados.ToList();
        }
    }
}
