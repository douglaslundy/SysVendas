using ERP.Clientes;
using ERP.Equipamentos;
using ERP.SessaoUsuario;
using ERP.Usuarios;
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
        int Id;
        Usuario Usuario;

        public Frm_cadastro_equipamento(Frm_lista_clientes listaClientes, int id)
        {
            InitializeComponent();
            Usuario = new UsuarioLogado().RetornaUsuarioLogado();
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
                case Keys.F4:
                    AbrirParaEdicao(int.Parse(dgv_equipamentos.CurrentRow.Cells[0].Value.ToString()));
                    break;
                case Keys.F10:
                    ExcluirEquipamento();
                    break;
                case Keys.F12:
                    CadastraEquipamento();
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

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            CadastraEquipamento();
        }

        public void CadastraEquipamento()
        {

            try
            {

                var equipamento = new Equipamento();

                if (Id == 0)
                {

                    CarregarDadosDoForm(equipamento);
                    equipamento.Salvar(equipamento);
                    MessageBox.Show("Equipamento Cadastrado com sucesso!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarEquipamentosPorCliente(clienteId);
                    LimparTextbox(this);
                }
                else
                {
                    equipamento = equipamento.PesquisarPorId(Id);
                    CarregarDadosDoForm(equipamento);
                    equipamento.Atualizar(equipamento);
                    Id = 0;
                    MessageBox.Show("Equipamento Editado com sucesso!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarEquipamentosPorCliente(clienteId);
                    LimparTextbox(this);
                    btn_excluir.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao cadastrar o equipamento \n" + ex.Message);
            }
        }


        private void CarregarDadosDoForm(Equipamento equipamento)
        {
            try
            {
                if (txt_Caid.Text.Trim() == string.Empty)
                    throw new Exception("O Campo Caid é obrigatório");

                equipamento.Caid = txt_Caid.Text;
                equipamento.Cartao = txt_Cartao.Text;
                equipamento.Ativo = true;
                equipamento.EnderecoInstalacao = txt_endereco.Text;
                equipamento.NomeUsuario = txt_usuario.Text;
                equipamento.ClienteId = clienteId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao carregar dados do formulário \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimparTextbox(Control controle)
        {
            foreach (Control ctle in controle.Controls)
            {
                if (ctle is TextBox)
                {
                    ((TextBox)ctle).Text = string.Empty;
                    txt_Caid.Focus();
                }
                else if (ctle.Controls.Count > 0)
                {
                    LimparTextbox(ctle);
                    txt_usuario.Focus();
                }
            }
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            AbrirParaEdicao(int.Parse(dgv_equipamentos.CurrentRow.Cells[0].Value.ToString()));
        }

        private void AbrirParaEdicao(int id)
        {
            try
            {
                Id = id;
                var equipamento = new Equipamento();
                equipamento = equipamento.PesquisarPorId(id);
                txt_Caid.Text = equipamento.Caid.ToString();
                txt_Cartao.Text = equipamento.Cartao.ToString();
                txt_endereco.Text = equipamento.EnderecoInstalacao.ToString();
                txt_usuario.Text = equipamento.NomeUsuario.ToString();
                btn_excluir.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao carregar dados do equipamento \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            ExcluirEquipamento();
        }

        public void ExcluirEquipamento()
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Tem Certeza que deseja Excluir o Equipamento?", "Excluir Equipamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    var equipamento = new Equipamento();
                    equipamento = equipamento.PesquisarPorId(Id);
                    equipamento.Excluir(equipamento);
                    Id = 0;
                    MessageBox.Show("Equipamento excluido com sucesso \n", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTextbox(this);
                    ListarEquipamentosPorCliente(clienteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao deletar o cliente \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
