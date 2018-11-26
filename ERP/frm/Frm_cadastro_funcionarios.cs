using ERP.ObjetosValor;
using ERP.Usuarios;
using System;
using System.Windows.Forms;

namespace ERP.frm
{
    public partial class Frm_cadastro_funcionarios : Form
    {
        int Id; 
        public Frm_cadastro_funcionarios()
        {
            InitializeComponent();
        }

        private void Frm_cadastro_funcionarios_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        Dispose();
                        break;

                    case Keys.F4:
                        AbrirParaEdicao(int.Parse(dgv_funcionarios.CurrentRow.Cells[0].Value.ToString()));
                        break;

                    case Keys.F10:
                        ExcluirFuncionario();
                        break;

                    case Keys.F12:
                        CadastraFuncionarios();
                        break;
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Houve um problema na ação realizada \n" + i.Message);
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            CadastraFuncionarios();
        }

        public void CadastraFuncionarios()
        {
            try
            {
                var funcionario = new Usuario();

                if (Id == 0)
                {
                    CarregarDadosDoForm(funcionario);
                    funcionario.Salvar(funcionario);
                    MessageBox.Show("Funconário cadastrado com sucesso", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTextbox(this);
                    Fechaform();
                    Listar_funcionarios();
                    txt_login.Focus();
                }
                else
                {
                    funcionario = funcionario.PesquisarPorId(Id);
                    CarregarDadosDoForm(funcionario);
                    funcionario.Atualizar(funcionario);
                    MessageBox.Show("Funconário Editado com sucesso", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTextbox(this);
                    Fechaform();
                    Listar_funcionarios();
                    txt_login.Focus();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um problema ao cadastrar funcionario \n" + ex.Message);
            }
        }

        public void CarregarDadosDoForm(Usuario funcionario)
        {
            if (string.IsNullOrWhiteSpace(txt_login.Text))
                throw new Exception("O campo Login é obrigatório");
            if (string.IsNullOrWhiteSpace(txt_senha.Text))
                throw new Exception("O campo Senha é obrigatório");
            if (string.IsNullOrWhiteSpace(txt_nome.Text))
                throw new Exception("O campo Nome é obrigatório");
            if (string.IsNullOrWhiteSpace(txt_nome.Text))
                throw new Exception("O campo Sobrenome é obrigatório");
            if (string.IsNullOrWhiteSpace(txt_ddd.Text))
                throw new Exception("O campo DDD é obrigatório");
            if (string.IsNullOrWhiteSpace(txt_telefone.Text))
                throw new Exception("O campo Telefone é obrigatório");
            if (string.IsNullOrWhiteSpace(txt_endereco.Text))
                throw new Exception("O campo Endereço é obrigatório");


            funcionario.NomeCompleto = NomeCompleto.Criar(txt_nome.Text, txt_sobre_nome.Text);
            funcionario.Login = txt_login.Text;
            funcionario.Senha = txt_senha.Text;
            funcionario.Endereco = txt_endereco.Text;
            funcionario.Telefone = Telefone.Criar(txt_ddd.Text, txt_telefone.Text);
            funcionario.Status = true;
        }

        public void LimparTextbox(Control controle)
        {
            foreach (Control ctle in controle.Controls)
            {
                if (ctle is TextBox)
                {
                    ((TextBox)ctle).Text = string.Empty;
                }
                else if (ctle.Controls.Count > 0)
                {
                    LimparTextbox(ctle);
                }
            }
        }

        private void txt_ddd_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloqueiaLetrasECaracteresEspeciais(sender, e);
        }

        private void txt_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloqueiaLetrasECaracteresEspeciais(sender, e);
        }

        public void BloqueiaLetrasECaracteresEspeciais(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
        public void Fechaform()
        {
            txt_login.Enabled = true;
            txt_ddd.Enabled = false;
            txt_nome.Enabled = false;
            txt_senha.Enabled = false;
            txt_endereco.Enabled = false;
            txt_sobre_nome.Enabled = false;
            txt_telefone.Enabled = false;
            txt_login.Focus();
            btn_excluir.Visible = false;
        }


        public void Abreform()
        {
            txt_ddd.Enabled = true;
            txt_nome.Enabled = true;
            txt_senha.Enabled = true;
            txt_endereco.Enabled = true;
            txt_sobre_nome.Enabled = true;
            txt_telefone.Enabled = true;
        }

        private void Frm_cadastro_funcionarios_Load(object sender, EventArgs e)
        {
            Id = 0;
            Listar_funcionarios();
            txt_login.Focus();
        }

        private void Listar_funcionarios()
        {
            try
            {
                Id = 0;
                var Usuarios = new Usuario();
                usuarioBindingSource.DataSource = Usuarios.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao listar usuarios \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_login_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                var User = new Usuario();

                if (txt_login.Text.Length > 2)
                {
                    Abreform();
                    labelUsuarioDisponivel.Text = "Usuário Disponível...";

                    if (User.VerificaSeUsuarioJaCadastrado(txt_login.Text))
                    {
                        Fechaform();
                        labelUsuarioDisponivel.Text = "Usuário Indisponível...";
                    }
                }
                else
                {
                    Fechaform();
                    labelUsuarioDisponivel.Text = "Informe um usuário válido";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao listar usuarios \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_abrir_edicao_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirParaEdicao(int.Parse(dgv_funcionarios.CurrentRow.Cells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao selecionar Funcionario \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AbrirParaEdicao(int id)
        {
            try
            {
                var funcionario = new Usuario();
                funcionario = funcionario.PesquisarPorId(id);
                AbreformEdicao();
                txt_login.Text = funcionario.Login;
                txt_senha.Text = funcionario.Senha;
                txt_nome.Text = funcionario.NomeCompleto.Nome;
                txt_sobre_nome.Text = funcionario.NomeCompleto.Sobrenome;
                txt_ddd.Text = funcionario.Telefone.Ddd;
                txt_telefone.Text = funcionario.Telefone.Numero;
                txt_endereco.Text = funcionario.Endereco;
                btn_excluir.Visible = true;
                Id = funcionario.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao carregar dados do funcionario \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AbreformEdicao()
        {
            txt_login.Enabled = false;
            txt_ddd.Enabled = true;
            txt_nome.Enabled = true;
            txt_senha.Enabled = true;
            txt_endereco.Enabled = true;
            txt_sobre_nome.Enabled = true;
            txt_telefone.Enabled = true;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            ExcluirFuncionario();
        }

        private void ExcluirFuncionario()
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Tem Certeza que deseja Excluir o funcionário?", "Excluir funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    var funcionario = new Usuario();
                    funcionario = funcionario.PesquisarPorId(Id);
                    funcionario.Status = false;
                    funcionario.Atualizar(funcionario);
                    MessageBox.Show("Funcionario excluido com sucesso \n", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTextbox(this);
                    Fechaform();
                    Listar_funcionarios();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve uma falha ao deletar o funcionario \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_funcionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var Funcionario = new Usuario();
                usuarioBindingSource.DataSource = Funcionario.PesquisarPorNome(txt_funcionario.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao listar funcionários \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
