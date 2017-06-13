using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project
{
    public partial class StudentenToevoegen : Form
    {
        public StudentenToevoegen()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void StudentenToevoegen_Load(object sender, EventArgs e) { }
        
        //Lokale strings
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

        //Persoon toevoegen 

        private void Opslaan_Click(object sender, EventArgs e)
        {
            ToevoegenAanDB();
            this.Close();
        }

        //Laad de info uit de textboxen in de dims en slaat de informatue io
        private void ToevoegenAanDB()
        {
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
            try
            {
                
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = DatabaseConnectie.DatabaseLokatie;

                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.InsertCommand = new OleDbCommand();
                adapter.InsertCommand.CommandText = ("INSERT INTO STUDENT (StudentNr, Voornaam, Achternaam, Klascode, Adres, Postcode, Woonplaats, TelefoonNr, MobielNr, [E-mail], Aantal) VALUES(\"" + StudentNr1 + "\", \"" + Voornaam1 + "\", \"" + Achternaam1 + "\", \"" + KlasCode1 + "\", \"" + Adres1 + "\", \"" + Postcode1 + "\", \"" + Woonplaats1 + "\", \"" + TelefoonNr1 + "\", \"" + MobielNr1 + "\", \"" + Email1 + "\", \"" + Aantal1 + "\")");
                conn.Open();
                adapter.InsertCommand.Connection = conn;
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (OleDbException exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        //Sluit knop
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}