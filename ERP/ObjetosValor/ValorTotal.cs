using System;
using System.Windows.Forms;

namespace ERP.ObjetosValor
{
    public class ValorTotal
    {
        public decimal Valor { get; set; }

        private ValorTotal(decimal valor)
        {
            Valor = valor;
        }

        public static ValorTotal Criar(decimal valor)
        {   
            if (valor < 0)
                throw new InvalidOperationException("O valor não pode ser menor que zero");

            return new ValorTotal(valor);
        }

        public static decimal Soma(decimal valor)
        {
            if (valor < 0)
                throw new InvalidOperationException("O Valor informado não pode ser menor que zero");
            
            return valor += valor;
        }

        public static decimal Subtrai(decimal valor)
        {
            if (valor < 0)
                throw new InvalidOperationException("O Valor informado não pode ser menor que zero");

            return valor -= valor;
        }

        public static void BloqueiaLetrasECaracteresEspeciaisMenosVirgula(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

    }
}