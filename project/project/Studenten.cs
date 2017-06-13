using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class Studenten : Form
    {
        public Studenten()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            Student();

        }

        //Applictie brede dims
        public static string StudentNr;
        public static string Voornaam;
        public static string Achternaam;
        public static string KlasCode;
        public static string Adres;
        public static string Postcode;
        public static string Woonplaats;
        public static string TelefoonNr;
        public static string MobielNr;
        public static string Email;
        public static string Aantal;

        //Laad de info in de dims en opent het bewerkscherm
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            //textBox1.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
            Studenten.StudentNr = row.Cells[0].Value.ToString();
            Studenten.Voornaam = row.Cells[1].Value.ToString();
            Studenten.Achternaam = row.Cells[2].Value.ToString();
            Studenten.KlasCode = row.Cells[3].Value.ToString();
            Studenten.Adres = row.Cells[4].Value.ToString();
            Studenten.Postcode = row.Cells[5].Value.ToString();
            Studenten.Woonplaats = row.Cells[6].Value.ToString();
            Studenten.TelefoonNr = row.Cells[7].Value.ToString();
            Studenten.MobielNr = row.Cells[8].Value.ToString();
            Studenten.Email = row.Cells[9].Value.ToString();
            Studenten.Aantal = row.Cells[10].Value.ToString();
            StudentenAanpassen Aanpassen = new StudentenAanpassen();

            Aanpassen.Show();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Laad alggemeen overzicht van studenten
        public void Student()
        {
            string Query = ("SELECT * FROM Student");
            OleDbConnection connection = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(Query, connection);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                dataadapter.Fill(ds, "Save");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Save";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kan verbinding niet openen ! ");
            }
        }
        //private void zoeken()
       



        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Sluit de applicatie af
        private void Afsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Opend het hoofscherm
        private void Home_Click(object sender, EventArgs e)
        {
            Hoofdscherm Hfd = new Hoofdscherm();
            this.Hide();
            Hfd.Show();
        }

        private void Studenten_Load(object sender, EventArgs e)
        {

        }

        //Laat het toevoegscherm zien
        private void button1_Click(object sender, EventArgs e)
        {
            StudentenToevoegen stu = new StudentenToevoegen();
            
            stu.Show();
        }
       
        //zoekfucntie

        string zoekopdracht;
        private void zoekbalk()
        {
            zoekopdracht = textBox1.Text;

            string Query = ("SELECT * FROM Student WHERE StudentNr LIKE \"%" + zoekopdracht + "%\" OR Voornaam LIKE \"%" + zoekopdracht + "%\" OR Achternaam LIKE \"%" + zoekopdracht + "%\" OR Klascode LIKE \"%" + zoekopdracht + "%\" OR Adres LIKE \"%" + zoekopdracht + "%\" OR Postcode LIKE \"%" + zoekopdracht + "%\" OR Woonplaats LIKE \"%" + zoekopdracht + "%\" OR TelefoonNr LIKE \"%" + zoekopdracht + "%\" OR MobielNr LIKE \"%" + zoekopdracht + "%\"");
            OleDbConnection connection = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(Query, connection);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                dataadapter.Fill(ds, "Zoek");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Zoek";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kan verbinding niet openen ! ");
            }
        }

        //Voert de zoekfucntie uit
        private void button2_Click(object sender, EventArgs e)
        {
            zoekbalk();
        }

        //Refresch knop
        private void Refresh_Click(object sender, EventArgs e)
        {
            Student();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Laat zien waar diverse mensen stage lopen
        private void stagelocatie()
        {
            string Query = ("SELECT Student.StudentNr, Student.Voornaam, Student.Achternaam, [Student.E-mail], Instelling.InstellingNaam, Instelling.AfdelingNaam, Instelling.AfdelingNr, Instelling.NaamContact, Instelling.ContactNr FROM Student, Instelling, Inschrijving WHERE Student.StudentNr = Inschrijving.StudentNr AND Instelling.InstellingNr = Inschrijving.InstellingNr");
            OleDbConnection connection = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(Query, connection);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                dataadapter.Fill(ds, "Save");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Save";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kan verbinding niet openen ! ");
            }
        }

        //Voert de stagelocatie functie uit
        private void button3_Click(object sender, EventArgs e)
        {
            stagelocatie();
        }
    }
}

