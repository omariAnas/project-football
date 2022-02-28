
namespace _2eme_projet
{
    partial class créer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(créer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_dn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonreour = new System.Windows.Forms.Button();
            this.button_vider = new System.Windows.Forms.Button();
            this.button_suppr = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxmodepasse = new System.Windows.Forms.TextBox();
            this.radioButton_famme = new System.Windows.Forms.RadioButton();
            this.radioButton_homme = new System.Windows.Forms.RadioButton();
            this.comboBox_niveau = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_prenom,
            this.data_nom,
            this.data_sex,
            this.data_dn,
            this.data_age,
            this.data_ville});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 73);
            this.dataGridView1.TabIndex = 15;
            // 
            // data_prenom
            // 
            this.data_prenom.HeaderText = "prenom";
            this.data_prenom.Name = "data_prenom";
            // 
            // data_nom
            // 
            this.data_nom.HeaderText = "Nom";
            this.data_nom.Name = "data_nom";
            // 
            // data_sex
            // 
            this.data_sex.HeaderText = "Sex";
            this.data_sex.Name = "data_sex";
            // 
            // data_dn
            // 
            this.data_dn.HeaderText = "date nissance";
            this.data_dn.Name = "data_dn";
            // 
            // data_age
            // 
            this.data_age.HeaderText = "Age";
            this.data_age.Name = "data_age";
            // 
            // data_ville
            // 
            this.data_ville.HeaderText = "ville";
            this.data_ville.Name = "data_ville";
            // 
            // buttonreour
            // 
            this.buttonreour.BackColor = System.Drawing.Color.DarkRed;
            this.buttonreour.FlatAppearance.BorderSize = 0;
            this.buttonreour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonreour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonreour.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonreour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonreour.Location = new System.Drawing.Point(544, 276);
            this.buttonreour.Name = "buttonreour";
            this.buttonreour.Size = new System.Drawing.Size(80, 37);
            this.buttonreour.TabIndex = 26;
            this.buttonreour.Text = "S\'inscrire";
            this.buttonreour.UseVisualStyleBackColor = false;
            this.buttonreour.Click += new System.EventHandler(this.buttonreour_Click);
            // 
            // button_vider
            // 
            this.button_vider.BackColor = System.Drawing.Color.DarkRed;
            this.button_vider.FlatAppearance.BorderSize = 0;
            this.button_vider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_vider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vider.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vider.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_vider.Location = new System.Drawing.Point(544, 216);
            this.button_vider.Name = "button_vider";
            this.button_vider.Size = new System.Drawing.Size(80, 37);
            this.button_vider.TabIndex = 25;
            this.button_vider.Text = "vider";
            this.button_vider.UseVisualStyleBackColor = false;
            this.button_vider.Click += new System.EventHandler(this.button_vider_Click);
            // 
            // button_suppr
            // 
            this.button_suppr.BackColor = System.Drawing.Color.DarkRed;
            this.button_suppr.FlatAppearance.BorderSize = 0;
            this.button_suppr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_suppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_suppr.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_suppr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_suppr.Location = new System.Drawing.Point(544, 149);
            this.button_suppr.Name = "button_suppr";
            this.button_suppr.Size = new System.Drawing.Size(80, 37);
            this.button_suppr.TabIndex = 24;
            this.button_suppr.Text = "supprimer";
            this.button_suppr.UseVisualStyleBackColor = false;
            this.button_suppr.Click += new System.EventHandler(this.button_suppr_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.BackColor = System.Drawing.Color.DarkRed;
            this.button_ajouter.FlatAppearance.BorderSize = 0;
            this.button_ajouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajouter.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_ajouter.Location = new System.Drawing.Point(545, 81);
            this.button_ajouter.Margin = new System.Windows.Forms.Padding(0);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(82, 37);
            this.button_ajouter.TabIndex = 1;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = false;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // textBoxemail
            // 
            this.textBoxemail.BackColor = System.Drawing.Color.White;
            this.textBoxemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxemail.ForeColor = System.Drawing.Color.Silver;
            this.textBoxemail.Location = new System.Drawing.Point(216, 238);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(285, 15);
            this.textBoxemail.TabIndex = 5;
            this.textBoxemail.Text = "example@maroc.ma";
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBoxemail_TextChanged);
            this.textBoxemail.Enter += new System.EventHandler(this.textBoxemail_Enter);
            this.textBoxemail.Leave += new System.EventHandler(this.textBoxemail_Leave);
            // 
            // textBoxmodepasse
            // 
            this.textBoxmodepasse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxmodepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmodepasse.ForeColor = System.Drawing.Color.Silver;
            this.textBoxmodepasse.Location = new System.Drawing.Point(216, 291);
            this.textBoxmodepasse.Name = "textBoxmodepasse";
            this.textBoxmodepasse.Size = new System.Drawing.Size(285, 15);
            this.textBoxmodepasse.TabIndex = 6;
            this.textBoxmodepasse.Text = "entrer un mot de pass";
            this.textBoxmodepasse.Enter += new System.EventHandler(this.textBoxmodepasse_Enter);
            this.textBoxmodepasse.Leave += new System.EventHandler(this.textBoxmodepasse_Leave);
            // 
            // radioButton_famme
            // 
            this.radioButton_famme.AutoSize = true;
            this.radioButton_famme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_famme.Location = new System.Drawing.Point(445, 129);
            this.radioButton_famme.Name = "radioButton_famme";
            this.radioButton_famme.Size = new System.Drawing.Size(67, 20);
            this.radioButton_famme.TabIndex = 38;
            this.radioButton_famme.TabStop = true;
            this.radioButton_famme.Text = "famme";
            this.radioButton_famme.UseVisualStyleBackColor = true;
            // 
            // radioButton_homme
            // 
            this.radioButton_homme.AutoSize = true;
            this.radioButton_homme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_homme.Location = new System.Drawing.Point(371, 129);
            this.radioButton_homme.Name = "radioButton_homme";
            this.radioButton_homme.Size = new System.Drawing.Size(74, 20);
            this.radioButton_homme.TabIndex = 37;
            this.radioButton_homme.TabStop = true;
            this.radioButton_homme.Text = "Homme";
            this.radioButton_homme.UseVisualStyleBackColor = true;
            // 
            // comboBox_niveau
            // 
            this.comboBox_niveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_niveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_niveau.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_niveau.FormattingEnabled = true;
            this.comboBox_niveau.Items.AddRange(new object[] {
            "casa blanca",
            "el jadida",
            "safi",
            "tanger",
            "agadir",
            "fes",
            "marakech",
            "barchid",
            "dakhla",
            "rabat",
            "sale",
            "tmara",
            "oujda",
            "berkane",
            "housaima",
            "oualidia",
            "mouhamadia",
            "ifrane ",
            "titouan",
            "qnitra"});
            this.comboBox_niveau.Location = new System.Drawing.Point(216, 128);
            this.comboBox_niveau.Name = "comboBox_niveau";
            this.comboBox_niveau.Size = new System.Drawing.Size(146, 24);
            this.comboBox_niveau.TabIndex = 4;
            this.comboBox_niveau.Text = "entrer votre ville";
            this.comboBox_niveau.Enter += new System.EventHandler(this.comboBox_niveau_Enter);
            this.comboBox_niveau.Leave += new System.EventHandler(this.comboBox_niveau_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_prenom.ForeColor = System.Drawing.Color.Silver;
            this.textBox_prenom.Location = new System.Drawing.Point(371, 77);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(130, 15);
            this.textBox_prenom.TabIndex = 3;
            this.textBox_prenom.Text = "entrer votre prenom";
            this.textBox_prenom.Enter += new System.EventHandler(this.textBox_prenom_Enter);
            this.textBox_prenom.Leave += new System.EventHandler(this.textBox_prenom_Leave);
            // 
            // textBox_nom
            // 
            this.textBox_nom.BackColor = System.Drawing.Color.White;
            this.textBox_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nom.ForeColor = System.Drawing.Color.Silver;
            this.textBox_nom.Location = new System.Drawing.Point(216, 77);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(146, 15);
            this.textBox_nom.TabIndex = 2;
            this.textBox_nom.Text = "entrer votre nom";
            this.textBox_nom.TextChanged += new System.EventHandler(this.textBox_nom_TextChanged);
            this.textBox_nom.Enter += new System.EventHandler(this.textBox_nom_Enter);
            this.textBox_nom.Leave += new System.EventHandler(this.textBox_nom_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(377, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(745, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 24);
            this.label10.TabIndex = 44;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(216, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 3);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(216, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 3);
            this.panel2.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(216, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 1);
            this.panel3.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(216, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 3);
            this.panel4.TabIndex = 46;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(216, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(146, 3);
            this.panel5.TabIndex = 47;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(368, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(133, 3);
            this.panel6.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(722, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(213, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "date de naissance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(216, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 34);
            this.label1.TabIndex = 51;
            this.label1.Text = "S’inscrire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "C’est rapide et facile.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_2eme_projet.Properties.Resources.compte;
            this.pictureBox2.Location = new System.Drawing.Point(628, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2eme_projet.Properties.Resources.cadf6704_194d_4c55_a62c_2a4b1c6a04bc4;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // créer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.textBoxmodepasse);
            this.Controls.Add(this.radioButton_famme);
            this.Controls.Add(this.radioButton_homme);
            this.Controls.Add(this.comboBox_niveau);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonreour);
            this.Controls.Add(this.button_vider);
            this.Controls.Add(this.button_suppr);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "créer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "créer";
            this.Load += new System.EventHandler(this.créer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.créer_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_dn;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ville;
        private System.Windows.Forms.Button buttonreour;
        private System.Windows.Forms.Button button_vider;
        private System.Windows.Forms.Button button_suppr;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxmodepasse;
        private System.Windows.Forms.RadioButton radioButton_famme;
        private System.Windows.Forms.RadioButton radioButton_homme;
        private System.Windows.Forms.ComboBox comboBox_niveau;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}