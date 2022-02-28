using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2eme_projet
{
    public partial class message_quiter : Form
    {
        public message_quiter()
        {
            InitializeComponent();
        }

        //move the form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        private void button1_Click(object sender, EventArgs e)
        {
           
           
            deconnecter d = new deconnecter();
            this.Hide();
            d.Show();

            

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            menu2 m = new menu2();
            m.Show();
        }

        private void message_quiter_Load(object sender, EventArgs e)
        {
           
        }

        private void message_quiter_MouseDown(object sender, MouseEventArgs e)
        {


            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
