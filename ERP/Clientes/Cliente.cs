using ERP.Comum;
using ERP.ObjetosValor;
using ERP.Usuarios;
using ERP.Vendas;
using System;
using System.Collections.Generic;

namespace ERP.Clientes
{
    public class Cliente : Pessoa
    {
        public CPF Cpf { get; set; }
        public string Identidade { get; set; }
        public decimal Limite { get; set; }
        public bool Inadimplente { get; set; }
        public decimal SaldoDebitos { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string Observacao { get; set; }
        public IList<Venda> Vendas { get; set; }


        public override string ToString()
        {
            return this.NomeCompleto.ToString();
        }


        public void Salvar(Cliente cli)
        {
            var Cliente = new ClienteDAO();
            Cliente.Adicionar(cli);
        }

        public IList<Cliente> ListaClientesInadinplentes(string text)
        {
            var Cliente = new ClienteDAO();
            return Cliente.ListaClientesInadinplentes(text);
        }

        public void Atualizar(Cliente cli)
        {
            if(cli.Status == false && cli.SaldoDebitos > 0)
                 throw new Exception("O Cliente possui dívidas ativas por esse motivo não pode ser excluido");
            var Cliente = new ClienteDAO();
            Cliente.Atualizar(cli);
        }


        public void Excluir(Cliente cli)
        {
            var Cliente = new ClienteDAO();
            Cliente.Remover(cli);
        }

        public IList<Cliente> Listar()
        {
            var Cliente = new ClienteDAO();
            return Cliente.Listar();
        }

        public Cliente PesquisarPorId(int Id)
        {
            var Cliente = new ClienteDAO();
            return Cliente.PesquisarPorId(Id);
        }

        public IList<Cliente> PesquisarPorNomeOuCpf(string nome)
        {
            var Cliente = new ClienteDAO();
             return Cliente.PesquisarPorNomeOuCpf(nome);
        }
        
    }
    
}
