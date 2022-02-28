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
    public partial class tout_la_commande : Form
    {
        private void add()
        {
            
        }
        private void update()
        {
            
            
        }
        public tout_la_commande()
        {
            InitializeComponent();
            
        }

        private void tout_la_commande_Load(object sender, EventArgs e)
        {
            //login
            L_nom.Text = créer.Nom;



            //prix total  des produit
            int t1,t2,t3,c,s,tp,tt;
            //t1 = autre.pr1 + autre.pr2 + autre.pr3 + autre.pr4 + autre.pr5 + autre.pr6;
            t1 = autre2.pr11 + autre2.pr22 + autre2.pr33 + autre2.pr44 + autre2.pr55 + autre2.pr66;
            t2 = survette.p1 + survette.p2 + survette.p3;
            t3 = tenu.p4 + tenu.p5 + tenu.p6;
            tp = t1 + t2 + t3;


            c = programe_match.c1 + programe_match.c2 + programe_match.c3;

            L_tp.Text = tp.ToString() + " DH";
            L_tt.Text = c.ToString() + " DH";
            s = t1 + t2 + t3+c;
            TB1.Text = s.ToString()+" DH";
            if (tenu.t == "aa")
            {


                List<string> l2 = tenu.s;
                listBox1.Items.AddRange(l2.ToArray());
            }





            /*----------------------------------*/

            if (survette.b=="bb")
            {


                List<string> l1 = survette.l;
                listBox1.Items.AddRange(l1.ToArray());
            }
            if (autre2.f == "ee")
            {
                List<string> l2 = autre2.x;
                listBox1.Items.AddRange(l2.ToArray());
            }




            if (programe_match.c=="aa")
            {
                List<string> l3 = programe_match.g;
                listBox2.Items.AddRange(l3.ToArray());

            }


            L_fullname.Text = créer.Nom + " " + créer.Prenom;


        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_nom_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
