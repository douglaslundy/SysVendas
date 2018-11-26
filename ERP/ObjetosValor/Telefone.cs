using System;
using System.Text.RegularExpressions;

namespace ERP.ObjetosValor
{
    public class Telefone
    {
        public string Ddd { get; set; }
        public string Numero { get; set; }

        public Telefone()
        {

        }
        public override string ToString()
        {
            return "("+Ddd+")" + Numero;
        }

        private Telefone(string ddd, string numero)
        {
            Ddd = ddd;
            Numero = numero;
        }

        public static Telefone Criar(string ddd, string numero)
        {
            if (string.IsNullOrWhiteSpace(ddd))
                throw new InvalidOperationException("DDD é obrigatório");

            if (string.IsNullOrWhiteSpace(numero))
                throw new InvalidOperationException("Telefone é obrigatório");

            if (ValidaTelefone(ddd, numero))
                throw new InvalidOperationException("Telefone inválido");

            return new Telefone(ddd, numero);
        }


        private static bool ValidaTelefone(string ddd, string numero)
        {
            var telefone = $"{ddd}{numero}";

            var regexPattern = @"^[1-9]{2} [2-9][0-9]{7,8}$";
            var matches = Regex.Match(telefone, regexPattern);

            return matches.Success;
        }
        
    }
}
