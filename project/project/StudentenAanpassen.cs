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
    public partial class StudentenAanpassen : Form
    {
        public StudentenAanpassen()
        {
            InitializeComponent();
            this.TopMost = true;
            change();

        }

        //loakle strings
        string StudentNr1 = "i";
        string Voornaam1;
        string Achternaam1;
        string KlasCode1;
        string Adres1;
        string Postcode1;
        string Woonplaats1;
        string TelefoonNr1;
        string MobielNr1;
        string Email1;
        string Aantal1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        public void change()
        {
            textBox1.Text = Studenten.StudentNr;
            textBox2.Text = Studenten.Voornaam;
            textBox3.Text = Studenten.Achternaam;
            textBox4.Text = Studenten.KlasCode;
            textBox5.Text = Studenten.Adres;
            textBox6.Text = Studenten.Postcode;
            textBox7.Text = Studenten.Woonplaats;
            textBox8.Text = Studenten.TelefoonNr;
            textBox9.Text = Studenten.MobielNr;
            textBox10.Text = Studenten.Email;
            textBox11.Text = Studenten.Aantal;
            // public Studenten(

        }

        private void StudentenAanpassen_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //Sluit scherm knop
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    //Voert de opslaan functie uit
        private void Opslaan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Opslaan3();
           
        }

        //Slaat de door de gebruiker ingevoerde gegevens op
        private void Opslaan3()
        {
            DataSet myDataSet;
            string myConnection;
            string Query;
            string myTableName;
            StudentNr1 = textBox1.Text;
            Voornaam1 = textBox2.Text;
            Achternaam1 = textBox3.Text;
            KlasCode1 = textBox4.Text;
            Adres1 = textBox5.Text;
            Postcode1 = textBox6.Text;
            Woonplaats1 = textBox7.Text;
            TelefoonNr1 = textBox8.Text;
            MobielNr1 = textBox9.Text;
            Email1 = textBox10.Text;
            Aantal1 = textBox11.Text;
            Query = ("UPDATE STUDENT SET StudentNr = \"" + StudentNr1 + "\", Voornaam = \"" + Voornaam1 + "\", AchterNaam = \"" + Achternaam1 + "\", KlasCode = \"" + KlasCode1 + "\", Adres = \"" + Adres1 + "\", Postcode = \"" + Postcode1 + "\", Woonplaats = \"" + Woonplaats1 + "\", TelefoonNr = \"" + TelefoonNr1 + "\", MobielNr = \"" + MobielNr1 + "\", [E-mail] = \"" + Email1 + "\", Aantal = \"" + Aantal1 + "\" WHERE StudentNr = " + Studenten.StudentNr);
            OleDbConnection myConn = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
            myDataAdapter.SelectCommand = new OleDbCommand(Query, myConn);
            OleDbCommandBuilder custCB = new OleDbCommandBuilder(myDataAdapter);
            myConn.Open();
            DataSet custDS = new DataSet();
            myDataAdapter.Fill(custDS);
            myConn.Close();
        }

        //Vraagt de gebruiker of deze zeker weet dat de records verwijder moeten worden
        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Weet u zeker dat u dit ITEM wilt verwijderen?",
                                     "Vewijderen bevestigen!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                verwijderen();
            }
            else
            {
                this.Hide();
            }
        }

        //Verwidjerd de door de gebuiker geslecteerde record
             private void verwijderen()
        {
           
            string mySelectQuery;
           
            mySelectQuery = ("DELETE * FROM STUDENT WHERE StudentNr = " + Studenten.StudentNr);

            MessageBox.Show(mySelectQuery);
            OleDbConnection myConn = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
            myDataAdapter.SelectCommand = new OleDbCommand(mySelectQuery, myConn);
            OleDbCommandBuilder custCB = new OleDbCommandBuilder(myDataAdapter);

            myConn.Open();

            DataSet custDS = new DataSet();
            myDataAdapter.Fill(custDS);
            MessageBox.Show(mySelectQuery);

         

            myConn.Close();



        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }

    }

    

