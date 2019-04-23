using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysVendas.frm;

namespace ERP.frm
{
    public partial class Frm_tela_de_bloqueio : Form
    {
        Frm_login login;

        public Frm_tela_de_bloqueio(Frm_login loginEnviado)
        {
            login = loginEnviado;
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ativar_Click(object sender, EventArgs e)
        {
            AbreFormAtivaChave();
        }

        public void AbreFormAtivaChave()
        {
        try
            {
                var Ativa = new Frm_inserir_chave_ativacao(this);
                Ativa.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void FechaFormBloqueio()
        {
            try
            {
                login.AbreFormPrincipal();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
