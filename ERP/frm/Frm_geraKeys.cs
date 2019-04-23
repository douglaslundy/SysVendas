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
    public partial class Frm_geraKeys : Form
    {
        public Frm_geraKeys()
        {
            InitializeComponent();
        }

        public void GeraKeys()
        {
            try
            {                
                if (textBoxDias.Text != "")
            {
                Random rdn = new Random();

                int i = 0;
                int dias = Convert.ToInt32(textBoxDias.Text);

                while (i <= 100)
                {
                    var chave = new SysVenda();
                    string chave1 = Convert.ToString(rdn.Next(DateTime.Now.Millisecond));
                    string chave2 = Convert.ToString(rdn.Next(1000, 1000000));
                    string chave3 = Convert.ToString(rdn.Next(DateTime.Now.Second));
                    string chave4 = Convert.ToString(rdn.Next(DateTime.Now.Minute));
                    string chave5 = Convert.ToString(rdn.Next(DateTime.Now.Month));
                    string chave6 = Convert.ToString(rdn.Next(DateTime.Now.Millisecond));

                    string key = Convert.ToString(DateTime.Now.Month + DateTime.Now.Millisecond + chave1 + chave2 + chave3 + chave4 + chave5 + chave6 + DateTime.Now.Second);
                    


                    chave.Chave = key;
                    chave.DisponivelParaAtivar = ObjetosValor.Status.Sim;
                    chave.Dias = dias;
                    chave.DisponivelParaUtilizar = ObjetosValor.Status.Nao;
                    //chave.Id = chave.Id + 1;

                    chave.Salvar(chave);
                    chave = null;

                    i++;
                }
                MessageBox.Show("Chaves geradas com sucesso para " + dias + " dias ");
                textBoxDias.Text = String.Empty;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Informe a validade da have em dias");
            }



            }
            catch (Exception i)
            {
                MessageBox.Show("Erro ao gerar chaves" + i.Message);
            }
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {            
                GeraKeys();            
        }

        
        private void textBoxDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void Frm_geraKeys_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.F12:
                    GeraKeys();
                    break;
            }
        }
    }
}
