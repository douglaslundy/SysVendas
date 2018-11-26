using ERP.Clientes;
using ERP.Equipamentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.frm
{
    public partial class Frm_cadastro_equipamento : Form
    {
        Frm_lista_clientes ListaClientes;
        int clienteId;

        public Frm_cadastro_equipamento(Frm_lista_clientes listaClientes, int id)
        {
            InitializeComponent();
            clienteId = id;
            ListarEquipamentosPorCliente(clienteId);
            PegaCliente(clienteId);

            ListaClientes = listaClientes;
        }
        private void Frm_cadastro_equipamento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;
            }
        }


        private void ListarEquipamentosPorCliente(int clienteId)
        {
            var Equipamentos = new Equipamento().ListarEquipamentosPorCliente(clienteId);
            equipamentoBindingSource.DataSource = Equipamentos;
        }

        private void PegaCliente(int clienteId)
        {
            lb_NomeCliente.Text = new Cliente().PesquisarPorId(clienteId).NomeCompleto.ToString();
            lb_CPF.Text = new Cliente().PesquisarPorId(clienteId).Cpf.ToString();
        }
    }
}
