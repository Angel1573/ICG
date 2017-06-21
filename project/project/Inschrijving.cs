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
            InschrijvingToevoegen Inschrijving = new InschrijvingToevoegen();
            
            Inschrijving.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            AlgemeenOverzicht();
        }

        //Zoekfunctie
        private void button2_Click(object sender, EventArgs e)
        {
            zoekbalk();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                Inschrijving.Studentnummer = row.Cells[3].Value.ToString();
                Inschrijving.StartDatum = row.Cells[0].Value.ToString();
                Inschrijving.EindDatum = row.Cells[1].Value.ToString();
                Inschrijving.Jaar = row.Cells[2].Value.ToString();
                Inschrijving.dif = row.Cells[8].Value.ToString();
                Inschrijving.stagenummer = row.Cells[11].Value.ToString();

                InschrijvingAanpassen Aanpassen = new InschrijvingAanpassen();

                Aanpassen.Show();
            }
            catch { }
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
        public static string Studentnummer;
        public static string Docentnummer;
        public static string Instellingnummer;
        public static string StartDatum;
        public static string EindDatum;
        public static string Jaar;
        public static string dif;
        public static string stagenummer;
        

        private void AlgemeenOverzicht()
        {
           
            string Query = ("SELECT Inschrijving.StartDatum as Startdatum, Inschrijving.Einddatum, Inschrijving.Jaar as [Stage jaar], Student.StudentNr as Studentnummer, Student.Voornaam as [Voornaam student], Student.AchterNaam as [Achternaam student], Instelling.InstellingNaam as Instellingnaam, Instelling.AfdelingNaam as Afdelingnaam, Inschrijving.Differentiatie, Docent.Voornaam as [Voornaam docent], Docent.Achternaam as [Achternaam docent], Inschrijving.InschrNr as [Stage Code] FROM Student, Inschrijving, Instelling, Docent WHERE Inschrijving.StudentNr = Student.StudentNr And Inschrijving.DocentNr = Docent.DocentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr ORDER BY Inschrijving.StudentNr, Inschrijving.Jaar, Inschrijving.Startdatum");
            
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
        //Functie die zoeken op het hoofdscherm mogelijk maakt
        string zoekopdracht;
        private void zoekbalk()
        {
            zoekopdracht = textBox1.Text;
            string Query = ("SELECT Inschrijving.StartDatum as Startdatum, Inschrijving.Einddatum, Inschrijving.Jaar as [Stage jaar], Student.StudentNr as Studentnummer, Student.Voornaam as [Voornaam student], Student.AchterNaam as [Achternaam student], Instelling.InstellingNaam as Instellingnaam, Instelling.AfdelingNaam as Afdelingnaam, Inschrijving.Differentiatie, Docent.Voornaam as [Voornaam docent], Docent.Achternaam as [Achternaam docent] FROM Student, Inschrijving, Instelling, Docent WHERE Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Inschrijving.DocentNr = Docent.DocentNr AND Inschrijving.StartDatum LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Inschrijving.DocentNr = Docent.DocentNr AND Inschrijving.EindDatum LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Inschrijving.DocentNr = Docent.DocentNr AND Inschrijving.Jaar LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Inschrijving.DocentNr = Docent.DocentNr AND Inschrijving.StudentNr LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Docent.DocentNr = Inschrijving.DocentNr AND Student.Voornaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Docent.DocentNr = Inschrijving.DocentNr AND Student.Achternaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Docent.DocentNr = Inschrijving.DocentNr AND Instelling.Instellingnaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Docent.DocentNr = Inschrijving.DocentNr AND Instelling.AfdelingNaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Docent.DocentNr = Inschrijving.DocentNr AND Docent.Voornaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Docent.DocentNr = Inschrijving.DocentNr AND Docent.Achternaam LIKE \"%" + zoekopdracht + "%\" ORDER BY Student.StudentNr");
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
        private void Afsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
