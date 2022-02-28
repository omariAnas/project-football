
namespace _2eme_projet
{
    partial class chargement
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chargement));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.L_leading = new System.Windows.Forms.Label();
            this.L_leadingmaroc = new System.Windows.Forms.Label();
            this.L_pleasewait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 442);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(777, 10);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // L_leading
            // 
            this.L_leading.AutoSize = true;
            this.L_leading.BackColor = System.Drawing.Color.Transparent;
            this.L_leading.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_leading.ForeColor = System.Drawing.Color.White;
            this.L_leading.Location = new System.Drawing.Point(29, 393);
            this.L_leading.Name = "L_leading";
            this.L_leading.Size = new System.Drawing.Size(145, 31);
            this.L_leading.TabIndex = 2;
            this.L_leading.Text = "Leading ...";
            this.L_leading.Visible = false;
            this.L_leading.Click += new System.EventHandler(this.L_leading_Click);
            // 
            // L_leadingmaroc
            // 
            this.L_leadingmaroc.AutoSize = true;
            this.L_leadingmaroc.BackColor = System.Drawing.Color.Transparent;
            this.L_leadingmaroc.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_leadingmaroc.ForeColor = System.Drawing.Color.White;
            this.L_leadingmaroc.Location = new System.Drawing.Point(29, 393);
            this.L_leadingmaroc.Name = "L_leadingmaroc";
            this.L_leadingmaroc.Size = new System.Drawing.Size(452, 31);
            this.L_leadingmaroc.TabIndex = 3;
            this.L_leadingmaroc.Text = "Leading STORE MAROC de foot ...";
            this.L_leadingmaroc.Visible = false;
            this.L_leadingmaroc.Click += new System.EventHandler(this.L_leadingmaroc_Click);
            // 
            // L_pleasewait
            // 
            this.L_pleasewait.AutoSize = true;
            this.L_pleasewait.BackColor = System.Drawing.Color.Transparent;
            this.L_pleasewait.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_pleasewait.ForeColor = System.Drawing.Color.White;
            this.L_pleasewait.Location = new System.Drawing.Point(63, 393);
            this.L_pleasewait.Name = "L_pleasewait";
            this.L_pleasewait.Size = new System.Drawing.Size(220, 31);
            this.L_pleasewait.TabIndex = 4;
            this.L_pleasewait.Text = "Please wait ... !";
            this.L_pleasewait.Visible = false;
            this.L_pleasewait.Click += new System.EventHandler(this.L_pleasewait_Click);
            // 
            // chargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::_2eme_projet.Properties.Resources._8f91401c_660a_4bad_9e61_d6e0c575b8e13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 452);
            this.Controls.Add(this.L_pleasewait);
            this.Controls.Add(this.L_leadingmaroc);
            this.Controls.Add(this.L_leading);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chargement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.chargement_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chargement_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label L_leading;
        private System.Windows.Forms.Label L_leadingmaroc;
        private System.Windows.Forms.Label L_pleasewait;
    }
}

