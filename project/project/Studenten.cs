﻿using System;
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
            InitializeComponent();
            Student();

        }
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
        public void Student()
        {
            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT * FROM Student");
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
        private void zoeken()
        {
            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT * FROM Student");
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



        private void DimFill()
        {
            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT * FROM Student");
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet gegevens = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                dataadapter.Fill(gegevens, "lijst");
                connection.Close();
                dt = gegevens.Tables["Klaas"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kan verbinding niet openen ! ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Afsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Hoofdscherm Hfd = new Hoofdscherm();
            this.Hide();
            Hfd.Show();
        }

        private void Studenten_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentenToevoegen stu = new StudentenToevoegen();
            
            stu.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            zoekbalk();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Student();
        }
    }
}

