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
    public partial class AddDocentForm : Form
    {
        public AddDocentForm()
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

        private void AddDocentButton_Click(object sender, EventArgs e)
        {
            using (var connection = GetConnection())
            {
                using (var command = connection.CreateCommand())
                {

                    command.CommandText = $"INSERT INTO [Docenten] ([Naam], [Bedrijf]) VALUES (@Naam, @Bedrijf)";

                    var parameterNaam = command.CreateParameter();
                    command.Parameters.Add(parameterNaam);

                    parameterNaam.ParameterName = "@Naam";
                    parameterNaam.Value = NaamTextBox.Text;
                    parameterNaam.SqlDbType = SqlDbType.NVarChar;

                    var parameterBedrijf = command.CreateParameter();
                    command.Parameters.Add(parameterBedrijf);

                    parameterBedrijf.ParameterName = "@Bedrijf";
                    parameterBedrijf.Value = BedrijfTextBox.Text;
                    parameterBedrijf.SqlDbType = SqlDbType.NVarChar;


                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            Close();
        }

        private static void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            Console.WriteLine("\nDB connection status: " + e.CurrentState + "\n");
        }
    }
}
