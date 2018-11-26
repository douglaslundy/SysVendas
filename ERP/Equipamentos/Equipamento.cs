using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Equipamentos
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string EnderecoInstalacao { get; set; }
        public string Caid { get; set; }
        public string Cartao { get; set; }
        public int? ClienteId { get; set; }
        public bool Ativo { get; set; }


        public IList<Equipamento> ListarEquipamentosPorCliente(int clienteId)
        {
            var Equipamentos = new EquipamentoDAO();
            return Equipamentos.ListarEquipamentosPorCliente(clienteId);
        }
    }
    
}
