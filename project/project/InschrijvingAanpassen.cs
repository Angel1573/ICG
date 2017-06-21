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
    public partial class InschrijvingAanpassen : Form
    {
        public InschrijvingAanpassen()
        {
            InitializeComponent();
            change();
            this.TopMost = true;
        }

        string Studentnummer;
        string Docentnummer;
        string Instellingnummer;
        string StartDatum;
        string EindDatum;
        string Jaar;
        string dif; 

        public void change()
        {
            
        textBox1.Text = Inschrijving.Studentnummer;
            textBox2.Text = Inschrijving.Docentnummer;
            textBox3.Text = Inschrijving.Instellingnummer;
            textBox4.Text = Inschrijving.StartDatum;
            textBox5.Text = Inschrijving.EindDatum;
            textBox6.Text = Inschrijving.Jaar;
            textBox7.Text = Inschrijving.dif;
       
        }

        private void Opslaan_Click(object sender, EventArgs e)
        {
            OpslaanAan();
        }
        private void OpslaanAan()
        {

            string Query = "i";
            string QueryXL = "i";
            string QueryXXL = "i";
            string QueryM = "i";
            string QueryXS = "i";
            int Optie = 0;

            Studentnummer = textBox1.Text;
            Docentnummer = textBox2.Text;
            Instellingnummer = textBox3.Text;
            StartDatum = textBox4.Text;
            EindDatum = textBox5.Text;
            Jaar = textBox6.Text;
            dif = textBox7.Text;

            QueryXL = ("UPDATE INSCHRIJVING SET StudentNr = \"" + Studentnummer + "\", InstellingNr = \"" + Instellingnummer + "\", StartDatum = \"" + StartDatum + "\", EindDatum = \"" + EindDatum + "\", Jaar = \"" + Jaar + "\", Differentiatie = \"" + dif + "\" WHERE InschrNr = " + Inschrijving.stagenummer);
            QueryXXL = ("UPDATE INSCHRIJVING SET StudentNr = \"" + Studentnummer + "\", DocentNr = \"" + Docentnummer + "\", InstellingNr = \"" + Instellingnummer + "\", StartDatum = \"" + StartDatum + "\", EindDatum = \"" + EindDatum + "\", Jaar = \"" + Jaar + "\", Differentiatie = \"" + dif + "\" WHERE InschrNr = " + Inschrijving.stagenummer);
            QueryM = ("UPDATE INSCHRIJVING SET StudentNr = \"" + Studentnummer + "\", DocentNr = \"" + Docentnummer + "\", StartDatum = \"" + StartDatum + "\", EindDatum = \"" + EindDatum + "\", Jaar = \"" + Jaar + "\", Differentiatie = \"" + "\" WHERE InschrNr = " + Inschrijving.stagenummer);
            QueryXS = ("UPDATE INSCHRIJVING SET StudentNr = \"" + Studentnummer + "\", StartDatum = \"" + StartDatum + "\", EindDatum = \"" + EindDatum + "\", Jaar = \"" + Jaar + "\", Differentiatie = \"" + dif + "\" WHERE InschrNr = " + Inschrijving.stagenummer);


            if (String.IsNullOrEmpty(textBox2.Text))
            {
                Optie = 1;
            }

            if (String.IsNullOrEmpty(textBox3.Text))
            {
                Optie = 2;
            }
            if (String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox2.Text))
            {
                Optie = 3;
            }

            //Query if's
            if (Optie == 0)
            {
                //Alles
                Query = QueryXXL;
            }
            if (Optie == 1)
            {
                //minus docentnummer
                Query = QueryXL;
            }
            if (Optie == 2)
            {
                //minus instelling
                Query = QueryM;
            }
            if (Optie == 3)
            {
                //minus beide
                Query = QueryXS;
            }

         

            
             


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
        //Verwijderd de record uit de database
        private void verwijderen()

        {

            string Query;

            Query = ("DELETE * FROM INSCHRIJVING WHERE InschrNr= " + Inschrijving.stagenummer);

            OleDbConnection myConn = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
            myDataAdapter.SelectCommand = new OleDbCommand(Query, myConn);
            OleDbCommandBuilder custCB = new OleDbCommandBuilder(myDataAdapter);

            myConn.Open();

            DataSet custDS = new DataSet();
            myDataAdapter.Fill(custDS);


            myConn.Close();




        }
    }
}
