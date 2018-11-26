using System;
using System.Windows.Forms;

namespace ERP.ObjetosValor
{
    public class CPF
    {
        public string Numero { get; set; }

        public CPF()
        {

        }
        public override string ToString()
        {
            return Numero;
        }
        private CPF(string numero)
        {
            Numero = numero;
        }

        public static CPF Criar(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero))
                throw new InvalidOperationException("CPF é obrigatório");
            if (!ValidaCpf(numero))
                throw new InvalidOperationException("CPF inválido");

            return new CPF(numero);
        }


        private static bool ValidaCpf(string numero)
        {
            // validacao do cpf
            return true;
        }

        public static void BloqueiaLetrasECaracteresEspeciais(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

    }
}