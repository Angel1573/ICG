using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace project
{
    public partial class InschrijvingToevoegen : Form
    {
        public InschrijvingToevoegen()
        {
            InitializeComponent();
        }

        //Variabelen
        string zoekopdracht;
        int Optie = 1;
        string informatie;

    
        private void ZoekStudent_Click(object sender, EventArgs e)
        {
            Optie = 1;
            ZoekStudenten();
            textBox8.Text = "";
        }
        private void ZoekDocent_Click(object sender, EventArgs e)
        {
            Optie = 2;
            ZoekDocenten();
            textBox8.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Optie = 3;
            ZoekInstellingen();
            textBox8.Text = "";
        }

        private void Opslaan_Click(object sender, EventArgs e)
        {
            ToevoegenAanDB();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
           informatie = row.Cells[0].Value.ToString();

            if (Optie == 1)
            {
            textBox1.Text = informatie;
            }
            if (Optie == 2)
            {
                textBox2.Text = informatie;
            }
            if (Optie == 3)
            {
                textBox3.Text = informatie;
            }
        }

        private void ToevoegenAanDB()
        {
            string Studentnummer = textBox1.Text;
            string Docentnummer = textBox2.Text;
            string Instellingnummer = textBox3.Text;
            string StartDatum = textBox4.Text;
            string EindDatum = textBox5.Text;
            string Jaar = textBox6.Text;
            string dif = textBox7.Text;
            string Query = ("INSERT INTO Inschrijving(StudentNr, DocentNr, InstellingNr, StartDatum, EindDatum, Jaar, Differentiatie) VALUES(\"" + Studentnummer + "\", \"" + Docentnummer + "\", \"" + Instellingnummer + "\", \"" + StartDatum + "\", \"" + EindDatum + "\", \"" + Jaar + "\", \"" + dif + "\")");
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = DatabaseConnectie.DatabaseLokatie;
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.InsertCommand = new OleDbCommand();
               
                adapter.InsertCommand.CommandText = Query;
              
                conn.Open();
                adapter.InsertCommand.Connection = conn;
                adapter.InsertCommand.ExecuteNonQuery();
                
                this.Hide();
            }
            catch (OleDbException exp)
            {
                MessageBox.Show(Query);
                MessageBox.Show(exp.ToString());
            }
        }

        private void ZoekStudenten()
        {
            zoekopdracht = textBox8.Text;
            string Query = ("SELECT StudentNr as Studentnummer, Voornaam, Achternaam FROM Student WHERE StudentNr LIKE \"%" + zoekopdracht + "%\" OR Voornaam LIKE \"%" + zoekopdracht + "%\" OR Achternaam LIKE \"%" + zoekopdracht + "%\" ORDER BY Achternaam");
            OleDbConnection connection = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(Query, connection);
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

       
        private void ZoekInstellingen()
        {
            zoekopdracht = textBox8.Text;
            string Query = ("SELECT InstellingNr as Instellingnummer, InstellingNaam as [Naam instelling], Afdelingnaam FROM Instelling WHERE InstellingNr LIKE \"%" + zoekopdracht + "%\" OR Instellingnaam LIKE \"%" + zoekopdracht + "%\" OR Afdelingnaam LIKE \"%" + zoekopdracht + "%\" ORDER BY Instellingnaam");
            OleDbConnection connection = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(Query, connection);
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
        private void ZoekDocenten()
        {
            zoekopdracht = textBox8.Text;
            string Query = ("SELECT DocentNr as Docentnummer, Voornaam, Achternaam FROM DOCENT WHERE DocentNr LIKE \"%" + zoekopdracht + "%\" OR Voornaam LIKE \"%" + zoekopdracht + "%\" OR Achternaam LIKE \"%" + zoekopdracht + "%\" ORDER BY Achternaam");
            OleDbConnection connection = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(Query, connection);
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

        
    }
}
