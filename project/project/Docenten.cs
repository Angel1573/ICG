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
    public partial class Docenten : Form
    {
        public Docenten()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            Docent();
        }
        public static string DocentNr;
        public static string Voornaam;
        public static string Achternaam;
        public static string TelefoonNr;
        public static string Email;





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Laad alggemeen overzicht van studenten
        public void Docent()
        {
            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT * FROM Docent");
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
        //private void zoeken()




        private void DimFill()
        {
            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT * FROM Student");
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet gegevens = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                dataadapter.Fill(gegevens, "lijst");
                connection.Close();
                dt = gegevens.Tables["Klaas"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kan verbinding niet openen ! ");
            }
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

        private void Studenten_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //zoekfucntie

        string zoekopdracht;
        private void zoekbalk()
        {
            zoekopdracht = textBox1.Text;

            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT * FROM Docent WHERE DocentNr LIKE \"%" + zoekopdracht + "%\" OR Voornaam LIKE \"%" + zoekopdracht + "%\" OR Achternaam LIKE \"%" + zoekopdracht + "%\" OR [E-mail] LIKE \"%" + zoekopdracht + "%\" OR TelefoonNr LIKE \"%" + zoekopdracht + "%\"");
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

        private void Refresh_Click(object sender, EventArgs e)
        {
            Docent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Docententoevoegen DocToe = new Docententoevoegen();

            DocToe.Show();
        }

        private void Home_Click_1(object sender, EventArgs e)
        {
            Hoofdscherm Hfd = new Hoofdscherm();
            this.Hide();
            Hfd.Show();
        }

        private void Refresh_Click_1(object sender, EventArgs e)
        {
            Docent();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            Docenten.DocentNr = row.Cells[0].Value.ToString();
            Docenten.Voornaam = row.Cells[1].Value.ToString();
            Docenten.Achternaam = row.Cells[2].Value.ToString();
            Docenten.Email = row.Cells[3].Value.ToString();
            Docenten.TelefoonNr = row.Cells[4].Value.ToString();

            DocentAanpassen DocAanpassen = new DocentAanpassen();
            DocAanpassen.Show();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            zoekbalk();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Docenten_Load(object sender, EventArgs e)
        {

        }
    }

}

  


