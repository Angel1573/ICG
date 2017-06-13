using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace project
{
    public partial class Instellingen : Form
    {
        public Instellingen()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            instellingen();
        }

        //Afsluit knop
        private void Afsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Home knop
        private void Home_Click(object sender, EventArgs e)
        {
            Hoofdscherm Hfd = new Hoofdscherm();
            this.Hide();
            Hfd.Show();
        }

        //Refresh knop, laad overzicht opnieuw
        private void Refresh_Click(object sender, EventArgs e)
        {
            instellingen();
        }

        //Laat alle bedrijven zien, dit is het overzicht dat je ziet bij openen
        public void instellingen()
        {
            string Query = ("SELECT * FROM Instelling");
            OleDbConnection connection = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(Query, connection);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                dataadapter.Fill(ds, "Save");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Save";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kan verbinding niet openen ! ");
            }
        }

        //Applicatie brede strings
        public static string InstellingNr;
        public static string InstellingNaam;
        public static string AfdelingNaam;
        public static string AfdelingNr;
        public static string NaamContact;
        public static string ContactNr;
        public static string AantalPlaatsenP1;
        public static string AantalPlaatsenP2;

        //Laad de inforamtie uit de datagridview in diverse dims en opende het bewerkscherm
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            //textBox1.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
            Instellingen.InstellingNr = row.Cells[0].Value.ToString();
            Instellingen.InstellingNaam = row.Cells[1].Value.ToString();
            Instellingen.AfdelingNaam = row.Cells[2].Value.ToString();
            Instellingen.AfdelingNr = row.Cells[3].Value.ToString();
            Instellingen.NaamContact = row.Cells[4].Value.ToString();
            Instellingen.ContactNr = row.Cells[5].Value.ToString();
            Instellingen.AantalPlaatsenP1 = row.Cells[6].Value.ToString();
            Instellingen.AantalPlaatsenP2 = row.Cells[7].Value.ToString();

            InstellingenAanpassen instAanpassen = new InstellingenAanpassen();

            instAanpassen.Show();
        }

        //Opent het toevoeg scherm
        private void button1_Click(object sender, EventArgs e)
        {
            InstellingToevoegen InstToevoegen = new InstellingToevoegen();

            InstToevoegen.Show();
        }

        //Slaat de zoekopdracht als string op en voert de zoekopdracht uit
        string zoekopdracht;
        private void zoekbalk()
        {
            zoekopdracht = textBox1.Text;
            string Query = ("SELECT * FROM Instelling WHERE InstellingNr LIKE \"%" + zoekopdracht + "%\" OR InstellingNaam LIKE \"%" + zoekopdracht + "%\" OR AfdelingNaam LIKE \"%" + zoekopdracht + "%\" OR AfdelingNr LIKE \"%" + zoekopdracht + "%\" OR NaamContact LIKE \"%" + zoekopdracht + "%\" OR ContactNr LIKE \"%" + zoekopdracht + "%\" OR AantalPlaatsenP1 LIKE \"%" + zoekopdracht + "%\" OR AantalPlaatsenP2 LIKE \"%" + zoekopdracht + "%\"");
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

        //Voert zoekopdracht uit
        private void button2_Click(object sender, EventArgs e)
        {
            zoekbalk();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Instellingen_Load(object sender, EventArgs e)
        {

        }
        
    }

}
