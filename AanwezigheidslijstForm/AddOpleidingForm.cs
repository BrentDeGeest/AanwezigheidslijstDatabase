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
            using (var connection = GetConnection())
            {
                using (var command = connection.CreateCommand())
                {

                    command.CommandText = $"INSERT INTO [OpleidingsInformatie] ([Opleidingsinstelling], [Opleiding], [Contactpersoon], [Opleidingsplaats], [ReferentieOpleidingsplaats], [OeNummer], [Opleidingscode], [StartDatum], [EindDatum]) VALUES (@Opleidingsinstelling, @Opleiding, @Contactpersoon, @Opleidingsplaats, @ReferentieOpleidingsplaats, @OeNummer, @Opleidingscode, @StartDatum, @EindDatum)";

                    var parameterOpInst = command.CreateParameter();
                    command.Parameters.Add(parameterOpInst);

                    parameterOpInst.ParameterName = "@Opleidingsinstelling";
                    parameterOpInst.Value = OpleidingsInstellingTextBox.Text;
                    parameterOpInst.SqlDbType = SqlDbType.NVarChar;

                    var parameterOpleiding = command.CreateParameter();
                    command.Parameters.Add(parameterOpleiding);

                    parameterOpleiding.ParameterName = "@Opleiding";
                    parameterOpleiding.Value = OpleidingTextBox.Text;
                    parameterOpleiding.SqlDbType = SqlDbType.NVarChar;

                    var parameterContactpersoon = command.CreateParameter();
                    command.Parameters.Add(parameterContactpersoon);

                    parameterContactpersoon.ParameterName = "@Contactpersoon";
                    parameterContactpersoon.Value = ContactPersoonTextBox.Text;
                    parameterContactpersoon.SqlDbType = SqlDbType.NVarChar;

                    var parameterOpleidingsplaats = command.CreateParameter();
                    command.Parameters.Add(parameterOpleidingsplaats);

                    parameterOpleidingsplaats.ParameterName = "@Opleidingsplaats";
                    parameterOpleidingsplaats.Value = OpleidingsPlaatsTextBox.Text;
                    parameterOpleidingsplaats.SqlDbType = SqlDbType.NVarChar;

                    var parameterReferentie = command.CreateParameter();
                    command.Parameters.Add(parameterReferentie);

                    parameterReferentie.ParameterName = "@ReferentieOpleidingsplaats";
                    parameterReferentie.Value = ReferentieTextBox.Text;
                    parameterReferentie.SqlDbType = SqlDbType.NVarChar;

                    var parameterOeNummer = command.CreateParameter();
                    command.Parameters.Add(parameterOeNummer);

                    parameterOeNummer.ParameterName = "@OeNummer";
                    parameterOeNummer.Value = OeNumeric.Value;
                    parameterOeNummer.SqlDbType = SqlDbType.Int;

                    var parameterOpleidingscode = command.CreateParameter();
                    command.Parameters.Add(parameterOpleidingscode);

                    parameterOpleidingscode.ParameterName = "@Opleidingscode";
                    parameterOpleidingscode.Value = OpleidingsCodeNumeric.Value;
                    parameterOpleidingscode.SqlDbType = SqlDbType.Int;

                    var parameterStartDatum = command.CreateParameter();
                    command.Parameters.Add(parameterStartDatum);

                    parameterStartDatum.ParameterName = "@StartDatum";
                    parameterStartDatum.Value = StartDatumPicker.Value;
                    parameterStartDatum.SqlDbType = SqlDbType.Date;

                    var parameterEindDatum = command.CreateParameter();
                    command.Parameters.Add(parameterEindDatum);

                    parameterEindDatum.ParameterName = "@EindDatum";
                    parameterEindDatum.Value = EindDatumPicker.Value;
                    parameterEindDatum.SqlDbType = SqlDbType.Date;

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
