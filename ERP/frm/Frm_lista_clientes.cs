using ERP.Clientes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ERP.frm
{
    public partial class Frm_lista_clientes : Form
    {
        public Frm_lista_clientes()
        {
            InitializeComponent();
            ListaClientes();
            txt_cliente.Focus();
        }

        private void Frm_lista_clientes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;
                case Keys.F3:
                    AbrirFormEquipamentos();
                    break;

                case Keys.F4:
                    AbrirFormListaComprasPagas();
                    break;

                case Keys.F12:
                    AbrirFormEfetuarPagamento();
                    break;
            }
        }

        private void AbrirFormListaComprasPagas()
        {
            try
            {
                var clienteId = int.Parse(dgv_clientes.CurrentRow.Cells[0].Value.ToString());
                var Form_vendasPagas = new Frm_compras_por_cliente(this, clienteId);
                Form_vendasPagas.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirFormEquipamentos()
        {
            try
            {
                var clienteId = int.Parse(dgv_clientes.CurrentRow.Cells[0].Value.ToString());
                var Form_Equipamentos = new Frm_cadastro_equipamento(this, clienteId);
                Form_Equipamentos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListaClientes()
        {
            try
            {
                var ListaDeClientes = new Cliente().Listar();
                clienteBindingSource.DataSource = ListaDeClientes;
                AtualizaTotalDebitosAReceber(ListaDeClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao listar clientes" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizaTotalDebitosAReceber(IList<Cliente> listaDeClientes)
        {
            var total = decimal.Parse("0.00");
            foreach(var dados in listaDeClientes)
            {
                total += dados.SaldoDebitos;
            }

            lb_total_debitosAReceber.Text = "Total a Receber: " + total.ToString("c");
        }

        public void ListaClientesPorNome()
        {
            try
            {
                var ListaDeClientes = new Cliente().PesquisarPorNomeOuCpf(txt_cliente.Text) ;
                clienteBindingSource.DataSource = ListaDeClientes;
                AtualizaTotalDebitosAReceber(ListaDeClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao listar clientes" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_lista_clientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            ListaClientesPorNome();
        }

        private void btn_pagar_debitos_Click(object sender, EventArgs e)
        {
            AbrirFormEfetuarPagamento();
        }


        public void AbrirFormEfetuarPagamento()
        {
            try
            {
                var clienteId = int.Parse(dgv_clientes.CurrentRow.Cells[0].Value.ToString());
                var EfetuarPagamento = new Frm_efetuar_pagamentos_compras_cliente(this, clienteId);
                EfetuarPagamento.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao montar tela \n" + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_compras_pendentes_Click(object sender, EventArgs e)
        {
            AbrirFormListaComprasPagas();
        }

        private void btn_equipamentos_Click(object sender, EventArgs e)
        {
            AbrirFormEquipamentos();
        }
    }
}
