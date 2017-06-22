namespace project
{
    partial class Studenten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studenten));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Afsluiten = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Jaar1 = new System.Windows.Forms.Button();
            this.Jaar2 = new System.Windows.Forms.Button();
            this.Jaar3 = new System.Windows.Forms.Button();
            this.Jaar4 = new System.Windows.Forms.Button();
            this.Deeltijd = new System.Windows.Forms.Button();
            this.Alles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(580, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 117);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(994, 367);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(152, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Student toevoegen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(580, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 25);
            this.button2.TabIndex = 21;
            this.button2.Text = "Zoeken";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Refresh.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Location = new System.Drawing.Point(152, 76);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(124, 26);
            this.Refresh.TabIndex = 23;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Studentenbeheer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Afsluiten
            // 
            this.Afsluiten.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Afsluiten.BackgroundImage")));
            this.Afsluiten.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Afsluiten.Location = new System.Drawing.Point(760, 9);
            this.Afsluiten.Name = "Afsluiten";
            this.Afsluiten.Size = new System.Drawing.Size(50, 43);
            this.Afsluiten.TabIndex = 42;
            this.Afsluiten.UseVisualStyleBackColor = true;
            this.Afsluiten.Click += new System.EventHandler(this.Afsluiten_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Home.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(760, 58);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(50, 44);
            this.Home.TabIndex = 2;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Filter";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Jaar1);
            this.flowLayoutPanel2.Controls.Add(this.Jaar2);
            this.flowLayoutPanel2.Controls.Add(this.Jaar3);
            this.flowLayoutPanel2.Controls.Add(this.Jaar4);
            this.flowLayoutPanel2.Controls.Add(this.Deeltijd);
            this.flowLayoutPanel2.Controls.Add(this.Alles);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(298, 40);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(245, 62);
            this.flowLayoutPanel2.TabIndex = 45;
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
            this.Jaar2.Click += new System.EventHandler(this.Jaar2_Click_1);
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
            this.Jaar3.Click += new System.EventHandler(this.Jaar3_Click_1);
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
            this.Jaar4.Click += new System.EventHandler(this.Jaar4_Click_1);
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
            this.Deeltijd.Click += new System.EventHandler(this.Deeltijd_Click_1);
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
            this.Alles.Click += new System.EventHandler(this.Alles_Click_1);
            // 
            // Studenten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(994, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.Afsluiten);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Studenten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HBO-V Stagetool - Studentbeheer";
            this.Load += new System.EventHandler(this.Studenten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Afsluiten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Jaar1;
        private System.Windows.Forms.Button Jaar2;
        private System.Windows.Forms.Button Jaar3;
        private System.Windows.Forms.Button Jaar4;
        private System.Windows.Forms.Button Deeltijd;
        private System.Windows.Forms.Button Alles;
    }
}