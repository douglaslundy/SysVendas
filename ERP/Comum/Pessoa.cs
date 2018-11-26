using ERP.ObjetosValor;

namespace ERP.Comum
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public NomeCompleto NomeCompleto { get; set; }
        public string Endereco { get; set; }
        public Telefone Telefone { get; set; }
        public bool Status { get; set; }
    }
}
