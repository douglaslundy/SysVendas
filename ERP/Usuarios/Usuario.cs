using ERP.Carrinhos;
using ERP.Clientes;
using ERP.Comum;
using ERP.EntidadesDAO;
using ERP.ItensVendas;
using ERP.Vendas;
using System;
using System.Collections.Generic;

namespace ERP.Usuarios
{
    public class Usuario : Pessoa
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public IList<Venda> Vendas { get; set; }
        public IList<Cliente> Clientes { get; set; }
        public IList<Carrinho> Carrinho { get; set; }

        public override string ToString()
        {
            return this.Login.ToString();
        }

        public Usuario VerificaCredenciais(string login, string senha)
        {
            var Usuario = new UsuarioDAO();
            return Usuario.VerificaCredenciais(login, senha);
        }

        public void Salvar(Usuario usuario)
        {
            var Usuario = new UsuarioDAO();
            Usuario.Adicionar(usuario);
        }
        public IList<Usuario> Listar()
        {
            var Usuarios = new UsuarioDAO();
            return Usuarios.Listar();
        }

        public bool VerificaSeUsuarioJaCadastrado(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new Exception("Insira o login do novo funcionário");

            var Usuario = new UsuarioDAO();
            return Usuario.VerificaSeUsuarioJaCadastrado(login);
        }

        public Usuario PesquisarPorId(int id)
        {
            var funcionarioDAO = new UsuarioDAO();
            return funcionarioDAO.PesquisarPorId(id);
        }

        internal void Atualizar(Usuario funcionario)
        {
            var funcionarioDAO = new UsuarioDAO();
            funcionarioDAO.Atualizar(funcionario);
        }

        public IList<Usuario> PesquisarPorNome(string nome)
        {
            var Usuario = new UsuarioDAO();
            return Usuario.PesquisarPorNome(nome);
        }
    }
}