
namespace _2eme_projet
{
    partial class att_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(att_form));
            this.PB_wait = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_wait
            // 
            this.PB_wait.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("PB_wait.AnimationFunction")));
            this.PB_wait.AnimationSpeed = 500;
            this.PB_wait.BackColor = System.Drawing.Color.DarkRed;
            this.PB_wait.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.PB_wait.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.PB_wait.InnerColor = System.Drawing.Color.DarkRed;
            this.PB_wait.InnerMargin = 2;
            this.PB_wait.InnerWidth = -1;
            this.PB_wait.Location = new System.Drawing.Point(308, 212);
            this.PB_wait.MarqueeAnimationSpeed = 2000;
            this.PB_wait.Name = "PB_wait";
            this.PB_wait.OuterColor = System.Drawing.Color.DarkRed;
            this.PB_wait.OuterMargin = -25;
            this.PB_wait.OuterWidth = 26;
            this.PB_wait.ProgressColor = System.Drawing.Color.White;
            this.PB_wait.ProgressWidth = 8;
            this.PB_wait.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.PB_wait.Size = new System.Drawing.Size(234, 238);
            this.PB_wait.StartAngle = 270;
            this.PB_wait.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PB_wait.SubscriptColor = System.Drawing.Color.Green;
            this.PB_wait.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PB_wait.SubscriptText = "";
            this.PB_wait.SuperscriptColor = System.Drawing.Color.Green;
            this.PB_wait.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PB_wait.SuperscriptText = "";
            this.PB_wait.TabIndex = 0;
            this.PB_wait.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.PB_wait.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(293, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = " STORE MAROC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(354, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Copyrights © store maroc 2021";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(381, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Attendez ...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(278, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "CHARGEMENET DE VOTRE COMMANDES ....";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2eme_projet.Properties.Resources.eclaboussures_de_peinture_drapeau_du_lion_maroc1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // att_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PB_wait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "att_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "i";
            this.Load += new System.EventHandler(this.att_form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.att_form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar PB_wait;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}