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
    public partial class AddDeelnemerForm : Form
    {
        public AddDeelnemerForm()
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

        private void AddDeelnemerButton_Click(object sender, EventArgs e)
        {
            using (var connection = GetConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $"INSERT INTO [Deelnemers] ([Voornaam], [Achternaam], [Geboortedatum], [Woonplaats], [Badgenummer]) VALUES (@Voornaam, @Achternaam, @Geboortedatum, @Woonplaats, @Badgenummer)";

                    var parameterVoornaam = command.CreateParameter();
                    command.Parameters.Add(parameterVoornaam);

                    parameterVoornaam.ParameterName = "@Voornaam";
                    parameterVoornaam.Value = VoornaamTextBox.Text;
                    parameterVoornaam.SqlDbType = SqlDbType.NVarChar;

                    var parameterAchternaam = command.CreateParameter();
                    command.Parameters.Add(parameterAchternaam);

                    parameterAchternaam.ParameterName = "@Achternaam";
                    parameterAchternaam.Value = AchternaamTextBox.Text;
                    parameterAchternaam.SqlDbType = SqlDbType.NVarChar;

                    var parameterGeboorteDatum = command.CreateParameter();
                    command.Parameters.Add(parameterGeboorteDatum);

                    parameterGeboorteDatum.ParameterName = "@Geboortedatum";
                    parameterGeboorteDatum.Value = GeboorteDatumPicker.Value;
                    parameterGeboorteDatum.SqlDbType = SqlDbType.Date;

                    var parameterWoonplaats = command.CreateParameter();
                    command.Parameters.Add(parameterWoonplaats);

                    parameterWoonplaats.ParameterName = "@Woonplaats";
                    parameterWoonplaats.Value = WoonplaatsTextBox.Text;
                    parameterWoonplaats.SqlDbType = SqlDbType.NVarChar;

                    var parameterBadgeNummer = command.CreateParameter();
                    command.Parameters.Add(parameterBadgeNummer);

                    parameterBadgeNummer.ParameterName = "@Badgenummer";
                    parameterBadgeNummer.Value = BadgeNummerPicker.Value;
                    parameterBadgeNummer.SqlDbType = SqlDbType.Int;



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
