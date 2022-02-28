using System;
using System.Collections;
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
    public partial class programe_match : Form
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



        public static String Match, Categorie,c;
        public static int c1, c2, c3;
        public programe_match()
        {
            InitializeComponent();
        }
        public static List<string> g = new List<string>();
        private object arraylist;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void LB_tout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void B_passer_Click(object sender, EventArgs e)
        {
            c = "aa";
            Match=LB_match.SelectedItem.ToString();
            Categorie = CB_prix.SelectedItem.ToString();

            if (CB_prix.SelectedItem == "Categorie 3 : 30 DH")  c3 = 30;
            if (CB_prix.SelectedItem == "Categorie 2 : 50 DH") c2 = 50;
            if (CB_prix.SelectedItem == "Categorie 1 : 150 DH") c1 = 150;

            LB_tout.Items.Add(" " + Match + "            " + Categorie);
            g.Add("les match acheter est " + Match + " " + Categorie);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*ArrayList list = new ArrayList();

            list.Sort();
            list.Reverse();*/

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void B_annullée_Click(object sender, EventArgs e)
        {
           
            string b;
            b = LB_tout.SelectedItem.ToString();
            LB_tout.Items.Remove(b);
        }

        private void programe_match_Load(object sender, EventArgs e)
        {
            L_fullname.Text = créer.Nom + " " + créer.Prenom;


            //design duttn
            B_annullée.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, B_annullée.Width, B_annullée.Height, 30, 30));
            B_passer.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, B_passer.Width, B_passer.Height, 30, 30));
        }
    }
}
