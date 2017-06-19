using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace project
{
    public partial class DocentAanpassen : Form
    {
        public DocentAanpassen()
        {
            InitializeComponent();

            change();
            this.TopMost = true;
        }
        //Lokale Dims
        string DocentNr1;
        string Voornaam1;
        string Achterternaam1;
        string Email1;
        string TelefoonNr1;
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Voert opslaan uit
        private void Opslaan_Click(object sender, EventArgs e)
        {
            Opslaan3();
        }

        //Laad de inforamtie in de textboxen
        public void change()
        {
            textBox1.Text = Docenten.DocentNr;
            textBox2.Text = Docenten.Voornaam;
            textBox3.Text = Docenten.Achternaam;
            textBox4.Text = Docenten.Email;
            textBox5.Text = Docenten.TelefoonNr;
        }

        //Slaat de nieuewe informatie de door de gebruiker is ingevoerd op
        private void Opslaan3()
        {
            DataSet myDataSet;
            
            string Query;
            string myTableName;

            DocentNr1 = textBox1.Text;
            Voornaam1 = textBox2.Text;
            Achterternaam1 = textBox3.Text;
            Email1 = textBox4.Text;
            TelefoonNr1 = textBox5.Text;
            Query = ("UPDATE DOCENT SET DocentNr = \"" + DocentNr1 + "\", Voornaam = \"" + Voornaam1 + "\", AchterNaam = \"" + Achterternaam1 + "\", Email = \"" + Email1 + "\", TelefoonNr = \"" + TelefoonNr1 + "\" WHERE DocentNr = " + Docenten.DocentNr);
            MessageBox.Show(Query);
            OleDbConnection myConn = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
            myDataAdapter.SelectCommand = new OleDbCommand(Query, myConn);
            OleDbCommandBuilder custCB = new OleDbCommandBuilder(myDataAdapter);

            myConn.Open();

            DataSet custDS = new DataSet();
            myDataAdapter.Fill(custDS);
           

            myConn.Close();



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Vraagt Gebruiker of deze zeker is dat deze een record wil verwijderen
        private void Verwijderen_Click(object sender, EventArgs e)
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

        //Verwijderd de door de gebruiker geselecteerde string
        private void verwijderen()
        {
            //DataSet myDataSet;
           // string myConnection;
            string Query;
            //string myTableName;
            
            
            Query = ("DELETE * FROM DOCENT WHERE DocentNr = " + Docenten.DocentNr);
            
            OleDbConnection myConn = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
            myDataAdapter.SelectCommand = new OleDbCommand(Query, myConn);
            OleDbCommandBuilder custCB = new OleDbCommandBuilder(myDataAdapter);

            myConn.Open();

            DataSet custDS = new DataSet();
            myDataAdapter.Fill(custDS);
            MessageBox.Show(Query);

            myConn.Close();



        }




    }




}
