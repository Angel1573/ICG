using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace project
{
    public partial class Docententoevoegen : Form
    {
        public Docententoevoegen()
        {
            InitializeComponent();
            this.TopMost = true;

        }

        //Lokale DIms
        string DocentNr1;
        string Voornaam1;
        string Achterternaam1;
        string Email1;
        string TelefoonNr1;

       
        //Voegt de record toe aan de Database
        private void ToevoegenAanDB()
        {
            DocentNr1 = textBox1.Text;
            Voornaam1 = textBox2.Text;
            Achterternaam1 = textBox3.Text;
            Email1 = textBox4.Text;
            TelefoonNr1 = textBox5.Text;
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = DatabaseConnectie.DatabaseLokatie;
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.InsertCommand = new OleDbCommand();
                adapter.InsertCommand.CommandText = ("INSERT INTO DOCENT (DocentNr, Voornaam, Achternaam, Email, TelefoonNr) VALUES(\"" + DocentNr1 + "\", \"" + Voornaam1 + "\", \"" + Achterternaam1 + "\", \"" + Email1 + "\", \"" + TelefoonNr1 + "\")");
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

        //Voert de toevoeg functie uit
        private void Opslaan_Click(object sender, EventArgs e)
        {
            ToevoegenAanDB();
        }

        //SLuit het scherm
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Docententoevoegen_Load(object sender, EventArgs e)
        {

        }
    }


}
