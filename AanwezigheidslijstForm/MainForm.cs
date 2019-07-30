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
using System.Diagnostics;

namespace AanwezigheidslijstForm
{
    public partial class MainForm : Form
    {
        private ICollection<Deelnemers> _deelnemers;

        public MainForm()
        {
            InitializeComponent();
            _deelnemers = new List<Deelnemers>();
        }

        public static SqlConnection GetConnection()
        {
            var connectionStringSetting = ConfigurationManager.ConnectionStrings["AanwezigheidslijstDatabase"];
            var connection = new SqlConnection(connectionStringSetting.ConnectionString);
            connection.StateChange += Connection_StateChange;

            return connection;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                using (var connection = GetConnection())
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = $"SELECT [Id], [VoorNaam], [Achternaam] FROM [Deelnemers] e WHERE e.Opleiding = {OpleidingComboBox.SelectedText}"; //WHERE e.Opleiding = OpleidingComboBox.Text";

                        connection.Open();
                        using (var dataReader = command.ExecuteReader())
                        {
                            listBox1.Items.Add("Deelnemers: \n");
                            while (dataReader.Read())
                            {
                                listBox1.Items.Add(dataReader["Id"] + " - " + dataReader["VoorNaam"] + " " + dataReader["Achternaam"]);
                            }

                        }
                    }
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT [Id], [Naam], [Bedrijf] FROM [Docenten] e";

                        using (var dataReader = command.ExecuteReader())
                        {
                            listBox1.Items.Add("Docenten: \n");
                            while (dataReader.Read())
                            {
                                listBox1.Items.Add(dataReader["Id"] + " - " + dataReader["Naam"] + " - " + dataReader["Bedrijf"]);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private static void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            Console.WriteLine("\nDB connection status: " + e.CurrentState + "\n");
        }

        private void AddDeelnemerButton_Click(object sender, EventArgs e)
        {
            var addDeelnemerForm = new AddDeelnemerForm();
            addDeelnemerForm.Show();
            //if(addDeelnemerForm.DialogResult == DialogResult.OK)
            //{
            //    //_deelnemers.Add(addDeelnemerForm.Deelnemer);
            //}
        }

        private void AddOpleidingButton_Click(object sender, EventArgs e)
        {
            var addOpleidingForm = new OpleidingForm();
            addOpleidingForm.Show();
        }

        private void AddDocentButton_Click(object sender, EventArgs e)
        {
            var addDocentForm = new AddDocentForm();
            addDocentForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToonOpleidingen();
        }

        

        private void AddOplBut_Click(object sender, EventArgs e)
        {
            /*
              string firstName="Name",
        lastName="LastName",
        userName="UserName",
        password="123",
        gender="Male",
        contact="Contact";
        int age=26; 

        // Query to be executed
        string query = "Insert Into dbo.regist (FirstName, Lastname, Username, Password, Age, Gender,Contact) " + 
                   "VALUES (@FN, @LN, @UN, @Pass, @Age, @Gender, @Contact) ";

        // instance connection and command
        using(SqlConnection cn = new SqlConnection(connectionString))
        using(SqlCommand cmd = new SqlCommand(query, cn))
        {
        // add parameters and their values
        cmd.Parameters.Add("@FN", System.Data.SqlDbType.NVarChar, 100).Value = firstName;
        cmd.Parameters.Add("@LN", System.Data.SqlDbType.NVarChar, 100).Value = lastName;
        cmd.Parameters.Add("@UN", System.Data.SqlDbType.NVarChar, 100).Value = userName;
        cmd.Parameters.Add("@Pass", System.Data.SqlDbType.NVarChar, 100).Value = password;
        cmd.Parameters.Add("@Age", System.Data.SqlDbType.Int).Value = age;
        cmd.Parameters.Add("@Gender", System.Data.SqlDbType.NVarChar, 100).Value = gender;
        cmd.Parameters.Add("@Contact", System.Data.SqlDbType.NVarChar, 100).Value = contact;

        // open connection, execute command and close connection
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
              
             */







            string OpleidingsInstelling = OpleidingsInstellingTextBox.Text,
                   Opleiding = OpleidingTextBox.Text,
                   ContactPersoon = ContactPersoonTextBox.Text,
                   Opleidingsplaats = OpleidingsPlaatsTextBox.Text,
                   ReferentieOpleidingsplaats = ReferentieTextBox.Text;

            int OeNummer = (int)OeNumeric.Value,
                Opleidingscode = (int)OpleidingsCodeNumeric.Value;

            DateTime StartDatum = StartDatumPicker.Value,
                     EindDatum = EindDatumPicker.Value;

            string query = $"INSERT INTO [OpleidingsInformatie] ([Opleidingsinstelling], [Opleiding], [Contactpersoon], [Opleidingsplaats], [ReferentieOpleidingsplaats], [OeNummer], [Opleidingscode], [StartDatum], [EindDatum]) VALUES               (@Opleidingsinstelling, @Opleiding, @Contactpersoon, @Opleidingsplaats, @ReferentieOpleidingsplaats, @OeNummer, @Opleidingscode, @StartDatum, @EindDatum)";

            var connectionStringSetting = ConfigurationManager.ConnectionStrings["AanwezigheidslijstDatabase"];

            using (SqlConnection cn = new SqlConnection(connectionStringSetting.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@Opleidingsinstelling", SqlDbType.NVarChar, 100).Value = OpleidingsInstelling;
                cmd.Parameters.Add("@Opleiding", SqlDbType.NVarChar, 100).Value = Opleiding;
                cmd.Parameters.Add("@Contactpersoon", SqlDbType.NVarChar, 100).Value = ContactPersoon;
                cmd.Parameters.Add("@Opleidingsplaats", SqlDbType.NVarChar, 100).Value = Opleidingsplaats;
                cmd.Parameters.Add("@ReferentieOpleidingsplaats", SqlDbType.NVarChar, 100).Value = ReferentieOpleidingsplaats;
                cmd.Parameters.Add("@OeNummer", SqlDbType.Int).Value = OeNummer;
                cmd.Parameters.Add("@Opleidingscode", SqlDbType.Int).Value = Opleidingscode;
                cmd.Parameters.Add("@StartDatum", SqlDbType.DateTime).Value = StartDatum;
                cmd.Parameters.Add("@EindDatum", SqlDbType.DateTime).Value = EindDatum;

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                ToonOpleidingen();
            }
        }
        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opleiding = OpleidingList.SelectedItem.ToString();
            Debug.WriteLine(opleiding);
            string query = $"Select [Opleiding] from [opleidingsinformatie] where Opleiding = '{opleiding}'";

            
        }

        private void ToonOpleidingen()
        {
            var connectionStringSetting = ConfigurationManager.ConnectionStrings["AanwezigheidslijstDatabase"];

            OpleidingList.Items.Clear();
            using (var connection = new SqlConnection(connectionStringSetting.ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [Opleiding] FROM [OpleidingsInformatie]";
                    using (var dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            OpleidingList.Items.Add(dataReader["Opleiding"]);
                        }
                    }
                }
            }
        }

        private void DelOplBut_Click(object sender, EventArgs e)
        {

        }
    }
}
