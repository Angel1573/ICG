using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Inschrijving : Form
    {
        public Inschrijving()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            AlgemeenOverzicht();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            AlgemeenOverzicht();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Hoofdscherm Hfd = new Hoofdscherm();
            this.Hide();
            Hfd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AlgemeenOverzicht()
        {
           
            string Query = ("SELECT Student.StudentNr as Studentnummer, Student.Voornaam, Student.AchterNaam as Achternaam, Instelling.InstellingNaam as Instellingnaam, Instelling.AfdelingNaam, Inschrijving.Differentiatie, Inschrijving.Jaar, Inschrijving.StartDatum, Inschrijving.EindDatum FROM Student, Inschrijving, Instelling WHERE Inschrijving.StudentNr = Student.StudentNr And Inschrijving.InstellingNr = Instelling.InstellingNr");
            
            OleDbConnection connection = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(Query, connection);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                dataadapter.Fill(ds, "Klas");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Klas";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kan verbinding niet openen ! ");
            }


        }
    }
}
