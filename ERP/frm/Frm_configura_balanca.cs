using ERP.Balancas;
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
    public partial class Frm_configura_balanca : Form
    {
        
        public Frm_configura_balanca()
        {
            InitializeComponent();
            CarregarForm();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            AtualizarBalanca();
        }

        private void AtualizarBalanca()
        {
            try
            {
                var balanca = new Balanca();

                if (balanca.TemCadastrado())
                {
                    balanca = balanca.PegaDadosBalanca();

                    CarregarDadosDoForm(balanca);
                    balanca.AtualizaBalanca(balanca);
                    MessageBox.Show("Balanca atualizada com sucesso!");
                    this.Close();
                }
                else
                {
                    CarregarDadosDoForm(balanca);
                    balanca.CadastradaBalanca(balanca);
                    MessageBox.Show("Balanca atualizada com sucesso!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro - " + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CarregarForm()
        {
            Balanca balanca = new Balanca().PegaDadosBalanca();

            chkHabilitar.Checked = balanca.Ativo;
            txt_digito_inicial.Text = balanca.DigitoInicial.ToString();
            txt_tamanho_total.Text = balanca.Tamanho.ToString();
            txt_inicio_codigo.Text = balanca.InicioCodigo.ToString();
            txt_fim_codigo.Text = balanca.FimCodigo.ToString();
            txt_inicio_peso_ou_valor.Text =balanca.InicioValor.ToString();
            txt_fim_peso_ou_valor.Text = balanca.FimValor.ToString();

        }

        public void CarregarDadosDoForm(Balanca balanca)
        {
            
            if (string.IsNullOrWhiteSpace(txt_digito_inicial.Text))
                throw new ArgumentException("Digito Inicial é obrigatório");

            if (string.IsNullOrWhiteSpace(txt_tamanho_total.Text))
                throw new ArgumentException("Tamanho total é obrigatório");

            if (string.IsNullOrWhiteSpace(txt_inicio_codigo.Text))
                throw new ArgumentException("Inicio do código é obrigatório");

            if (string.IsNullOrWhiteSpace(txt_fim_codigo.Text))
                throw new ArgumentException("Fim do código é obrigatório");

            if (string.IsNullOrWhiteSpace(txt_inicio_peso_ou_valor.Text))
                throw new ArgumentException("Inicio do peso é obrigatório");

            if (string.IsNullOrWhiteSpace(txt_fim_peso_ou_valor.Text))
                throw new ArgumentException("Fim do peso ou valor é obrigatório");


            balanca.Ativo = chkHabilitar.Checked;
            balanca.DigitoInicial = int.Parse(txt_digito_inicial.Text);
            balanca.Tamanho = int.Parse(txt_tamanho_total.Text);
            balanca.InicioCodigo = int.Parse(txt_inicio_codigo.Text);
            balanca.FimCodigo = int.Parse(txt_fim_codigo.Text);
            balanca.InicioValor = int.Parse(txt_inicio_peso_ou_valor.Text);
            balanca.FimValor = int.Parse(txt_fim_peso_ou_valor.Text);
        }

        private void Frm_configura_balanca_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;
                case Keys.F12:
                    AtualizarBalanca();
                    break;

            }
        }
    }
}
