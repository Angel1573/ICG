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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoofdscherm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Instellingen = new System.Windows.Forms.Button();
            this.Docenten = new System.Windows.Forms.Button();
            this.studenten = new System.Windows.Forms.Button();
            this.overzichtinstellingen = new System.Windows.Forms.Button();
            this.stagelocatiestudenten = new System.Windows.Forms.Button();
            this.Jaar2 = new System.Windows.Forms.Button();
            this.Jaar3 = new System.Windows.Forms.Button();
            this.Jaar4 = new System.Windows.Forms.Button();
            this.Deeltijd = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Jaar1 = new System.Windows.Forms.Button();
            this.Alles = new System.Windows.Forms.Button();
            this.Verversen = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Afsluiten = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1008, 547);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Instellingen
            // 
            this.Instellingen.Image = ((System.Drawing.Image)(resources.GetObject("Instellingen.Image")));
            this.Instellingen.Location = new System.Drawing.Point(571, 45);
            this.Instellingen.Name = "Instellingen";
            this.Instellingen.Size = new System.Drawing.Size(46, 44);
            this.Instellingen.TabIndex = 7;
            this.Instellingen.UseVisualStyleBackColor = true;
            this.Instellingen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Docenten
            // 
            this.Docenten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Docenten.Image = ((System.Drawing.Image)(resources.GetObject("Docenten.Image")));
            this.Docenten.Location = new System.Drawing.Point(515, 45);
            this.Docenten.Name = "Docenten";
            this.Docenten.Size = new System.Drawing.Size(46, 44);
            this.Docenten.TabIndex = 5;
            this.Docenten.UseVisualStyleBackColor = true;
            this.Docenten.Click += new System.EventHandler(this.Docenten_Click);
            // 
            // studenten
            // 
            this.studenten.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studenten.BackColor = System.Drawing.Color.Transparent;
            this.studenten.Image = global::project.Properties.Resources.studenticon3;
            this.studenten.Location = new System.Drawing.Point(458, 45);
            this.studenten.Name = "studenten";
            this.studenten.Size = new System.Drawing.Size(46, 44);
            this.studenten.TabIndex = 6;
            this.studenten.UseVisualStyleBackColor = false;
            this.studenten.Click += new System.EventHandler(this.studenten_Click);
            // 
            // overzichtinstellingen
            // 
            this.overzichtinstellingen.Location = new System.Drawing.Point(3, 32);
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
            // Jaar2
            // 
            this.Jaar2.BackColor = System.Drawing.Color.White;
            this.Jaar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Jaar2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Jaar2.Location = new System.Drawing.Point(84, 3);
            this.Jaar2.Name = "Jaar2";
            this.Jaar2.Size = new System.Drawing.Size(75, 23);
            this.Jaar2.TabIndex = 13;
            this.Jaar2.Text = "JAAR 2";
            this.Jaar2.UseVisualStyleBackColor = false;
            this.Jaar2.Click += new System.EventHandler(this.Jaar2_Click);
            // 
            // Jaar3
            // 
            this.Jaar3.BackColor = System.Drawing.Color.White;
            this.Jaar3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Jaar3.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Jaar3.Location = new System.Drawing.Point(165, 3);
            this.Jaar3.Name = "Jaar3";
            this.Jaar3.Size = new System.Drawing.Size(75, 23);
            this.Jaar3.TabIndex = 14;
            this.Jaar3.Text = "JAAR 3";
            this.Jaar3.UseVisualStyleBackColor = false;
            this.Jaar3.Click += new System.EventHandler(this.Jaar3_Click);
            // 
            // Jaar4
            // 
            this.Jaar4.BackColor = System.Drawing.Color.White;
            this.Jaar4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Jaar4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jaar4.Location = new System.Drawing.Point(3, 32);
            this.Jaar4.Name = "Jaar4";
            this.Jaar4.Size = new System.Drawing.Size(75, 23);
            this.Jaar4.TabIndex = 15;
            this.Jaar4.Text = "JAAR 4";
            this.Jaar4.UseVisualStyleBackColor = false;
            this.Jaar4.Click += new System.EventHandler(this.Jaar4_Click);
            // 
            // Deeltijd
            // 
            this.Deeltijd.BackColor = System.Drawing.Color.White;
            this.Deeltijd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deeltijd.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Deeltijd.Location = new System.Drawing.Point(84, 32);
            this.Deeltijd.Name = "Deeltijd";
            this.Deeltijd.Size = new System.Drawing.Size(75, 23);
            this.Deeltijd.TabIndex = 16;
            this.Deeltijd.Text = "DEELTIJD";
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
            this.flowLayoutPanel2.Location = new System.Drawing.Point(176, 44);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(245, 91);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // Jaar1
            // 
            this.Jaar1.BackColor = System.Drawing.Color.White;
            this.Jaar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Jaar1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Jaar1.ForeColor = System.Drawing.Color.Black;
            this.Jaar1.Location = new System.Drawing.Point(3, 3);
            this.Jaar1.Name = "Jaar1";
            this.Jaar1.Size = new System.Drawing.Size(75, 23);
            this.Jaar1.TabIndex = 12;
            this.Jaar1.Text = "JAAR 1";
            this.Jaar1.UseVisualStyleBackColor = false;
            this.Jaar1.Click += new System.EventHandler(this.Jaar1_Click);
            // 
            // Alles
            // 
            this.Alles.BackColor = System.Drawing.Color.White;
            this.Alles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Alles.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Alles.ForeColor = System.Drawing.Color.Black;
            this.Alles.Location = new System.Drawing.Point(165, 32);
            this.Alles.Name = "Alles";
            this.Alles.Size = new System.Drawing.Size(75, 23);
            this.Alles.TabIndex = 17;
            this.Alles.Text = "ALLES SELECTEREN";
            this.Alles.UseVisualStyleBackColor = false;
            this.Alles.Click += new System.EventHandler(this.Alles_Click);
            // 
            // Verversen
            // 
            this.Verversen.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Verversen.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verversen.ForeColor = System.Drawing.Color.White;
            this.Verversen.Location = new System.Drawing.Point(3, 61);
            this.Verversen.Name = "Verversen";
            this.Verversen.Size = new System.Drawing.Size(237, 28);
            this.Verversen.TabIndex = 18;
            this.Verversen.Text = "Refresh";
            this.Verversen.UseVisualStyleBackColor = false;
            this.Verversen.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(3, 61);
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
            this.flowLayoutPanel3.Controls.Add(this.overzichtinstellingen);
            this.flowLayoutPanel3.Controls.Add(this.Refresh);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(852, 49);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(134, 91);
            this.flowLayoutPanel3.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(658, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(658, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "Zoeken";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Afsluiten
            // 
            this.Afsluiten.Location = new System.Drawing.Point(871, 12);
            this.Afsluiten.Name = "Afsluiten";
            this.Afsluiten.Size = new System.Drawing.Size(85, 23);
            this.Afsluiten.TabIndex = 21;
            this.Afsluiten.Text = "Afsluiten";
            this.Afsluiten.UseVisualStyleBackColor = true;
            this.Afsluiten.Click += new System.EventHandler(this.Afsluiten_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 11);
            this.label2.TabIndex = 25;
            this.label2.Text = "V0.9 - NHL Hogeschool";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label4.Location = new System.Drawing.Point(511, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Beheer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Studenten";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(515, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Docenten";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(571, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Instelling";
            // 
            // Hoofdscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 733);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Instellingen);
            this.Controls.Add(this.Docenten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studenten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Afsluiten);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hoofdscherm";
            this.Text = "HBO-V Stagetool - Hoofdscherm";
            this.Load += new System.EventHandler(this.Hoofdscherm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Instellingen;
        private System.Windows.Forms.Button overzichtinstellingen;
        private System.Windows.Forms.Button stagelocatiestudenten;
        private System.Windows.Forms.Button Jaar2;
        private System.Windows.Forms.Button Jaar3;
        private System.Windows.Forms.Button Jaar4;
        private System.Windows.Forms.Button Deeltijd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button Verversen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Afsluiten;
        private System.Windows.Forms.Button Docenten;
        private System.Windows.Forms.Button studenten;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Jaar1;
        private System.Windows.Forms.Button Alles;
    }
}

