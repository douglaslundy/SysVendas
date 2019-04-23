using ERP.ObjetosValor;
using System;

namespace ERP.SysVendas
{
    public class SysVenda
    {
        public int Id { get; set; }
        public string Chave { get; set; }
        public DateTime DataAtivacao { get; set; }
        public DateTime DataExpira { get; set; }
        public Status DisponivelParaAtivar { get; set; }
        public Status DisponivelParaUtilizar { get; set; }
        public int Dias { get; set; }


        public void Salvar(SysVenda sys)
        {
            var SysVenda = new SysVendaDAO();
            SysVenda.Adicionar(sys);
        }

        public void Atualizar(SysVenda sys)
        {
            var SysVenda = new SysVendaDAO();
            SysVenda.Atualizar(sys);
        }

        public Boolean ValidaChave()
        {
            var sys = new SysVendaDAO();

            if (sys.verificarSeExisteChaveAtiva())
            {
                var valida = sys.PegaChavesEmUso();

                if (valida.DataExpira > DateTime.Now)
                {
                    return true;
                }
                else
                {
                    valida.DisponivelParaAtivar = Status.Nao;
                    valida.DisponivelParaUtilizar = Status.Nao;
                    sys.Atualizar(valida);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public SysVenda verificaChave(string chave)
        {
            var SysVenda = new SysVendaDAO();
            return SysVenda.verificaChave(chave);
           
        }

        public SysVenda PegaChavesEmUso()
        {
            var SysVenda = new SysVendaDAO();
            return SysVenda.PegaChavesEmUso();
        }
    }
}
