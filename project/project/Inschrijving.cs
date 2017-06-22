﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Windows.Forms;
using System.Drawing;

namespace project
{
    public partial class Inschrijving : Form
    {
        public Inschrijving()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
             allesgeselecteerd();
            AlgemeenOverzicht();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InschrijvingToevoegen Inschrijving = new InschrijvingToevoegen();
            
            Inschrijving.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            AlgemeenOverzicht();
        }

        //Zoekfunctie
        private void button2_Click(object sender, EventArgs e)
        {
            zoekbalk();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                Inschrijving.Studentnummer = row.Cells[3].Value.ToString();
                Inschrijving.StartDatum = row.Cells[0].Value.ToString();
                Inschrijving.EindDatum = row.Cells[1].Value.ToString();
                Inschrijving.Jaar = row.Cells[2].Value.ToString();
                Inschrijving.dif = row.Cells[8].Value.ToString();
                Inschrijving.stagenummer = row.Cells[11].Value.ToString();

                InschrijvingAanpassen Aanpassen = new InschrijvingAanpassen();

                Aanpassen.Show();
            }
            catch { }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Hoofdscherm Hfd = new Hoofdscherm();
            this.Hide();
            Hfd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public static string Studentnummer;
        public static string Docentnummer;
        public static string Instellingnummer;
        public static string StartDatum;
        public static string EindDatum;
        public static string Jaar;
        public static string dif;
        public static string stagenummer;
        

