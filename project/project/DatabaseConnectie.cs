﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace project
{
    public partial class DatabaseConnectie : Form
    {
        public DatabaseConnectie()
        {
            InitializeComponent();
            textBox1.Text = DatabaseLokatie;
            this.TopMost = true;
        }
        string proef;
        public static string DatabaseLokatie = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
        private void button1_Click(object sender, EventArgs e)
        {
            proef = textBox1.Text;
            Proef();
        }
        public void Proef()
        {
            string ProefconnetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + proef + "";
            string sql = ("SELECT * FROM Instelling");
            OleDbConnection connection = new OleDbConnection(ProefconnetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                dataadapter.Fill(ds, "Save");
                connection.Close();
                var confirmResult = MessageBox.Show("Weet u zeker dat u deze connectie wilt gebruiken?",
                                    "Bevestigen!",
                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DatabaseConnectie.DatabaseLokatie = ProefconnetionString;
                    this.Hide();
                }
                else
                {
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kan verbinding niet openen ! ");
            }
        }

        private void DatabaseConnectie_Load(object sender, EventArgs e)
        {

        }
    }
}
