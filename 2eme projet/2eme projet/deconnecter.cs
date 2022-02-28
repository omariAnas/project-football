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
    public partial class deconnecter : Form
    {
        public deconnecter()
        {
            InitializeComponent();
            PB_deconnecter.Value = 0;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            PB_deconnecter.Value += 4;
            if (PB_deconnecter.Value > 98)
            {
                Application.Exit();
                timer1.Stop();
            }
            
            if (PB_deconnecter.Value>8)
            {
                P_a.Width = 126; 
            }
            if(PB_deconnecter.Value>30)
            {
                
                P_r.Width = 241;
            }
            if (PB_deconnecter.Value > 55)
            {

                P_e.Width = 94;
            }
            if (PB_deconnecter.Value > 75)
            {

                P_m.Width = 334;
            }

           
           

        }

        private void deconnecter_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
    }
}
