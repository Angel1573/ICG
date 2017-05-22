using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class Studenten : Form
    {
        public Studenten()
        {
            InitializeComponent();
            Student();
        }
      
        string studentnummer;
       private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int rowIndex = e.RowIndex;
           DataGridViewRow row = dataGridView1.Rows[rowIndex];
           //textBox1.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
           textBox1.Text = row.Cells[0].Value.ToString();
            studentnummer = textBox1.Text;
            zoeken();
         }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Student()
        {
            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT * FROM Student");
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
        private void zoeken()
        {
            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT * FROM Student");
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
        private void DimFill()
        {
            string connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
            string sql = ("SELECT * FROM Student");
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

    }

}
        
