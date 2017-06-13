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
    public partial class InstellingenAanpassen : Form
    {
        public InstellingenAanpassen()
        {
            InitializeComponent();
            change();
            this.TopMost = true;

            //Lokale Dims
        }
        string InstellingNr1;
        string InstellingNaam1;
        string AfdelingNaam1;
        string AfdelingNr1;
        string NaamContact1;
        string ContactNr1;
        string AantalPlaatsenP11;
        string AantalPlaatsenP21;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Voert de opslaan functie uit
        private void Opslaan_Click(object sender, EventArgs e)
        {
            Opslaan5();
            this.Hide();
        }

        //Laad de info in de textboxen
        public void change()
        {
            textBox1.Text = Instellingen.InstellingNr;
            textBox2.Text = Instellingen.InstellingNaam;
            textBox3.Text = Instellingen.AfdelingNaam;
            textBox4.Text = Instellingen.AfdelingNr;
            textBox5.Text = Instellingen.NaamContact;
            textBox6.Text = Instellingen.ContactNr;
            textBox7.Text = Instellingen.AantalPlaatsenP1;
            textBox8.Text = Instellingen.AantalPlaatsenP2;
        }

        //Slaat de door de gebruiker ingevoerde gegevens op
        private void Opslaan5()
        {
            
            string Query;
            
            InstellingNr1 = textBox1.Text;
            InstellingNaam1 = textBox2.Text;
            AfdelingNaam1 = textBox3.Text;
            AfdelingNr1 = textBox4.Text;
            NaamContact1 = textBox5.Text;
            ContactNr1 = textBox6.Text;
            AantalPlaatsenP11 = textBox7.Text;
            AantalPlaatsenP21 = textBox8.Text;

            Query = ("UPDATE Instelling SET InstellingNaam = \"" + InstellingNaam1 + "\", AfdelingNaam = \"" + AfdelingNaam1 + "\", AfdelingNr = \"" + AfdelingNr1 + "\", NaamContact = \"" + NaamContact1 + "\", ContactNr = \"" + ContactNr1 + "\", AantalPlaatsenP1 = \"" + AantalPlaatsenP11 + "\", AantalPlaatsenP2 = \"" + AantalPlaatsenP21 + "\" WHERE InstellingNr = " + Instellingen.InstellingNr);
            OleDbConnection myConn = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
            myDataAdapter.SelectCommand = new OleDbCommand(Query, myConn);
            OleDbCommandBuilder custCB = new OleDbCommandBuilder(myDataAdapter);

            myConn.Open();

            DataSet custDS = new DataSet();
            myDataAdapter.Fill(custDS);
           

            myConn.Close();



        }

        //Vraagt de gebruiker of deze zeker weet dat deze de record wil verijderen
        private void Verwijderen_Click(object sender, EventArgs e)
        {
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
        }

        //Verwijderd de record uit de database
        private void verwijderen()

        {
          
            string Query;
            

            
            Query = ("DELETE * FROM INSTELING WHERE InstelingtNr = " + Instellingen.InstellingNr);

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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

