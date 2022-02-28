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
    public partial class survette : Form
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

        public static String Taille, Prix, Sex, Prod, b;
        public static int p1, p2, p3;

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            /*pictureBox1.Height = 227;
            pictureBox1.Width = 207;*/
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            /*pictureBox2.Height = 260;
            pictureBox2.Width = 220;*/
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
           /* pictureBox2.Height = 227;
            pictureBox2.Width = 207;*/
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            /*pictureBox3.Height = 260;
            pictureBox3.Width = 220;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Height = 227;
            pictureBox3.Width = 207;*/
        }

        private void PB_plus_Click(object sender, EventArgs e)
        {
            /*survette.ActiveForm.Height = 650;
            dataGridViewSURVETT.Visible = true;
            PB_moin.Visible = true;
            PB_plus.Visible = false;*/
        }

        private void PB_moin_Click(object sender, EventArgs e)
        {
           /* survette.ActiveForm.Height = 550;
            dataGridViewSURVETT.Visible = false;
            PB_plus.Visible = true;
            PB_moin.Visible = false;*/
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttoncommende_Click_1(object sender, EventArgs e)
        {
            Taille = comboBoxtaille.Text;
            if (radioButtonFAMME.Checked)
            {
                Sex = "Famme";
            }
            else Sex = "Homme";



            if (checkBoxsurvettvert.Checked)
            {
                b = "bb";
                Prix = LABEL700DH.Text;
                dataGridViewSURVETT.Rows.Add(checkBoxsurvettvert.Text, Prix, Taille, Sex);
                l.Add("le produit est survett ver de prix est " + Prix + " du taille est " + Taille + " est de sex " + Sex);
                p1 = 700;


            }
            if (checkBoxsurvettnoir.Checked)
            {
                b = "bb";
                Prix = label900DH.Text;
                dataGridViewSURVETT.Rows.Add(checkBoxsurvettnoir.Text, Prix, Taille, Sex);
                l.Add("le produit est survett noir de prix est " + Prix + " du taille est " + Taille + " est de sex " + Sex);
                p2 = 900;
            }
            if (checkBoxsurveetrouge.Checked)
            {
                b = "bb";
                Prix = label600dh.Text;
                dataGridViewSURVETT.Rows.Add(checkBoxsurveetrouge.Text, Prix, Taille, Sex);
                l.Add("le produit est survett rouge de prix est " + Prix + " du taille es t" + Taille + " est de sex " + Sex);
                p3 = 600;
            }
            checkBoxsurveetrouge.Checked = false;
            checkBoxsurvettnoir.Checked = false;
            checkBoxsurvettvert.Checked = false;

            //afficher btn plus
            PB_plus.Visible = true;
        }

        private void buttonsuppr_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewSURVETT.Rows.Count > 0) dataGridViewSURVETT.Rows.Remove(dataGridViewSURVETT.CurrentRow);
        }

        private void PB_moin_Click_1(object sender, EventArgs e)
        {
            
            dataGridViewSURVETT.Visible = false;
            PB_plus.Visible = true;
            PB_moin.Visible = false;
            BTN_trie.Visible = false;
        }

        private void PB_plus_Click_1(object sender, EventArgs e)
        {
           
            dataGridViewSURVETT.Visible = true;
            PB_moin.Visible = true;
            PB_plus.Visible = false;
            BTN_trie.Visible = true;
        }

        private void dataGridViewSURVETT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox1.Height = 260;
            pictureBox1.Width = 220;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {

            pictureBox1.Height = 227;
            pictureBox1.Width = 207;
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.Height = 227;
            pictureBox2.Width = 207;
        }

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox2.Height = 260;
            pictureBox2.Width = 220;
        }

        private void pictureBox3_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox3.Height = 260;
            pictureBox3.Width = 220;
        }

        private void pictureBox3_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox3.Height = 227;
            pictureBox3.Width = 207;
        }

        private void BTN_trie_Click(object sender, EventArgs e)
        {
            dataGridViewSURVETT.Sort(dataGridViewSURVETT.Columns[1], ListSortDirection.Ascending);

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            

        }

        public survette()
        {
            InitializeComponent();
        }
        public static List<string> l = new List<string>();
        private void buttoncommende_Click(object sender, EventArgs e)
        {
            
            /*Taille = comboBoxtaille.Text;
            if (radioButtonFAMME.Checked)
            {
                Sex = "Famme";
            }
            else Sex = "Homme";



            if (checkBoxsurvettvert.Checked)
            {
                b = "bb";
                Prix = LABEL700DH.Text;
                dataGridViewSURVETT.Rows.Add(checkBoxsurvettvert.Text, Prix, Taille, Sex);
                l.Add("le produit est survett ver de prix est " + Prix+" du taille est "+Taille+" est de sex "+Sex);
                p1 = 700;


            }
            if (checkBoxsurvettnoir.Checked)
            {
                b = "bb";
                Prix = label900DH.Text;
                dataGridViewSURVETT.Rows.Add(checkBoxsurvettnoir.Text, Prix, Taille, Sex);
                l.Add("le produit est survett noir de prix est " + Prix + " du taille est " + Taille + " est de sex " + Sex);
                p2 = 900;
            }
            if (checkBoxsurveetrouge.Checked)
            {
                b = "bb";
                Prix = label600dh.Text;
                dataGridViewSURVETT.Rows.Add(checkBoxsurveetrouge.Text, Prix, Taille, Sex);
                l.Add("le produit est survett rouge de prix est " + Prix + " du taille es t" + Taille + " est de sex " + Sex);
                p3 = 600;
            }
            checkBoxsurveetrouge.Checked = false;
            checkBoxsurvettnoir.Checked = false;
            checkBoxsurvettvert.Checked = false;

            //afficher btn plus
            PB_plus.Visible = true;*/
        }

        private void buttonsuppr_Click(object sender, EventArgs e)
        {
            //if (dataGridViewSURVETT.Rows.Count > 0) dataGridViewSURVETT.Rows.Remove(dataGridViewSURVETT.CurrentRow);
        }

        private void survette_Load(object sender, EventArgs e)
        {
            dataGridViewSURVETT.BorderStyle = BorderStyle.None;
            dataGridViewSURVETT.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(179, 255, 204);
            dataGridViewSURVETT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewSURVETT.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridViewSURVETT.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewSURVETT.BackgroundColor = Color.White;

            dataGridViewSURVETT.EnableHeadersVisualStyles = false;
            dataGridViewSURVETT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewSURVETT.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 128, 43);
            dataGridViewSURVETT.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //fullname
            L_fullname.Text = créer.Nom + " " + créer.Prenom;



            //design duttn
            BTN_trie.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_trie.Width, BTN_trie.Height, 30, 30));
            buttoncommende.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, buttoncommende.Width, buttoncommende.Height, 30, 30));
            buttonsuppr.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonsuppr.Width, buttonsuppr.Height, 30, 30));
        }
    }
}
