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
    public partial class menu2 : Form
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

        public menu2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //move the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        private void tenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tenu sur = new tenu();
            sur.MdiParent = this;
            sur.Show();

        }

        private void survetteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            survette sur = new survette();
            sur.MdiParent = this;
            sur.Show();

        }

        private void autreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autre2 sur = new autre2();
            sur.MdiParent = this;
            sur.Show();

        }

        private void acheterTicketrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programe_match sur = new programe_match();
            sur.MdiParent = this;
            sur.Show();

        }

        private void laCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p_c.Visible = true;

            p_p.Visible = false;
            p_g.Visible = false;
            p_q.Visible = false;
            p_s.Visible = false;
           
            att_form a = new att_form();
            a.MdiParent = this;
            a.Show();

        }

        private void squadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p_s.Visible = true;

            p_p.Visible = false;
            p_g.Visible = false;
            p_q.Visible = false;
           
            p_c.Visible = false;
            squad s = new squad();
            s.MdiParent = this;
            s.Show();

        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p_q.Visible = true;

            p_p.Visible = false;
            p_g.Visible = false;
           
            p_s.Visible = false;
            p_c.Visible = false;
            message_quiter k = new message_quiter();
            this.Hide();
            k.Show();

        }

        private void menu2_Load(object sender, EventArgs e)
        {

            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p_p.Visible = true;
            p_g.Visible = false;
            p_q.Visible = false;
            p_s.Visible = false;
            p_c.Visible = false;
        }

        private void guichetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p_g.Visible = true;
            p_p.Visible = false;
            p_q.Visible = false;
            p_s.Visible = false;
            p_c.Visible = false;
        }
    }
}
