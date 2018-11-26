using ERP.ItensVendas;
using ERP.ObjetosValor;
using ERP.Vendas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ERP.frm
{
    public partial class Frm_deseja_imprimir_cupon : Form
    {
        Guid CodigoVenda;
        string _texto;
        public Frm_deseja_imprimir_cupon(Guid codigoVenda)
        {
            InitializeComponent();
            this.TopMost = true;
            CodigoVenda = codigoVenda;
        }


        public void carregaString()
        {
            //venda a = ctx.venda.First(b => b.codigo_venda == idVenda);
            Venda a = new Venda();
            a = a.ExibirVendaPorCodigo(CodigoVenda);

            string tipoVenda = "";

            if (a.TipoVenda == TipoVenda.A_Prazo)
            {
                tipoVenda = "A Prazo";
            }
            else
            {
                tipoVenda = "A Vista";
            }

            // imprime os dados no documento
            //Tamanho da area de impressao = "123456789-123456789-123456789-123456789-12345678"

            string texto = "            Mercearia Planalto " + "\n";
            texto += texto = "    Avenida da Felicidade Vilela N 115" + "\n";
            texto += texto = "             Bairro Jardim Planalto" + "\n";
            texto += texto = "                 (35)98467-2188" + "\n";
            texto += texto = "\n";
            texto += texto = "                Cupom Nao Fiscal" + "\n";
            texto += texto = "\n";
            texto += texto = "Venda N: " + a.Id + "\n";
            texto += texto = "Cliente:" + a.Cliente + "\n";
            texto += texto = "Tipo:" + tipoVenda + "\n";
            //Tamanho da area de impressao = "123456789-123456789-123456789-123456789-12345678"
            //Tamanho da area de impressao = 
            texto += texto = "--------------------------------------------------------\n";
            texto += texto = "\n";
            texto += texto = "Item        Produto                         " + "\n";
            texto += texto = "    Preco              Qdt                 Total" + "\n";
            texto += texto = "\n";


            //  loop imprimi produtos



            //List<produto_venda> listaProduto = ctx.produto_venda.Where(b => b.cod_venda == idVenda).ToList();

            var listaProduto = new ItensVenda().ExibirItensDaVenda(CodigoVenda);

            foreach (var produto in listaProduto)
            {
                string item = Convert.ToString(produto.NumeroItem);
                string nome = Convert.ToString(produto.Produto);
                string preco = Convert.ToString(produto.PrecoProduto);
                string qdt = Convert.ToString(produto.Quantidade);
                string total = Convert.ToString(produto.SubTotal);
                texto += string.Format("{0}{1}", item.PadRight(5, ' ').Substring(0, 4), nome.PadRight(43, ' ').Substring(0, 42) + "\n");
                texto += string.Format("    {0}{1} {2}", preco.PadRight(17, ' ').Substring(0, 17), qdt.PadRight(16, ' ').Substring(0, 14), total.PadRight(17, ' ').Substring(0, 17) + "\n");
            }


            texto += texto = "                                  " + "\n";
            texto += texto = "                                  " + "\n";
            texto += texto = "                               Desconto " + a.Desconto + "\n";
            texto += texto = "                                  Total " + a.TotalVenda + "\n";

            if (a.TipoVenda != TipoVenda.A_Prazo)
            {
                texto += texto = "                                  " + "\n";
                texto += texto = "                         Valor Pago " + a.TotalVenda + "\n";
                texto += texto = "                              Troco " + a.Troco + "\n";
            }


            if (a.TipoVenda == TipoVenda.A_Prazo)
            {
                //Tamanho da area de impressao = "123456789-123456789-123456789-123456789-12345678"
                texto += texto = "\n";
                texto += "        Vencimento " + a.DataVencimento + "\n";
                texto += texto = "\n";
                texto += " _______________________________________" + "\n";
                texto += "           Assinatura do Cliente" + "\n";
                texto += texto = "\n";
            }

            texto += texto = "        Ilicinea, " + a.DataVenda + "\n";
            texto += texto = "\n\n";
            texto += texto = "     Agradecemos a preferencia!!!\n";
            texto += texto = "            e volte sempre!!!\n";

            _texto = texto;
        }

        private void Frm_deseja_imprimir_cupon_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Dispose();
                    break;

                case Keys.F12:
                    carregaString();
                    cupom.Print();
                    break;
            }
        }


        private void cupom_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                var printDocument = sender as System.Drawing.Printing.PrintDocument;

                Font fonte = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
                SolidBrush brush = new SolidBrush(Color.Black);
                Point ponto = new Point(20, 20);


                if (printDocument != null)
                {
                    {
                        int caracteresNaPagina = 0;
                        int linhasPorPagina = 0;

                        e.Graphics.MeasureString(
                            _texto, fonte, e.MarginBounds.Size, StringFormat.GenericTypographic,
                            out caracteresNaPagina, out linhasPorPagina);

                        e.Graphics.DrawString(
                            _texto.Substring(0, caracteresNaPagina),
                            fonte,
                            brush, ponto);

                        _texto = _texto.Substring(caracteresNaPagina);

                        e.HasMorePages = _texto.Length > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            carregaString();
            cupom.Print();
        }

        private void btn_nao_imprimir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
