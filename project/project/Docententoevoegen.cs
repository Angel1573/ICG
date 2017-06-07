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
    public partial class Docententoevoegen : Form
    {
        public Docententoevoegen()
        {
            InitializeComponent();
            
        }
        string DocentNr1;
        string Voornaam1;
        string Achterternaam1;
        string Email1;
        string TelefoonNr1;

       

        private void ToevoegenAanDB()
        {
            DocentNr1 = textBox1.Text;
            Voornaam1 = textBox2.Text;
            Achterternaam1 = textBox3.Text;
            Email1 = textBox4.Text;
            TelefoonNr1 = textBox5.Text;
            try
            {
                string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = connStr;

                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.InsertCommand = new OleDbCommand();
                adapter.InsertCommand.CommandText = ("INSERT INTO DOCENT (DocentNr, Voornaam, Achternaam, [E-mail], TelefoonNr) VALUES(\"" + DocentNr1 + "\", \"" + Voornaam1 + "\", \"" + Achterternaam1 + "\", \"" + Email1 + "\", \"" + TelefoonNr1 + "\")");
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

        private void Opslaan_Click(object sender, EventArgs e)
        {
            ToevoegenAanDB();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Docententoevoegen_Load(object sender, EventArgs e)
        {

        }
    }


}
