
namespace _2eme_projet
{
    partial class welc_frm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welc_frm));
            this.PB_welcome = new System.Windows.Forms.ProgressBar();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.L_nom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_welcome
            // 
            this.PB_welcome.Location = new System.Drawing.Point(228, 162);
            this.PB_welcome.Name = "PB_welcome";
            this.PB_welcome.Size = new System.Drawing.Size(100, 56);
            this.PB_welcome.TabIndex = 11;
            this.PB_welcome.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::_2eme_projet.Properties.Resources.progressbar_indeterminate;
            this.pictureBox7.Location = new System.Drawing.Point(45, 51);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(257, 150);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // L_nom
            // 
            this.L_nom.AutoSize = true;
            this.L_nom.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_nom.ForeColor = System.Drawing.Color.DarkRed;
            this.L_nom.Location = new System.Drawing.Point(201, 26);
            this.L_nom.Name = "L_nom";
            this.L_nom.Size = new System.Drawing.Size(0, 25);
            this.L_nom.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(88, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bienvenue";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // welc_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 168);
            this.Controls.Add(this.PB_welcome);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.L_nom);
            this.Controls.Add(this.label7);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "welc_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welc_frm";
            this.Load += new System.EventHandler(this.welc_frm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.welc_frm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PB_welcome;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label L_nom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}