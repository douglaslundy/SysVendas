using System;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Clientes
{
    public class ClienteDAO : ICliente
    {
        SysVendasContexto contexto;
        public ClienteDAO()
        {
            var Contexto = new SysVendasContexto();
            this.contexto = Contexto;
        }

        public void Adicionar(Cliente p)
        {
            contexto.Clientes.Add(p);
            contexto.SaveChanges();
        }

        public void Atualizar(Cliente p)
        {
            contexto.Clientes.Update(p);
            contexto.SaveChanges();
        }

        public IList<Cliente> Listar()
        {
            return 
                contexto.Clientes
                .Where(p => p.Status == true)
                .ToList();
        }

        public void Remover(Cliente p)
        {
            contexto.Clientes.Remove(p);
            contexto.SaveChanges();
        }

        public Cliente PesquisarPorId(int Id)
        {
            return contexto.Clientes.Find(Id);
        }

        public IList<Cliente> ListaClientesInadinplentes(string text)
        {
            var clientes =  contexto.Clientes
                .Where(cli => cli.Inadimplente == true && cli.Status == true);

            clientes = clientes.Where(cli => cli.NomeCompleto.Nome.Contains(text)
                || cli.NomeCompleto.Sobrenome.Contains(text));
            return clientes.ToList();
        }

        public IList<Cliente> PesquisarPorNomeOuCpf(string item)
        {
            var dados = contexto.Clientes
                .Where(p => p.Status == true);

            dados = dados
                .Where(cli => cli.NomeCompleto.Nome.Contains(item) 
                || cli.NomeCompleto.Sobrenome.Contains(item) || cli.Cpf.Numero.Contains(item));
            return dados.ToList();
        }
    }
}
