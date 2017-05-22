using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class Hoofdscherm : Form
    {
        public Hoofdscherm()
        {
            InitializeComponent();
            this.TopMost = true;

            this.WindowState = FormWindowState.Maximized;
            
            allesgeselecteerd();
            AlgemeenOverzicht();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            {
                Instellingen instellingen = new Instellingen();

                instellingen.Show();

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click_3(object sender, EventArgs e)
        {
            zoekbalk();
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int functie3;
        private void stagelocatiestudenten_Click(object sender, EventArgs e)
        {
            if (functie3 == 0)
            {
                stagelocatiestudenten.BackColor = Color.Green;
                functie3 = 1;
                functie2 = 0;
                functie1 = 0;
                overzichtinstellingen.BackColor = Color.White;
                Refresh.BackColor = Color.White;
                stagelocatiestudenten_Click(sender, e);
            }
            else
            {

                stagelocatie();
            }
        }

        //Knop Jaar 1

        int een = 0;
        int Knopjr1 = 0;
        private void Jaar1_Click(object sender, EventArgs e)
        {
            if (een == 0)
            {
                Jaar1.BackColor = Color.SteelBlue;
                een = 1;
                Knopjr1 = 1;
                if (Allen == 1)
                { allesgeselecteerd(); }
            }
            else
            {
                Jaar1.BackColor = Color.White;
                een = 0;
                Knopjr1 = 0;
                if (Allen == 1)
                { allesgeselecteerd(); }
            }
        }

        //knop jaar 2

        int twee;
        int Knopjr2 = 0;
        private void Jaar2_Click(object sender, EventArgs e)
        {
            if (twee == 0)
            {
                Jaar2.BackColor = Color.SteelBlue;
                twee = 1;
                Knopjr2 = 2;
                if (Allen == 1)
                { allesgeselecteerd(); }
            }
            else
            {
                Jaar2.BackColor = Color.White;
                twee = 0;
                Knopjr2 = 0;
                if (Allen == 1)
                { allesgeselecteerd(); }
            }
        }

        //knop jaar 3

        int drie;
        int Knopjr3 = 0;
        private void Jaar3_Click(object sender, EventArgs e)
        {
            if (drie == 0)
            {
                Jaar3.BackColor = Color.SteelBlue;
                drie = 1;
                Knopjr3 = 3;
                if (Allen == 1)
                { allesgeselecteerd(); }
            }
            else
            {
                Jaar3.BackColor = Color.White;
                drie = 0;
                Knopjr3 = 0;
                if (Allen == 1)
                { allesgeselecteerd(); }
            }
        }

        //Knop Jaar 4

        int vier;
        int Knopjr4 = 0;
        private void Jaar4_Click(object sender, EventArgs e)
        {
            if (vier == 0)
            {
                Jaar4.BackColor = Color.SteelBlue;
                vier = 1;
                Knopjr4 = 4;
                if (Allen == 1)
                { allesgeselecteerd(); }
            }
            else
            {
                Jaar4.BackColor = Color.White;
                vier = 0;
                Knopjr4 = 0;
                if (Allen == 1)
                { allesgeselecteerd(); }
            }
        }

        //Knop Deeltijd

        int tijd;
        int JaarDeel = 0;
        private void Deeltijd_Click(object sender, EventArgs e)
        {
            if (tijd == 0)
            {
                Deeltijd.BackColor = Color.SteelBlue;
                tijd = 1;
                JaarDeel = 5;
            }
            else
            {
                Deeltijd.BackColor = Color.White;
                tijd = 0;
                JaarDeel = 0;
            }
        }
        //Alle jaren Knop

        int Allen;
        private void Alles_Click(object sender, EventArgs e)
        {
            allesgeselecteerd();
        }
        private void allesgeselecteerd()
        {
            if (Allen == 0)
            {
                Alles.BackColor = Color.SteelBlue;
                Allen = 1;
                Jaar4.BackColor = Color.SteelBlue;
                vier = 1;
                Knopjr4 = 4;
                Deeltijd.BackColor = Color.SteelBlue;
                tijd = 1;
                JaarDeel = 5;
                Jaar3.BackColor = Color.SteelBlue;
                drie = 1;
                Knopjr3 = 3;
                Jaar2.BackColor = Color.SteelBlue;
                twee = 1;
                Knopjr2 = 2;
                Jaar1.BackColor = Color.SteelBlue;
                een = 1;
                Knopjr1 = 1;
            }
            else
            {
                Alles.BackColor = Color.White;
                Allen = 0;
                Jaar1.BackColor = Color.White;
                een = 0;
                Knopjr1 = 0;
                Jaar2.BackColor = Color.White;
                twee = 0;
                Knopjr2 = 0;
                Jaar3.BackColor = Color.White;
                drie = 0;
                Knopjr3 = 0;
                Jaar4.BackColor = Color.White;
                vier = 0;
                Knopjr4 = 0;
                Deeltijd.BackColor = Color.White;
                tijd = 0;
                JaarDeel = 0;
            }
        } 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void studenten_Click(object sender, EventArgs e)
        {
            Studenten Studenten = new Studenten();
            this.Hide();
            Studenten.Show();
        }

        private void Docenten_Click(object sender, EventArgs e)
        {
            Docenten Docenten = new Docenten();
            Docenten.Show();
        }

        private void Hoofdscherm_Load(object sender, EventArgs e)
        {}

        //Refresh knop

        int functie1;
        private void Refresh_Click_1(object sender, EventArgs e)
        {
            if (functie1 == 0)
            {
                Refresh.BackColor = Color.Green;
                functie1 = 1;
                functie2 = 0;
                functie3 = 0;
                overzichtinstellingen.BackColor = Color.White;
                stagelocatiestudenten.BackColor = Color.White;
                Refresh_Click_1(sender, e);

            }
            else
            {
                AlgemeenOverzicht();
            }
        }
       

        private void Refresh_Click_1(object sender, object e)
        {
            throw new NotImplementedException();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Overzicht van de instellingen

        int functie2;
        private void overzichtinstellingen_Click(object sender, EventArgs e)
        {
            if (functie2 == 0)
            {
                overzichtinstellingen.BackColor = Color.Green;
                functie2 = 1;
                functie1 = 0;
                functie3 = 0;
                Refresh.BackColor = Color.White;
                stagelocatiestudenten.BackColor = Color.White;
                overzichtinstellingen_Click(sender, e);

            }
            else
            {
                Bedrijven();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (functie1 == 1) { Refresh_Click_1(sender, e); }
            else
            {
                if (functie2 == 1) { overzichtinstellingen_Click(sender, e); }
                else
                { if (functie3 == 1) { stagelocatiestudenten_Click(sender, e); } else { geenoptie(); } }

            }
            
        }
        private void geenoptie()
        { MessageBox.Show("Seleceer een optie"); }
        //Algemeen Overzicht Functie
        private void AlgemeenOverzicht()
        {
            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT Student.StudentNr, Student.Voornaam, Student.AchterNaam, Klas.Klascode, Klas.Jaar, Instelling.InstellingNaam, Instelling.AfdelingNaam FROM Student, Klas, Inschrijving, Instelling WHERE Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Klas.Jaar IN (" + Knopjr1 + " , " + Knopjr2 + " , " + Knopjr3 + " , " + Knopjr4 + " , " + JaarDeel + ") ORDER BY Student.StudentNr");
            //string sql = ("SELECT * FROM klas WHERE " + Knopjr1 + " OR " + Knopjr2 + " OR " + Knopjr3 + " OR " + Knopjr4 + " OR " + JaarDeel);
            //+ " AND " + Knopjr3 + " AND " + Knopjr4 + " AND " + JaarDeel
            string myString = Knopjr2.ToString();

            //WHERE jaar =" + een + "OR" + twee + "OR" + drie);
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
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
        private void Bedrijven()
        {
            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT * FROM INSTELLING");
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
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
        private void stagelocatie()
        {
            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT Student.StudentNr, Student.Voornaam, Student.Achternaam, [Student.E-mail], Instelling.InstellingNaam, Instelling.AfdelingNaam, Instelling.AfdelingNr, Instelling.NaamContact, Instelling.ContactNr FROM Student, Instelling, Inschrijving WHERE Student.StudentNr = Inschrijving.StudentNr AND Instelling.InstellingNr = Inschrijving.InstellingNr");
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
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
        string zoekopdracht;
        private void zoekbalk()
        {
            zoekopdracht = textBox1.Text;

            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT Student.StudentNr, Student.Voornaam, Student.AchterNaam, Klas.Klascode, Klas.Jaar, Instelling.InstellingNaam, Instelling.AfdelingNaam FROM Student, Klas, Inschrijving, Instelling WHERE Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Inschrijving.StudentNr LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Student.Voornaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Student.Achternaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Klas.Klascode LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Klas.Jaar LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Instelling.Instellingnaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Instelling.AfdelingNaam LIKE \"%" + zoekopdracht + "%\" ORDER BY Student.StudentNr");
            //string sql = ("SELECT Student.StudentNr, Student.Voornaam, Student.AchterNaam, Klas.Klascode, Klas.Jaar, Instelling.InstellingNaam, Instelling.AfdelingNaam FROM Student, Klas, Inschrijving, Instelling WHERE Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Inschrijving.StudentNr LIKE *" + zoekopdracht + "* OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Student.Voornaam LIKE *" + zoekopdracht + "* OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Student.Achternaam LIKE *" + zoekopdracht + "* OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Klas.Klascode LIKE *" + zoekopdracht + "* OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Klas.Jaar LIKE *" + zoekopdracht + "* OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Instelling.Instellingnaam LIKE *" + zoekopdracht + "* OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Instelling.AfdelingNaam LIKE *" + zoekopdracht + "* ORDER BY Student.StudentNr");
            //string sql = ("SELECT Student.Voornaam, Student.AchterNaam, Klas.Klascode, Instelling.InstellingNaam, Instelling.AfdelingNaam FROM Student, Klas, Inschrijving, Instelling WHERE Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Student.Voornaam LIKE *Jac* OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Student.Achternaam LIKE *Jac* OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Klas.Klascode LIKE *Jac* OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Instelling.Instellingnaam LIKE *Jac* OR Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Instelling.AfdelingNaam LIKE *Jac* ORDER BY Student.VoorNaam; "); 
            //string sql = ("SELECT Student.Voornaam, Student.AchterNaam, Klas.Klascode, Instelling.InstellingNaam, Instelling.AfdelingNaam FROM Student, Klas, Inschrijving, Instelling WHERE Inschrijving.StudentNr = Student.StudentNr AND Student.Klascode = Klas.Klascode AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Student.Voornaam = \"Jacco\");
            //string sql = ("SELECT * FROM Instelling WHERE InstellingNaam LIKE \"%" + zoekopdracht + "%\" ");
            MessageBox.Show(sql);
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

