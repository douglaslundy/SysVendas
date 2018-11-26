using ERP.frm;
using System;
using System.Windows.Forms;
using SysVendas.frm;

namespace ERP
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_inicializa());
        }
    }
}
