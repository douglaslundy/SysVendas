using System;

namespace ERP.ObjetosValor
{
    public class NomeCompleto
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public NomeCompleto()
        {
        }
        public override string ToString()
        {
            return Nome +" "+ Sobrenome;
        }

        private NomeCompleto(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public static NomeCompleto Criar(string nome, string sobrenome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new InvalidOperationException("Nome é obrigatório");
            if (nome.Length > 100)
                throw new InvalidOperationException("Nome é longo demais");
            if (string.IsNullOrWhiteSpace(sobrenome))
                throw new InvalidOperationException("o Sobrenome é obrigatório");
            if (sobrenome.Length > 100)
                throw new InvalidOperationException("Sobrenome é longo demais");

            return new NomeCompleto(nome, sobrenome);
        }
    }
}
