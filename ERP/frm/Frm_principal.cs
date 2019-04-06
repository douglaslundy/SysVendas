using ERP.SessaoUsuario;
using System;
using System.Windows.Forms;
using SysVendas.frm;
using MySql.Data.MySqlClient;
using System.Net;
using BackupMySql;

namespace ERP.frm
{
    public partial class Frm_principal : Form
    {
        Frm_inicializa Login;
        public Frm_principal(Frm_inicializa login)
        {
            InitializeComponent();

            toolStripStatusLabel2.Text = DateTime.Now.ToString("dd/mm/yyyy");
            toolStripStatusLabel3.Text = "Seu sistema expira emm ";
            Login = login;
        }
        
        private void Frm_principal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        Login.Dispose();
                        break;

                    case Keys.F2:
                        AbreFormCadastrarClientes();
                        break;

                    case Keys.F3:
                        AbreFormCadastrarProdutos();
                        break;

                    case Keys.F4:
                        AbreFormCadastrarFuncionarios();
                        break;

                    case Keys.F5:
                        AbreFormEntradaEstoque();
                        break;

                    case Keys.F6:
                        AbreFormConfigBalanca();
                        break;

                    case Keys.F12:
                        AbreFormPdv();
                        break;

                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Houve um problema na ação realizada \n" + i.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormCadastrarClientes();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login.Dispose();
        }

        private void balancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormConfigBalanca();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormCadastrarProdutos();
        }

        public void AbreFormCadastrarProdutos()
        {
            try
            {
                var CadastrarProdutos = new Frm_cadastrar_produto();
                CadastrarProdutos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbreFormCadastrarClientes()
        {
            try
            { 
                var CadastrarClientes = new Frm_cadastrar_cliente();
                CadastrarClientes.Show();          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbreFormConfigBalanca()
        {
            try
            {
                var Balanca = new Frm_configura_balanca();
                Balanca.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AbreFormCadastrarFuncionarios()
        {
            try
            {
                var CadastrarFuncionarios = new Frm_cadastro_funcionarios();
                CadastrarFuncionarios.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbreFormPdv()
        {
            try
            {
                var pdv = new Frm_pdv();
                pdv.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormCadastrarFuncionarios();
        }

        private void pDVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbreFormPdv();
        }

        private void Pdv_Click(object sender, EventArgs e)
        {
            AbreFormPdv();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbreFormListaClientes();
        }

        public void AbreFormListaClientes()
        {
            try
            {
                var ListaClientes = new Frm_lista_clientes();
                ListaClientes.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AbreFormListaProdutos()
        {
            try
            {
                var Listar_todos_produtos = new Frm_listar_todos_produtos();
                Listar_todos_produtos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbreFormListaVendas()
        {
            try
            {
                var Listar_vendas = new Frm_listar_vendas();
                Listar_vendas.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbreFormEntradaEstoque()
        {
            try
            {
                var Entrada_estoque = new Frm_entrada_estoque();
                Entrada_estoque.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AbreFormEstoqueBaixo()
        {
            try
            {
                var Estoque_baixo = new Frm_estoque_baixo();
                Estoque_baixo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbreFormClientes_inadimplenteso()
        {
            try
            {
                var Clientes_inadimplentes = new Frm_clientes_inadimplentes();
                Clientes_inadimplentes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbreFormListaProdutos();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormListaVendas();
        }

        private void entradaEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormEntradaEstoque();
        }

        private void estoqueBaixoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormEstoqueBaixo();
        }

        private void clientesInadimplentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormClientes_inadimplenteso();
        }


        private void Backup_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Realizar o Backup Agora?", "Realizar Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {

                try
                {
                    //Aqui você cria a requisição
                    WebRequest request = WebRequest.Create("https://www.google.com.br/");

                    //Envia a requisição e recebe uma resposta ,  não recebendo é lançada uma exceção e o código segue pro catch
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    //Testa se o status code da resposta foi 200 ,  que é retornado quando a url está online .

                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        string mail = null;
                        Backup bkp = new Backup();
                        Frm_barra_rolagem progress = new Frm_barra_rolagem();
                        progress.Show();
                        new EnviarMail().enviarEmail();
                        mail = bkp.fazerBackup();
                        new EnviarBackupMail().enviarEmailComBackup(mail + ".zip");
                    }
                    else
                    {
                        Backup bkp = new Backup();
                        Frm_barra_rolagem progress = new Frm_barra_rolagem();
                        progress.Show();
                        bkp.fazerBackup();
                    }
                }
                catch (UriFormatException)
                {
                    Backup bkp = new Backup();
                    Frm_barra_rolagem progress = new Frm_barra_rolagem();
                    progress.Show();
                    bkp.fazerBackup();
                }
                catch (SystemException)
                {
                    Backup bkp = new Backup();
                    Frm_barra_rolagem progress = new Frm_barra_rolagem();
                    progress.Show();
                    bkp.fazerBackup();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("O Backup não pode ser realizado? " + ex.GetType(), "Erro ao realizar backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }               
    }
}
