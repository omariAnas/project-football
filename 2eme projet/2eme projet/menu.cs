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
    public partial class menu : Form
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
        public menu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //move the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void survetteMarocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void survetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            survette sur = new survette();
            sur.MdiParent = this;
            sur.Show();
        }

        private void tenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tenu sur = new tenu();
            sur.MdiParent = this;
            sur.Show();
        }

        private void autreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autre2 sur = new autre2();
            sur.MdiParent = this;
            sur.Show();
        }

        private void achetterTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programe_match sur = new programe_match();
            sur.MdiParent = this;
            sur.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void menu_Load(object sender, EventArgs e)
        {
            
        }

        private void voirLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            att_form a = new att_form();
            a.MdiParent = this;
            a.Show();

           
            
        }

        private void gardienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void diffencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void milieurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
          
        }

        private void attaqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void lesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void stagaireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message_quiter k = new message_quiter();
            this.Hide();
            k.Show();
            
        }

        private void squadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            squad s = new squad();
            s.MdiParent = this;
            s.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void P_mooove_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void stagaireToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (menuStrip1.Visible == true)
            {
                menuStrip1.Visible = false;
            }
            else
            {
                menuStrip1.Visible = true;
            }
        }

        private void P_mooove_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }
    }
}
