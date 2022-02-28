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
    public partial class welc_frm : Form
    {
        public welc_frm()
        {
            InitializeComponent();
        }

        //move the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void timer1_Tick(object sender, EventArgs e)
        {
            PB_welcome.Value += 4;
            if (PB_welcome.Value > 98)
            {
                menu2 m1 = new menu2();

                this.Hide();
                m1.Show();
                timer1.Stop();
            }
        }

        private void welc_frm_Load(object sender, EventArgs e)
        {
                L_nom.Text = créer.Nom;
                 timer1.Start();
            
            
        }

        private void welc_frm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
