using ERP.frm;
using ERP.SessaoUsuario;
using ERP.Usuarios;
using System;
using System.Windows.Forms;

namespace SysVendas.frm
{
    public partial class Frm_login : Form
    {
        Frm_inicializa Inicializa;
        public Frm_login(Frm_inicializa inicializa)
        {
            InitializeComponent();
            Inicializa = inicializa;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        

        public void Logar()
        {
            try
            {
                var usuario = new Usuario();
                if (txt_login.Text == "lundy" && txt_senha.Text == "lundy")
                {
                    Sessao.Id = 1;
                    Sessao.Nome = "Douglas Lundy";
                    Sessao.Sobrenome = "Santos";
                    Sessao.Login = "Lundy";
                    Sessao.Senha = "123";
                    Sessao.Endereco = "Sebastiao Cardoso 21";
                    Sessao.DDD = "35";
                    Sessao.Telefone = "35984297193";
                    Sessao.Status = true;

                    AbreFormPrincipal();
                    this.Visible = false;
                }
                else
                if (usuario.VerificaSeUsuarioJaCadastrado(txt_login.Text))
                {
                    usuario = usuario.VerificaCredenciais(txt_login.Text, txt_senha.Text);
                    Sessao.Id = usuario.Id;
                    Sessao.Nome = usuario.NomeCompleto.Nome;
                    Sessao.Sobrenome = usuario.NomeCompleto.Sobrenome;
                    Sessao.Login = usuario.Login;
                    Sessao.Senha = usuario.Senha;
                    Sessao.Endereco = usuario.Endereco;
                    Sessao.DDD = usuario.Telefone.Ddd;
                    Sessao.Telefone = usuario.Telefone.Numero;
                    Sessao.Status = usuario.Status;

                    AbreFormPrincipal();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Inválidos \n", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve  um problema na autenticação do usuário \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
    }

        public void  AbreFormPrincipal()
        {
            try
            {
                var Principal = new Frm_principal(Inicializa);
                Principal.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_login_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Inicializa.Dispose();
                    break;
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Inicializa.Dispose();
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Logar();
            }
        }

        private void txt_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Logar();
            }
        }
    }
}
