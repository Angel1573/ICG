namespace project
{
    partial class Hoofdscherm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Docenten = new System.Windows.Forms.Button();
            this.studenten = new System.Windows.Forms.Button();
            this.Instellingen = new System.Windows.Forms.Button();
            this.Beheer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.overzichtinstellingen = new System.Windows.Forms.Button();
            this.stagelocatiestudenten = new System.Windows.Forms.Button();
            this.Jaar1 = new System.Windows.Forms.Button();
            this.Jaar2 = new System.Windows.Forms.Button();
            this.Jaar3 = new System.Windows.Forms.Button();
            this.Jaar4 = new System.Windows.Forms.Button();
            this.Deeltijd = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Alles = new System.Windows.Forms.Button();
            this.Verversen = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Beheer.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1008, 614);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Docenten
            // 
            this.Docenten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Docenten.Location = new System.Drawing.Point(173, 3);
            this.Docenten.Name = "Docenten";
            this.Docenten.Size = new System.Drawing.Size(78, 36);
            this.Docenten.TabIndex = 5;
            this.Docenten.Text = "Docenten beheren";
            this.Docenten.UseVisualStyleBackColor = true;
            this.Docenten.Click += new System.EventHandler(this.Docenten_Click);
            // 
            // studenten
            // 
            this.studenten.Location = new System.Drawing.Point(89, 3);
            this.studenten.Name = "studenten";
            this.studenten.Size = new System.Drawing.Size(78, 36);
            this.studenten.TabIndex = 6;
            this.studenten.Text = "Studenten Beheren";
            this.studenten.UseVisualStyleBackColor = true;
            this.studenten.Click += new System.EventHandler(this.studenten_Click);
            // 
            // Instellingen
            // 
            this.Instellingen.Location = new System.Drawing.Point(3, 3);
            this.Instellingen.Name = "Instellingen";
            this.Instellingen.Size = new System.Drawing.Size(80, 36);
            this.Instellingen.TabIndex = 7;
            this.Instellingen.Text = "Stage instellingen";
            this.Instellingen.UseVisualStyleBackColor = true;
            this.Instellingen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Beheer
            // 
            this.Beheer.Controls.Add(this.Instellingen);
            this.Beheer.Controls.Add(this.studenten);
            this.Beheer.Controls.Add(this.Docenten);
            this.Beheer.Controls.Add(this.flowLayoutPanel1);
            this.Beheer.Location = new System.Drawing.Point(716, 17);
            this.Beheer.Name = "Beheer";
            this.Beheer.Size = new System.Drawing.Size(255, 41);
            this.Beheer.TabIndex = 8;
            this.Beheer.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // overzichtinstellingen
            // 
            this.overzichtinstellingen.Location = new System.Drawing.Point(3, 61);
            this.overzichtinstellingen.Name = "overzichtinstellingen";
            this.overzichtinstellingen.Size = new System.Drawing.Size(128, 23);
            this.overzichtinstellingen.TabIndex = 10;
            this.overzichtinstellingen.Text = "Overzicht per instelling";
            this.overzichtinstellingen.UseVisualStyleBackColor = true;
            this.overzichtinstellingen.Click += new System.EventHandler(this.overzichtinstellingen_Click);
            // 
            // stagelocatiestudenten
            // 
            this.stagelocatiestudenten.Location = new System.Drawing.Point(3, 3);
            this.stagelocatiestudenten.Name = "stagelocatiestudenten";
            this.stagelocatiestudenten.Size = new System.Drawing.Size(128, 23);
            this.stagelocatiestudenten.TabIndex = 11;
            this.stagelocatiestudenten.Text = "per student waar stage gelopen, begeleiding";
            this.stagelocatiestudenten.UseVisualStyleBackColor = true;
            this.stagelocatiestudenten.Click += new System.EventHandler(this.stagelocatiestudenten_Click);
            // 
            // Jaar1
            // 
            this.Jaar1.BackColor = System.Drawing.Color.White;
            this.Jaar1.Location = new System.Drawing.Point(3, 3);
            this.Jaar1.Name = "Jaar1";
            this.Jaar1.Size = new System.Drawing.Size(75, 23);
            this.Jaar1.TabIndex = 12;
            this.Jaar1.Text = "Jaar 1";
            this.Jaar1.UseVisualStyleBackColor = false;
            this.Jaar1.Click += new System.EventHandler(this.Jaar1_Click);
            // 
            // Jaar2
            // 
            this.Jaar2.BackColor = System.Drawing.Color.White;
            this.Jaar2.Location = new System.Drawing.Point(84, 3);
            this.Jaar2.Name = "Jaar2";
            this.Jaar2.Size = new System.Drawing.Size(75, 23);
            this.Jaar2.TabIndex = 13;
            this.Jaar2.Text = "Jaar 2";
            this.Jaar2.UseVisualStyleBackColor = false;
            this.Jaar2.Click += new System.EventHandler(this.Jaar2_Click);
            // 
            // Jaar3
            // 
            this.Jaar3.BackColor = System.Drawing.Color.White;
            this.Jaar3.Location = new System.Drawing.Point(165, 3);
            this.Jaar3.Name = "Jaar3";
            this.Jaar3.Size = new System.Drawing.Size(75, 23);
            this.Jaar3.TabIndex = 14;
            this.Jaar3.Text = "Jaar 3";
            this.Jaar3.UseVisualStyleBackColor = false;
            this.Jaar3.Click += new System.EventHandler(this.Jaar3_Click);
            // 
            // Jaar4
            // 
            this.Jaar4.BackColor = System.Drawing.Color.White;
            this.Jaar4.Location = new System.Drawing.Point(3, 32);
            this.Jaar4.Name = "Jaar4";
            this.Jaar4.Size = new System.Drawing.Size(75, 23);
            this.Jaar4.TabIndex = 15;
            this.Jaar4.Text = "Jaar 4";
            this.Jaar4.UseVisualStyleBackColor = false;
            this.Jaar4.Click += new System.EventHandler(this.Jaar4_Click);
            // 
            // Deeltijd
            // 
            this.Deeltijd.BackColor = System.Drawing.Color.White;
            this.Deeltijd.Location = new System.Drawing.Point(84, 32);
            this.Deeltijd.Name = "Deeltijd";
            this.Deeltijd.Size = new System.Drawing.Size(75, 23);
            this.Deeltijd.TabIndex = 16;
            this.Deeltijd.Text = "Deeltijd";
            this.Deeltijd.UseVisualStyleBackColor = false;
            this.Deeltijd.Click += new System.EventHandler(this.Deeltijd_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Jaar1);
            this.flowLayoutPanel2.Controls.Add(this.Jaar2);
            this.flowLayoutPanel2.Controls.Add(this.Jaar3);
            this.flowLayoutPanel2.Controls.Add(this.Jaar4);
            this.flowLayoutPanel2.Controls.Add(this.Deeltijd);
            this.flowLayoutPanel2.Controls.Add(this.Alles);
            this.flowLayoutPanel2.Controls.Add(this.Verversen);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(245, 91);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // Alles
            // 
            this.Alles.BackColor = System.Drawing.Color.White;
            this.Alles.ForeColor = System.Drawing.Color.Black;
            this.Alles.Location = new System.Drawing.Point(165, 32);
            this.Alles.Name = "Alles";
            this.Alles.Size = new System.Drawing.Size(75, 23);
            this.Alles.TabIndex = 17;
            this.Alles.Text = "Alles";
            this.Alles.UseVisualStyleBackColor = false;
            this.Alles.Click += new System.EventHandler(this.Alles_Click);
            // 
            // Verversen
            // 
            this.Verversen.Location = new System.Drawing.Point(3, 61);
            this.Verversen.Name = "Verversen";
            this.Verversen.Size = new System.Drawing.Size(237, 23);
            this.Verversen.TabIndex = 18;
            this.Verversen.Text = "Verversen";
            this.Verversen.UseVisualStyleBackColor = true;
            this.Verversen.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(3, 32);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(128, 23);
            this.Refresh.TabIndex = 17;
            this.Refresh.Text = "Algemeen";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click_1);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.stagelocatiestudenten);
            this.flowLayoutPanel3.Controls.Add(this.Refresh);
            this.flowLayoutPanel3.Controls.Add(this.overzichtinstellingen);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(263, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(134, 91);
            this.flowLayoutPanel3.TabIndex = 18;
            // 
            // Hoofdscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 733);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.Beheer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Hoofdscherm";
            this.Text = "Hoofdscherm";
            this.Load += new System.EventHandler(this.Hoofdscherm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Beheer.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Docenten;
        private System.Windows.Forms.Button studenten;
        private System.Windows.Forms.Button Instellingen;
        private System.Windows.Forms.FlowLayoutPanel Beheer;
        private System.Windows.Forms.Button overzichtinstellingen;
        private System.Windows.Forms.Button stagelocatiestudenten;
        private System.Windows.Forms.Button Jaar1;
        private System.Windows.Forms.Button Jaar2;
        private System.Windows.Forms.Button Jaar3;
        private System.Windows.Forms.Button Jaar4;
        private System.Windows.Forms.Button Deeltijd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Alles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button Verversen;
    }
}

