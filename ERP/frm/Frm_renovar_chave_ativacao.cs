using ERP.ObjetosValor;
using ERP.SysVendas;
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
    public partial class Frm_renovar_chave_ativacao : Form
    {
        public Frm_renovar_chave_ativacao()
        {
            InitializeComponent();
        }

        private void Frm_renovar_chave_ativacao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F12:
                    Ativar();
                    break;
            }
        }

        private void Ativar()
        {
            try
            {
                var sys = new SysVenda();

                var chave = sys.verificaChave(txt_chave.Text);

                if (chave != null)
                {
                    var dataAgora = DateTime.Now;


                    int dias = Convert.ToInt32(chave.Dias);

                    chave.DataAtivacao = DateTime.Now;
                                       
                    // ------------------------------------------------

                    var chaveAtiva = sys.PegaChavesEmUso();

                    if (chaveAtiva != null)
                    {
                        chave.DataExpira = chaveAtiva.DataExpira.AddDays(dias); ;
                        chaveAtiva.DisponivelParaAtivar = Status.Nao;
                        chaveAtiva.DisponivelParaUtilizar = Status.Nao;
                        sys.Atualizar(chaveAtiva);
                    }
                    else
                    {
                        chave.DataExpira = dataAgora.AddDays(dias);
                    }
                    
                    // ------------------------------------------------
                    
                    chave.DisponivelParaUtilizar = Status.Sim;
                    chave.DisponivelParaAtivar = Status.Nao;


                    sys.Atualizar(chave);

                    MessageBox.Show("Periodo e chave renovados com Sucesso", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Chave Inválida ", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Chave Inválida " + e.GetHashCode(), "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ativar_Click(object sender, EventArgs e)
        {
            Ativar();
        }
    }
}
