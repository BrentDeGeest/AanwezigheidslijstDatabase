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
    public partial class MainForm : Form
    {
        private ICollection<Deelnemer> _deelnemers;

        public MainForm()
        {
            InitializeComponent();
            _deelnemers = new List<Deelnemer>();
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
                        command.CommandText = $"SELECT [Id], [VoorNaam], [Achternaam] FROM [Deelnemers] e"; //WHERE e.Opleiding = OpleidingComboBox.Text";

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
            var addOpleidingForm = new AddOpleidingForm();
            addOpleidingForm.Show();
        }

        private void AddDocentButton_Click(object sender, EventArgs e)
        {
            var addDocentForm = new AddDocentForm();
            addDocentForm.Show();
        }
    }
}