        private void AlgemeenOverzicht()
        {
           
            string Query = ("SELECT Inschrijving.StartDatum as Startdatum, Inschrijving.Einddatum, Inschrijving.Jaar as [Stage jaar], Student.StudentNr as Studentnummer, Student.Voornaam as [Voornaam student], Student.AchterNaam as [Achternaam student], Instelling.InstellingNaam as Instellingnaam, Instelling.AfdelingNaam as Afdelingnaam, Inschrijving.Differentiatie, Docent.Voornaam as [Voornaam docent], Docent.Achternaam as [Achternaam docent], Inschrijving.InschrNr as [Stage Code] FROM Student, Inschrijving, Instelling, Docent WHERE Inschrijving.StudentNr = Student.StudentNr And Inschrijving.DocentNr = Docent.DocentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Student.Jaar In (\"" + Knopjr1 + "\", \"" + Knopjr2 + "\", \"" + Knopjr3 + "\", \"" + Knopjr4 + "\", \"" + JaarDeel + "\") ORDER BY Inschrijving.StudentNr, Inschrijving.Jaar, Inschrijving.Startdatum");
            
            OleDbConnection connection = new OleDbConnection(DatabaseConnectie.DatabaseLokatie);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(Query, connection);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                dataadapter.Fill(ds, "Klas");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Klas";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kan verbinding niet openen ! ");
            }


        }
        //Functie die zoeken op het hoofdscherm mogelijk maakt
        string zoekopdracht;
        private void zoekbalk()
        {
            zoekopdracht = textBox1.Text;
            string Query = ("SELECT Inschrijving.StartDatum as Startdatum, Inschrijving.Einddatum, Inschrijving.Jaar as [Stage jaar], Student.StudentNr as Studentnummer, Student.Voornaam as [Voornaam student], Student.AchterNaam as [Achternaam student], Instelling.InstellingNaam as Instellingnaam, Instelling.AfdelingNaam as Afdelingnaam, Inschrijving.Differentiatie, Docent.Voornaam as [Voornaam docent], Docent.Achternaam as [Achternaam docent] FROM Student, Inschrijving, Instelling, Docent WHERE Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Inschrijving.DocentNr = Docent.DocentNr AND Inschrijving.StartDatum LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Inschrijving.DocentNr = Docent.DocentNr AND Inschrijving.EindDatum LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Inschrijving.DocentNr = Docent.DocentNr AND Inschrijving.Jaar LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Inschrijving.DocentNr = Docent.DocentNr AND Inschrijving.StudentNr LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Docent.DocentNr = Inschrijving.DocentNr AND Student.Voornaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Docent.DocentNr = Inschrijving.DocentNr AND Student.Achternaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Docent.DocentNr = Inschrijving.DocentNr AND Instelling.Instellingnaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Docent.DocentNr = Inschrijving.DocentNr AND Instelling.AfdelingNaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Docent.DocentNr = Inschrijving.DocentNr AND Docent.Voornaam LIKE \"%" + zoekopdracht + "%\" OR Inschrijving.StudentNr = Student.StudentNr AND Inschrijving.InstellingNr = Instelling.InstellingNr AND Docent.DocentNr = Inschrijving.DocentNr AND Docent.Achternaam LIKE \"%" + zoekopdracht + "%\" ORDER BY Student.StudentNr");
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
        private void Afsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Printen()
        {
            Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell celli in row.Cells)
                {
                    try
                    {
                        pdfTable.AddCell(celli.Value.ToString());
                    }
                    catch { }
                }
            }
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();

            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Printen();
        }

        int een = 0;
        int Knopjr1 = 0;
        private void Jaar1_Click(object sender, EventArgs e)
        {
            if (een == 0)
            {
                Jaar1.BackColor = Color.FromArgb(0, 55, 97);
                Jaar1.ForeColor = Color.White;
                een = 1;
                Knopjr1 = 1;
                if (Allen == 1)
                { allesgeselecteerd(); }
                AlgemeenOverzicht();
            }
            else
            {
                Jaar1.BackColor = Color.White;
                Jaar1.ForeColor = Color.Black;
                een = 0;
                Knopjr1 = 0;
                if (Allen == 1)
                { allesgeselecteerd(); }
                AlgemeenOverzicht();
            }
        }

        int twee;
        int Knopjr2 = 0;
        private void Jaar2_Click(object sender, EventArgs e)
        {
            if (twee == 0)
            {
                Jaar2.BackColor = Color.FromArgb(0, 55, 97);
                Jaar2.ForeColor = Color.White;
                twee = 1;
                Knopjr2 = 2;
                if (Allen == 1)
                { allesgeselecteerd(); }
                AlgemeenOverzicht();
            }
            else
            {
                Jaar2.BackColor = Color.White;
                Jaar2.ForeColor = Color.Black;
                twee = 0;
                Knopjr2 = 0;
                if (Allen == 1)
                { allesgeselecteerd(); }
                AlgemeenOverzicht();
            }
        }

        int drie;
        int Knopjr3 = 0;
        private void Jaar3_Click(object sender, EventArgs e)
        {
            if (drie == 0)
            {
                Jaar3.BackColor = Color.FromArgb(0, 55, 97);
                Jaar3.ForeColor = Color.White;
                drie = 1;
                Knopjr3 = 3;
                if (Allen == 1)
                { allesgeselecteerd(); }
                AlgemeenOverzicht();
            }
            else
            {
                Jaar3.BackColor = Color.White;
                Jaar3.ForeColor = Color.Black;
                drie = 0;
                Knopjr3 = 0;
                if (Allen == 1)
                { allesgeselecteerd(); }
                AlgemeenOverzicht();
            }
        }

        int vier;
        int Knopjr4 = 0;
        private void Jaar4_Click(object sender, EventArgs e)
        {
            if (vier == 0)
            {
                Jaar4.BackColor = Color.FromArgb(0, 55, 97);
                Jaar4.ForeColor = Color.White;
                vier = 1;
                Knopjr4 = 4;
                if (Allen == 1)
                { allesgeselecteerd(); }
                AlgemeenOverzicht();
            }
            else
            {
                Jaar4.BackColor = Color.White;
                Jaar4.ForeColor = Color.Black;
                vier = 0;
                Knopjr4 = 0;
                if (Allen == 1)
                { allesgeselecteerd(); }
                AlgemeenOverzicht();
            }
        }

        int tijd;
        string JaarDeel = "0";
        private void Deeltijd_Click(object sender, EventArgs e)
        {
            if (tijd == 0)
            {
                Deeltijd.BackColor = Color.FromArgb(0, 55, 97);
                Deeltijd.ForeColor = Color.White;
                tijd = 1;
                JaarDeel = "DT";
                AlgemeenOverzicht();
            }
            else
            {
                Deeltijd.BackColor = Color.White;
                Deeltijd.ForeColor = Color.Black;
                tijd = 0;
                JaarDeel = "0";
                AlgemeenOverzicht();
            }
        }

        private void Alles_Click(object sender, EventArgs e)
        {
           
       
            allesgeselecteerd();
        }
        int Allen;
        private void allesgeselecteerd()
        {
            if (Allen == 0)
            {
                Alles.BackColor = Color.FromArgb(0, 55, 97);
                Alles.ForeColor = Color.White;

                Allen = 1;
                Jaar4.BackColor = Color.FromArgb(0, 55, 97);
                Jaar4.ForeColor = Color.White;
                vier = 1;
                Knopjr4 = 4;
                Deeltijd.BackColor = Color.FromArgb(0, 55, 97);
                Deeltijd.ForeColor = Color.White;
                tijd = 1;
                JaarDeel = "DT";
                Jaar3.BackColor = Color.FromArgb(0, 55, 97);
                Jaar3.ForeColor = Color.White;
                drie = 1;
                Knopjr3 = 3;
                Jaar2.BackColor = Color.FromArgb(0, 55, 97);
                Jaar2.ForeColor = Color.White;
                twee = 1;
                Knopjr2 = 2;
                Jaar1.BackColor = Color.FromArgb(0, 55, 97);
                Jaar1.ForeColor = Color.White;
                een = 1;
                Knopjr1 = 1;
                AlgemeenOverzicht();
            }
            else
            {
                Alles.BackColor = Color.White;
                Alles.ForeColor = Color.Black;
                Allen = 0;
                Jaar1.BackColor = Color.White;
                Jaar1.ForeColor = Color.Black;
                een = 0;
                Knopjr1 = 0;
                Jaar2.BackColor = Color.White;
                Jaar2.ForeColor = Color.Black;
                twee = 0;
                Knopjr2 = 0;
                Jaar3.BackColor = Color.White;
                Jaar3.ForeColor = Color.Black;
                drie = 0;
                Knopjr3 = 0;
                Jaar4.BackColor = Color.White;
                Jaar4.ForeColor = Color.Black;
                vier = 0;
                Knopjr4 = 0;
                Deeltijd.BackColor = Color.White;
                Deeltijd.ForeColor = Color.Black;
                tijd = 0;
                JaarDeel = "0";
                AlgemeenOverzicht();
            }
        }
    }
    }
 

