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
    public partial class Instellingen : Form
    {
        public Instellingen()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            instellingen();
        }

        private void Afsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Hoofdscherm Hfd = new Hoofdscherm();
            this.Hide();
            Hfd.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            instellingen();
        }
        public void instellingen()
        {
            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT * FROM Instelling");
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
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
        public static string InstellingNr;
        public static string InstellingNaam;
        public static string AfdelingNaam;
        public static string AfdelingNr;
        public static string NaamContact;
        public static string ContactNr;
        public static string AantalPlaatsenP1;
        public static string AantalPlaatsenP2;

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

        private void button1_Click(object sender, EventArgs e)
        {
            InstellingToevoegen InstToevoegen = new InstellingToevoegen();

            InstToevoegen.Show();
        }
        string zoekopdracht;
        private void zoekbalk()
        {
            zoekopdracht = textBox1.Text;

            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT * FROM Instelling WHERE InstellingNr LIKE \"%" + zoekopdracht + "%\" OR InstellingNaam LIKE \"%" + zoekopdracht + "%\" OR AfdelingNaam LIKE \"%" + zoekopdracht + "%\" OR AfdelingNr LIKE \"%" + zoekopdracht + "%\" OR NaamContact LIKE \"%" + zoekopdracht + "%\" OR ContactNr LIKE \"%" + zoekopdracht + "%\" OR AantalPlaatsenP1 LIKE \"%" + zoekopdracht + "%\" OR AantalPlaatsenP2 LIKE \"%" + zoekopdracht + "%\"");
            
            MessageBox.Show(sql);
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
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
