using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Balancas
{
    public class Balanca
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public int DigitoInicial { get; set; }
        public int Tamanho { get; set; }
        public int InicioCodigo { get; set; }
        public int FimCodigo { get; set; }
        public int InicioValor { get; set; }
        public int FimValor { get; set; }


        public void AtualizaBalanca(Balanca b)
        {
            var balanca = new BalancaDAO();
            balanca.Atualizar(b);
        }

        public void CadastradaBalanca(Balanca b)
        {
            var balanca = new BalancaDAO();
            balanca.Cadastrar(b);
        }

        public bool TemCadastrado()
        {
            var balanca = new BalancaDAO();
            return balanca.TemCadastrado();
        }

        public Balanca PegaDadosBalanca()
        {
            var balanca = new BalancaDAO();
            return balanca.PegaDados();
        }
    }
}
