using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace AanwezigheidslijstForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]



        //private static SqlConnection GetConnection()
        //{
        //    var connectionStringSetting = ConfigurationManager.ConnectionStrings["Aanwezigheidslijst"];
        //    var connection = new SqlConnection(connectionStringSetting.ConnectionString);
        //    connection.StateChange += Connection_StateChange;

        //    return connection;
        //}

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
       
    }
}
