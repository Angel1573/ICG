using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace project
{
    public partial class InstellingToevoegen : Form
    {
        public InstellingToevoegen()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        //Voer de opslaan functie uit
        private void Opslaan_Click(object sender, EventArgs e)
        {
            ToevoegenAanDB();
        }

        //Slaat de door de gebruiker ingevoerde informatie op
        private void ToevoegenAanDB()
        {
            
            string InstellingNaam1;
            string AfdelingNaam1;
            string AfdelingNr1;
            string NaamContact1;
            string ContactNr1;
            string ContactMail1;
            string AantalPlaatsenP11;
            string AantalPlaatsenP21;

             
            InstellingNaam1 = textBox1.Text;
            AfdelingNaam1 = textBox2.Text;
            AfdelingNr1 = textBox3.Text;
            NaamContact1 = textBox4.Text;
            ContactNr1 = textBox5.Text;
            ContactMail1 = textBox6.Text;
            AantalPlaatsenP11 = textBox7.Text;
            AantalPlaatsenP21 = textBox8.Text;
            try
            {
               
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = DatabaseConnectie.DatabaseLokatie;

                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.InsertCommand = new OleDbCommand();
                adapter.InsertCommand.CommandText = ("INSERT INTO INSTELLING (InstellingNaam, AfdelingNaam, AfdelingNr, NaamContact, ContactNr, ContactMail, AantalPlaatsenP1, AantalPlaatsenP2) VALUES(\"" + InstellingNaam1 + "\", \"" + AfdelingNaam1 + "\", \"" + AfdelingNr1 + "\", \"" + NaamContact1 + "\", \"" + ContactNr1 + "\", \"" + ContactMail1 + "\", \"" + AantalPlaatsenP11 + "\", \"" + AantalPlaatsenP21 + "\")");
                
                conn.Open();


                adapter.InsertCommand.Connection = conn;
                adapter.InsertCommand.ExecuteNonQuery();
                this.Hide();
                
            }
            catch (OleDbException exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
