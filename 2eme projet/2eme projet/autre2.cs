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
    public partial class autre2 : Form
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
        public autre2()
        {
            InitializeComponent();
        }

        public static String Taille, Prix, Sex, Prod, f;


        public static int pr11, pr22, pr33, pr44, pr55, pr66;


        public static List<string> x = new List<string>();

        private void PB_plus_Click(object sender, EventArgs e)
        {

            DGV_autre.Visible = true;
            PB_moin.Visible = true;
            PB_plus.Visible = false;
            BTN_trie.Visible = true;

        }

        private void PB_moin_Click(object sender, EventArgs e)
        {
            DGV_autre.Visible = false;
            PB_plus.Visible = true;
            PB_moin.Visible = false;
            BTN_trie.Visible = false;

        }

        private void CB_casquette2_CheckedChanged(object sender, EventArgs e)
        {
            //qs
            if (CB_casquette2.Checked)
            {
                comboBoxtaille.Visible = false;
                labelTaille.Visible = false;
            }
            else
            {
                comboBoxtaille.Visible = true;
                labelTaille.Visible = true;
            }

        }

        private void CB_casquette1_CheckedChanged(object sender, EventArgs e)
        {
            //qs
            if (CB_casquette1.Checked)
            {
                comboBoxtaille.Visible = false;
                labelTaille.Visible = false;
            }
            else
            {
                comboBoxtaille.Visible = true;
                labelTaille.Visible = true;
            }

        }

        private void buttoncommende_Click(object sender, EventArgs e)
        {
            Taille = comboBoxtaille.Text;
            if (radioButtonFAMME.Checked)
            {
                Sex = "Famme";
            }
            else Sex = "Homme";



            if (CB_coudas1.Checked)
            {
                f = "ee";
                Prix = L_coudas1.Text;
                DGV_autre.Rows.Add(CB_coudas1.Text, Prix, Taille, Sex);
                x.Add("le produit est coudas1 " + " de prix est " + Prix + " du taille est " + Taille + " du sex est " + Sex);
                pr11 = 400;
            }
            if (CB_coudas2.Checked)
            {
                f = "ee";
                Prix = L_coudas2.Text;
                DGV_autre.Rows.Add(CB_coudas2.Text, Prix, Taille, Sex);
                x.Add("le produit est coudas2 " + " de prix est " + Prix + " du taille est " + Taille + " du sex est " + Sex);
                pr22 = 500;

            }
            if (CB_coudas3.Checked)
            {
                f = "ee";
                Prix = L_coudas3.Text;
                DGV_autre.Rows.Add(CB_coudas3.Text, Prix, Taille, Sex);
                x.Add("le produit est coudas 3 " + " de prix est " + Prix + " du taille est " + Taille + " du sex est " + Sex);
                pr33 = 450;

            }
            // ajou casquette

            if (CB_casquette1.Checked)
            {
                f = "ee";
                Prix = L_casquette1.Text;
                DGV_autre.Rows.Add(CB_casquette1.Text, Prix, Taille, Sex);
                x.Add("le produit est casquette1 " + " de prix est " + Prix + " du taille est " + Taille + " du sex est " + Sex);
                pr44 = 80;

            }
            if (CB_casquette2.Checked)
            {
                f = "ee";
                Prix = L_casquette2.Text;
                DGV_autre.Rows.Add(CB_casquette2.Text, Prix, Taille, Sex);
                x.Add("le produit est casquette2 " + " de prix est " + Prix + " du taille est " + Taille + " du sex est " + Sex);
                pr55 = 100;

            }
            if (CB_casquette3.Checked)
            {
                f = "ee";
                Prix = L_casquette3.Text;
                DGV_autre.Rows.Add(CB_casquette3.Text, Prix, Taille, Sex);
                x.Add("le produit est casquette3 " + " de prix est " + Prix + " du taille est " + Taille + " du sex est " + Sex);
                pr66 = 50;
            }
            //decochee les checkbox
            CB_casquette1.Checked = false;
            CB_casquette2.Checked = false;
            CB_casquette3.Checked = false;
            CB_coudas1.Checked = false;
            CB_coudas2.Checked = false;
            CB_coudas3.Checked = false;



            //afficher btn plus
            PB_plus.Visible = true;

        }

        private void buttonsuppr_Click(object sender, EventArgs e)
        {
            if (DGV_autre.Rows.Count > 0) DGV_autre.Rows.Remove(DGV_autre.CurrentRow);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Height = 165;
            pictureBox4.Width = 240;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Height = 147;
            pictureBox4.Width = 227;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {

            pictureBox3.Height = 165;
            pictureBox3.Width = 240;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Height = 147;
            pictureBox3.Width = 227;
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox1.Height = 165;
            pictureBox1.Width = 240;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Height = 147;
            pictureBox1.Width = 227;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Height = 165;
            pictureBox5.Width = 240;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Height = 147;
            pictureBox5.Width = 227;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Height = 165;
            pictureBox2.Width = 240;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

            pictureBox2.Height = 147;
            pictureBox2.Width = 227;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Height = 165;
            pictureBox6.Width = 240;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Height = 147;
            pictureBox6.Width = 227;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGV_autre.Sort(DGV_autre.Columns[1], ListSortDirection.Ascending);
        }

        private void CB_casquette3_CheckedChanged(object sender, EventArgs e)
        {
            //qs
            if (CB_casquette3.Checked)
            {
                comboBoxtaille.Visible = false;
                labelTaille.Visible = false;
            }
            else
            {
                comboBoxtaille.Visible = true;
                labelTaille.Visible = true;
            }

        }

        //public static int pr1, pr2, pr3, pr4, pr5, pr6;

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void autre2_Load(object sender, EventArgs e)
        {
            //design data grid
            DGV_autre.BorderStyle = BorderStyle.None;
            DGV_autre.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(179, 255, 204);
            DGV_autre.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_autre.DefaultCellStyle.SelectionBackColor = Color.Gray;
            DGV_autre.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DGV_autre.BackgroundColor = Color.White;

            DGV_autre.EnableHeadersVisualStyles = false;
            DGV_autre.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_autre.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 128, 43);
            DGV_autre.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            //design duttn
            BTN_trie.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_trie.Width, BTN_trie.Height, 30, 30));
            buttoncommende.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, buttoncommende.Width, buttoncommende.Height, 30, 30));
            buttonsuppr.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonsuppr.Width, buttonsuppr.Height, 30, 30));



            //full name
            L_fullname.Text = créer.Nom +" "+ créer.Prenom;
        }

    }
}

