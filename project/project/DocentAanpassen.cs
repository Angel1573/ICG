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
    public partial class DocentAanpassen : Form
    {
        public DocentAanpassen()
        {
            InitializeComponent();
            change();
        }
        string DocentNr1;
        string Voornaam1;
        string Achterternaam1;
        string Email1;
        string TelefoonNr1;
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Opslaan_Click(object sender, EventArgs e)
        {
            Opslaan3();
        }
        public void change()
        {
            textBox1.Text = Docenten.DocentNr;
            textBox2.Text = Docenten.Voornaam;
            textBox3.Text = Docenten.Achternaam;
            textBox4.Text = Docenten.Email;
            textBox5.Text = Docenten.TelefoonNr;
        }

        private void Opslaan3()
        {
            DataSet myDataSet;
            string myConnection;
            string mySelectQuery;
            string myTableName;

            DocentNr1 = textBox1.Text;
            Voornaam1 = textBox2.Text;
            Achterternaam1 = textBox3.Text;
            Email1 = textBox4.Text;
            TelefoonNr1 = textBox5.Text;

            myConnection = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            mySelectQuery = ("UPDATE DOCENT SET DocentNr = \"" + DocentNr1 + "\", Voornaam = \"" + Voornaam1 + "\", AchterNaam = \"" + Achterternaam1 + "\", [E-mail] = \"" + Email1 + "\", TelefoonNr = \"" + TelefoonNr1 + "\" WHERE DocentNr = " + Docenten.DocentNr);
            MessageBox.Show(mySelectQuery);
            OleDbConnection myConn = new OleDbConnection(myConnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
            myDataAdapter.SelectCommand = new OleDbCommand(mySelectQuery, myConn);
            OleDbCommandBuilder custCB = new OleDbCommandBuilder(myDataAdapter);

            myConn.Open();

            DataSet custDS = new DataSet();
            myDataAdapter.Fill(custDS);
            MessageBox.Show(mySelectQuery);

            //myDataAdapter.Update(custDS, "taart");

            myConn.Close();



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

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
        private void verwijderen()
        {
            DataSet myDataSet;
            string myConnection;
            string mySelectQuery;
            string myTableName;
            
            myConnection = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            mySelectQuery = ("DELETE * FROM DOCENT WHERE DocentNr = " + Docenten.DocentNr);

            MessageBox.Show(mySelectQuery);
            OleDbConnection myConn = new OleDbConnection(myConnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
            myDataAdapter.SelectCommand = new OleDbCommand(mySelectQuery, myConn);
            OleDbCommandBuilder custCB = new OleDbCommandBuilder(myDataAdapter);

            myConn.Open();

            DataSet custDS = new DataSet();
            myDataAdapter.Fill(custDS);
            MessageBox.Show(mySelectQuery);

            //myDataAdapter.Update(custDS, "taart");

            myConn.Close();



        }




    }




}
