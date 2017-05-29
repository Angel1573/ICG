using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project
{
    public partial class StudentenToevoegen : Form
    {
        public StudentenToevoegen()
        {
            InitializeComponent();
        }

        private void StudentenToevoegen_Load(object sender, EventArgs e)
        {

        }
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

        private void toevoegen()
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
                string connetionString;
                string sql;
                SqlConnection connection;
                SqlDataAdapter adapter = new SqlDataAdapter();
                
                connetionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Gerbrand/Desktop/Database.accdb";
                connection = new SqlConnection(connetionString);
                sql = ("INSERT INTO STUDENT (StudentNr, Voornaam, Achternaam, Klascode, Adres, Postcode, Woonplaats, TelefoonNr, MobielNr, [E-mail], Aantal) VALUES(\"" + StudentNr1 + "\", \"" + Voornaam1 + "\", \"" + Achternaam1 + "\", \"" + KlasCode1 + "\", \"" + Adres1 + "\", \"" + Postcode1 + "\", \"" + Woonplaats1 + "\", \"" + TelefoonNr1 + "\", \"" + MobielNr1 + "\", \"" + Email1 + "\", \"" + Aantal1 + ""); 

                try
                {
                    connection.Open();
                    MessageBox.Show(sql);
                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    adapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Row inserted !! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            

        }

        private void Opslaan_Click(object sender, EventArgs e)
        {
            toevoegen();
        }
    }

}