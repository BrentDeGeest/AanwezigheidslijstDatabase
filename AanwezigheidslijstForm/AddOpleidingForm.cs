using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace AanwezigheidslijstForm
{
    public partial class AddOpleidingForm : Form
    {
        public AddOpleidingForm()
        {
            InitializeComponent();
        }

        public static SqlConnection GetConnection()
        {
            var connectionStringSetting = ConfigurationManager.ConnectionStrings["AanwezigheidslijstDatabase"];
            var connection = new SqlConnection(connectionStringSetting.ConnectionString);
            connection.StateChange += Connection_StateChange;

            return connection;
        }

        private void AddOpleidingButton_Click(object sender, EventArgs e)
        {

        }

        private static void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            Console.WriteLine("\nDB connection status: " + e.CurrentState + "\n");
        }
    }
}
