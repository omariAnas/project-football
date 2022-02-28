using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2eme_projet
{
    public partial class squad : Form
    {
        public squad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Enter(object sender, EventArgs e)
        {
          
            PB_gardiens.Visible = true;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            
            PB_gardiens.Visible = false;
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            
            PB_arrieres.Visible = true;
            PB_defenseurs.Visible = true;
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            
            PB_arrieres.Visible = false;
            PB_defenseurs.Visible = false;

        }

        private void button3_Enter(object sender, EventArgs e)
        {
            PB_milieux.Visible = true;


        }

        private void button3_Leave(object sender, EventArgs e)
        {
          
            PB_milieux.Visible = false;

        }

        private void button4_Enter(object sender, EventArgs e)
        {
         
            PB_attaquants.Visible = true;

        }

        private void button4_Leave(object sender, EventArgs e)
        {
          
            PB_attaquants.Visible = false;

        }

        private void PB_attaquants_Click(object sender, EventArgs e)
        {

        }

        private void P_arrieres_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
