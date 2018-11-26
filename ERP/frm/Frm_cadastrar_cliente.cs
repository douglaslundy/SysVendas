using ERP.ObjetosValor;
using ERP.SessaoUsuario;
using System;
using System.Windows.Forms;
using ERP.Clientes;
using ERP.Usuarios;

namespace ERP.frm
{
    public partial class Frm_cadastrar_cliente : Form
    {
        int Id;
        Usuario Usuario;
        public Frm_cadastrar_cliente()
        {
            InitializeComponent();
            Usuario = new UsuarioLogado().RetornaUsuarioLogado();
        }

        private void Frm_cadastrar_cliente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F4:
                    AbrirParaEdicao(int.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString()));
                    break;

                case Keys.F10:
                    ExcluirCliente();
                    break;

                case Keys.F12:
                    CadastraCliente();
                    break;

            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            CadastraCliente();
        }
      
        public void CadastraCliente()
        {

            try {

                var cliente = new Cliente();

                if (Id == 0)
                {

                    CarregarDadosDoForm(cliente);
                    cliente.Salvar(cliente);
                    MessageBox.Show("Cliente Cadastrado com sucesso!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTextbox(this);
                    ListarClientes();
                }
                else
                {
                    cliente = cliente.PesquisarPorId(Id);
                    CarregarDadosDoForm(cliente);
                    cliente.Atualizar(cliente);
                    MessageBox.Show("Cliente Editado com sucesso!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTextbox(this);
                    ListarClientes();
                }
            }
            catch(Exception ex)
            {
                    MessageBox.Show("Houve um problema ao cadastrar o cliente \n" + ex.Message);
            }
        }

        private void CarregarDadosDoForm(Cliente cliente)
        {
            try
            {   
                var estainadimplente = false;

                if (cb_inadimplente.Text == "Sim")
                    estainadimplente = true;

                if (txt_limite.Text.Trim() == string.Empty)
                    throw new Exception("O Campo limite é obrigatório");

                cliente.NomeCompleto = NomeCompleto.Criar(txt_nome.Text, txt_sobre_nome.Text);
                cliente.Endereco = txt_endereco.Text;
                cliente.Telefone = Telefone.Criar(txt_ddd.Text, txt_telefone.Text);
                cliente.Cpf = CPF.Criar(txt_cpf.Text);
                cliente.Identidade = txt_rg.Text;
                cliente.Limite = decimal.Parse(txt_limite.Text);
                cliente.Observacao = txt_observacoes.Text;
                cliente.Inadimplente = estainadimplente;
                cliente.Status = true;
                cliente.UsuarioId = Usuario.Id;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve uma falha ao carregar dados do formulário \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbrirParaEdicao(int id)
        {
            try
            {
                var cliente = new Cliente();
                cliente = cliente.PesquisarPorId(id);
                Id = cliente.Id;
                txt_nome.Text = cliente.NomeCompleto.Nome;
                txt_sobre_nome.Text = cliente.NomeCompleto.Sobrenome;
                txt_rg.Text = cliente.Identidade;
                txt_cpf.Text = cliente.Cpf.Numero;
                txt_endereco.Text = cliente.Endereco;
                txt_ddd.Text = cliente.Telefone.Ddd;
                txt_telefone.Text = cliente.Telefone.Numero;
                txt_limite.Text = cliente.Limite.ToString();
                txt_observacoes.Text = cliente.Observacao;
                btn_excluir.Visible = true;
                btn_excluir.Enabled = true;

                if (cliente.Inadimplente)
                {
                    cb_inadimplente.Text = "Sim";
                }
                else
                {
                    cb_inadimplente.Text = "Nao";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao carregar dados do cliente \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void LimparTextbox(Control controle)
        {
            foreach(Control ctle in controle.Controls)
            {
                if(ctle is TextBox)
                {
                    ((TextBox)ctle).Text = string.Empty;
                    txt_nome.Focus();
                }
                else if(ctle.Controls.Count > 0)
                {
                    LimparTextbox(ctle);
                    txt_nome.Focus();
                }
            }
        }

        private void Frm_cadastrar_cliente_Load(object sender, EventArgs e)
        {
            Id = 0;
            ListarClientes();
        }

        private void txt_limite_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValorTotal.BloqueiaLetrasECaracteresEspeciaisMenosVirgula(sender, e);
        }

        private void txt_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            CPF.BloqueiaLetrasECaracteresEspeciais(sender, e);
        }

        private void txt_ddd_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloqueiaLetrasECaracteresEspeciais(sender, e);
        }

        private void txt_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloqueiaLetrasECaracteresEspeciais(sender, e);
        }

        public void ListarClientes()
        {
            try
            {
                Id = 0;
                var Cliente = new Cliente();
                clienteBindingSource.DataSource = Cliente.Listar();
                btn_excluir.Visible = false;
                btn_excluir.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um problema ao listar clientes \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BloqueiaLetrasECaracteresEspeciais(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            AbrirParaEdicao(int.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString()));
        }

        private void txt_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var Cliente = new Cliente();
                clienteBindingSource.DataSource = Cliente.PesquisarPorNomeOuCpf(txt_cliente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao listar clientes \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            ExcluirCliente();
        }

        public void ExcluirCliente()
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Tem Certeza que deseja Excluir o cliente?", "Excluir cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    var Cliente = new Cliente();
                    Cliente = Cliente.PesquisarPorId(Id);
                    Cliente.Status = false;
                    Cliente.Atualizar(Cliente);
                    MessageBox.Show("Cliente excluido com sucesso \n", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTextbox(this);
                    ListarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao deletar o cliente \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
