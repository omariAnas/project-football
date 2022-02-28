using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _2eme_projet
{
    public partial class connecter : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthRllipse,
            int nHrightEllipse
            );
        public connecter()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //move the form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // PB_ceye.Visible = true;
            if (TB_password.Text != "" && TB_password.Text != "entrer votre Mot de pass")
            {
                PB_validation2.Visible = true;
            }
            else
            {
                PB_validation2.Visible = false;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            créer co = new créer();
            this.Hide();

            co.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (TB_email.Text == créer.email && TB_password.Text == créer.modepasse)
            {
                welc_frm w = new welc_frm();
                this.Hide();
                w.Show();
               
            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                TB_email.Clear();
                TB_password.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void connecter_Load(object sender, EventArgs e)
        {
           
          

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (P_menu.Height == 39)
            {
                P_menu.Height = 321;
                P_logo.Width = 0;
            
            }
            else
            {
                P_menu.Height = 39;
                P_logo.Width = 689;
             
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P_menu.Height = 39;
            P_logo.Width = 0;
            PB_ceye.Visible = false;
            PB_oeye.Visible = false;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            info_app i = new info_app();
            i.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            info_personnelle i1 = new info_personnelle();
            i1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void P_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void P_menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void PB_ceye_Click(object sender, EventArgs e)
        {
            PB_oeye.Visible = true;
            PB_ceye.Visible = false;
            TB_password.PasswordChar = '\0';
        }

        private void PB_oeye_Click(object sender, EventArgs e)
        {
            PB_ceye.Visible = true;
            PB_oeye.Visible = false;
            TB_password.PasswordChar = '*';
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void TB_password_Enter(object sender, EventArgs e)
        {
            TB_password.PasswordChar = '*';
            if (TB_password.Text== "entrer votre Mot de pass")
            {
                TB_password.Text = "";
                TB_password.ForeColor = Color.Black;
            }
            if(TB_password.Text!= "entrer votre Mot de pass")
            {
                TB_password.PasswordChar = '*';
            }
            PB_ceye.Visible = true;
        }

        private void TB_password_Leave(object sender, EventArgs e)
        {
            TB_password.PasswordChar = '\0';
            if (TB_password.Text == "")
            {
                TB_password.Text = "entrer votre Mot de pass";
                TB_password.ForeColor = Color.Silver;
            }
            if (TB_password.Text != "entrer votre Mot de pass")
            {
                TB_password.PasswordChar = '*';
            }
            if(TB_password.Text!= "entrer votre Mot de pass" && TB_password.Text != "")
            {
                PB_ceye.Visible = true;
            }
            else
            {
                PB_ceye.Visible = false;
            }
        }

        private void TB_email_Enter(object sender, EventArgs e)
        {
          
            if (TB_email.Text == "entrer votre Email")
            {
                TB_email.Text = "";
                TB_email.ForeColor = Color.Black;
            }
        }

        private void TB_email_Leave(object sender, EventArgs e)
        {

            
            if (TB_email.Text == "")
            {
                TB_email.Text = "entrer votre Email";
                TB_email.ForeColor = Color.Silver;
            }
        }

        private void P_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TB_email_TextChanged(object sender, EventArgs e)
        {
            if (TB_email.Text != "" && TB_email.Text != "entrer votre Email")
            {
                PB_validation1.Visible = true;
            }
            else
            {
                PB_validation1.Visible = false;
            }
        }
    }
}
