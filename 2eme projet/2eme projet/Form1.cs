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
    public partial class chargement : Form
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
        public chargement()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            progressBar1.Value = 0;
        }

        //move the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 4;
            
            if(progressBar1.Value>20)
            {
                L_leading.Visible = true;
            }
            if(progressBar1.Value>50)
            {
                L_leading.Visible = false;
                L_leadingmaroc.Visible = true;
            }
            if(progressBar1.Value>70)
            {
                L_leading.Visible = false;
                L_leadingmaroc.Visible = false;
                L_pleasewait.Visible = true;
            }
            if (progressBar1.Value > 98)
            {
                connecter f1 = new connecter();

                this.Hide();
                f1.Show();
                timer1.Stop();
            }
        }

        private void chargement_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void L_pleasewait_Click(object sender, EventArgs e)
        {

        }

        private void L_leadingmaroc_Click(object sender, EventArgs e)
        {

        }

        private void L_leading_Click(object sender, EventArgs e)
        {

        }

        private void chargement_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
