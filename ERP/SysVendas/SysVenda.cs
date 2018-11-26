using ERP.ObjetosValor;
using System;

namespace ERP.SysVendas
{
    public class SysVenda
    {
        public int Id { get; set; }
        public Guid Chave { get; set; }
        public DateTime DataAtivacao { get; set; }
        public DateTime DataExpira { get; set; }
        public Status Ativa { get; set; }
        public Status Utilizada { get; set; }
        public int Dias { get; set; }
    }
}
