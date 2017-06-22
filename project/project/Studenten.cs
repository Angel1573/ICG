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
            allesgeselecteerd();
            Student();
           

        }

        //Applictie brede dims
        public static string StudentNr;
        public static string Voornaam;
        public static string Achternaam;
        public static string Jaar;
        public static string StudieVorm;
        public static string Adres;
        public static string Postcode;
        public static string Woonplaats;
        public static string TelefoonNr;
        public static string MobielNr;
        public static string Email;
        public static string KlasCode;
        //public static string Aantal;

        //Laad de info in de dims en opent het bewerkscherm
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                //textBox1.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
                Studenten.StudentNr = row.Cells[0].Value.ToString();
                Studenten.Voornaam = row.Cells[1].Value.ToString();
                Studenten.Achternaam = row.Cells[2].Value.ToString();
                Studenten.Jaar = row.Cells[3].Value.ToString();
                Studenten.StudieVorm = row.Cells[4].Value.ToString();
                Studenten.Adres = row.Cells[5].Value.ToString();
                Studenten.Postcode = row.Cells[6].Value.ToString();
                Studenten.Woonplaats = row.Cells[7].Value.ToString();
                Studenten.TelefoonNr = row.Cells[8].Value.ToString();
                Studenten.MobielNr = row.Cells[9].Value.ToString();
                Studenten.Email = row.Cells[10].Value.ToString();
                Studenten.KlasCode = row.Cells[11].Value.ToString();
                StudentenAanpassen Aanpassen = new StudentenAanpassen();

                Aanpassen.Show();
            }
            catch { }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Laad alggemeen overzicht van studenten
        public void Student()
        {
            string Query = ("SELECT * FROM Student WHERE Jaar In (\"" + Knopjr1 + "\", \"" + Knopjr2 + "\", \"" + Knopjr3 + "\", \"" + Knopjr4 + "\", \"" + JaarDeel + "\")");
            
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

        //Laat zien waar diverse mensen stage lopen Niet in gebruik
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

        private void Afsluiten_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int een = 0;
        int Knopjr1 = 0;
        private void Jaar1_Click(object sender, EventArgs e)
        {
            if (een == 0)
            {
                Jaar1.BackColor = Color.FromArgb(0, 55, 97);
                Jaar1.ForeColor = Color.White;
                een = 1;
                Knopjr1 = 1;
                if (Allen == 1)
                { allesgeselecteerd(); }
                Student();
            }
            else
            {
                Jaar1.BackColor = Color.White;
                Jaar1.ForeColor = Color.Black;
                een = 0;
                Knopjr1 = 0;
                if (Allen == 1)
                { allesgeselecteerd(); }
                Student();
            }
        }


      

       

        private void Alles_Click(object sender, EventArgs e)
        {


            allesgeselecteerd();
        }
       

        int twee;
        int Knopjr2 = 0;
        private void Jaar2_Click_1(object sender, EventArgs e)
        {
            if (twee == 0)
            {
                Jaar2.BackColor = Color.FromArgb(0, 55, 97);
                Jaar2.ForeColor = Color.White;
                twee = 1;
                Knopjr2 = 2;
                if (Allen == 1)
                { allesgeselecteerd(); }
                Student();
            }
            else
            {
                Jaar2.BackColor = Color.White;
                Jaar2.ForeColor = Color.Black;
                twee = 0;
                Knopjr2 = 0;
                if (Allen == 1)
                { allesgeselecteerd(); }
                Student();
            }
        }
        int drie;
        int Knopjr3 = 0;
        private void Jaar3_Click_1(object sender, EventArgs e)
        {
            if (drie == 0)
            {
                Jaar3.BackColor = Color.FromArgb(0, 55, 97);
                Jaar3.ForeColor = Color.White;
                drie = 1;
                Knopjr3 = 3;
                if (Allen == 1)
                { allesgeselecteerd(); }
                Student();
            }
            else
            {
                Jaar3.BackColor = Color.White;
                Jaar3.ForeColor = Color.Black;
                drie = 0;
                Knopjr3 = 0;
                if (Allen == 1)
                { allesgeselecteerd(); }
                Student();
            }
        }

        int vier;
        int Knopjr4 = 0;
        private void Jaar4_Click_1(object sender, EventArgs e)
        {
            if (vier == 0)
            {
                Jaar4.BackColor = Color.FromArgb(0, 55, 97);
                Jaar4.ForeColor = Color.White;
                vier = 1;
                Knopjr4 = 4;
                if (Allen == 1)
                { allesgeselecteerd(); }
                Student();
            }
            else
            {
                Jaar4.BackColor = Color.White;
                Jaar4.ForeColor = Color.Black;
                vier = 0;
                Knopjr4 = 0;
                if (Allen == 1)
                { allesgeselecteerd(); }
                Student();
            }
        }

        int tijd;
        string JaarDeel = "0";
        private void Deeltijd_Click_1(object sender, EventArgs e)
        {
            if (tijd == 0)
            {
                Deeltijd.BackColor = Color.FromArgb(0, 55, 97);
                Deeltijd.ForeColor = Color.White;
                tijd = 1;
                JaarDeel = "DT";
                Student();
            }
            else
            {
                Deeltijd.BackColor = Color.White;
                Deeltijd.ForeColor = Color.Black;
                tijd = 0;
                JaarDeel = "0";
                Student();
            }
        }

        int Allen;
        private void Alles_Click_1(object sender, EventArgs e)
        {
            allesgeselecteerd();
        }
        private void allesgeselecteerd()
        {
            if (Allen == 0)
            {
                Alles.BackColor = Color.FromArgb(0, 55, 97);
                Alles.ForeColor = Color.White;

                Allen = 1;
                Jaar4.BackColor = Color.FromArgb(0, 55, 97);
                Jaar4.ForeColor = Color.White;
                vier = 1;
                Knopjr4 = 4;
                Deeltijd.BackColor = Color.FromArgb(0, 55, 97);
                Deeltijd.ForeColor = Color.White;
                tijd = 1;
                JaarDeel = "DT";
                Jaar3.BackColor = Color.FromArgb(0, 55, 97);
                Jaar3.ForeColor = Color.White;
                drie = 1;
                Knopjr3 = 3;
                Jaar2.BackColor = Color.FromArgb(0, 55, 97);
                Jaar2.ForeColor = Color.White;
                twee = 1;
                Knopjr2 = 2;
                Jaar1.BackColor = Color.FromArgb(0, 55, 97);
                Jaar1.ForeColor = Color.White;
                een = 1;
                Knopjr1 = 1;
                Student();
            }
            else
            {
                Alles.BackColor = Color.White;
                Alles.ForeColor = Color.Black;
                Allen = 0;
                Jaar1.BackColor = Color.White;
                Jaar1.ForeColor = Color.Black;
                een = 0;
                Knopjr1 = 0;
                Jaar2.BackColor = Color.White;
                Jaar2.ForeColor = Color.Black;
                twee = 0;
                Knopjr2 = 0;
                Jaar3.BackColor = Color.White;
                Jaar3.ForeColor = Color.Black;
                drie = 0;
                Knopjr3 = 0;
                Jaar4.BackColor = Color.White;
                Jaar4.ForeColor = Color.Black;
                vier = 0;
                Knopjr4 = 0;
                Deeltijd.BackColor = Color.White;
                Deeltijd.ForeColor = Color.Black;
                tijd = 0;
                JaarDeel = "0";
               Student();
            }
        }
    }
}

