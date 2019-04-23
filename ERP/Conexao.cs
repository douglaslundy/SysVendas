namespace ERP
{
    public class Conexao
    {
        //private const string SERVIDOR = "192.168.0.254";
        private const string SERVIDOR = "localhost";
        private const string USER = "root";
        private const string SENHA = "";
        private const string BANCO = "sisvendas";

        //public static string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DEV\\Documents\\Visual Studio 2017\\Projects\\SysVendasSolucao\\ERP\\LojaDB.mdf;Integrated Security=True";
        //public static string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=db_sistema;Persist Security Info=True;User ID=sa;Password=12345";
        //public static string ConnectionString = "Server=localhost;User Id=lundy;Password=12345;Database=sisvendas";
        public static string ConnectionString = "Server=" + SERVIDOR + ";User Id=" + USER + ";password=" + SENHA + ";database=" + BANCO;
    }

}
