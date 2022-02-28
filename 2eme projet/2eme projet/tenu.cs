using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace _2eme_projet
{
    public partial class tenu : Form
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


        public static String Taille, Prix, Sex, Prod,t, d,index;
        public static int p4, p5, p6;
        
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Height = 300;
            pictureBox3.Width = 300;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Height = 216;
            pictureBox3.Width = 243;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Height = 300;
            pictureBox4.Width = 300;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Height = 216;
            pictureBox4.Width = 243;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Height = 300;
            pictureBox1.Width = 300;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Height = 216;
            pictureBox1.Width = 243;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PB_moin_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Visible = false;
            PB_plus.Visible = true;
            PB_moin.Visible = false;
            BTN_trie.Visible = false;
        }

        private void BTN_trie_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void PB_plus_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = true;
            PB_moin.Visible = true;
            PB_plus.Visible = false;
            BTN_trie.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        public tenu()
        {
            InitializeComponent();
         
        }
       
        public static List<string> s = new List<string>();
        private void buttoncommende_Click(object sender, EventArgs e)
        {
           

            Taille = comboBoxtaille.Text;
            if (radioButtonFAMME.Checked)
            {
                Sex = "Famme";
            }
            else Sex = "Homme";
            


            if (checkBoxtenuvert.Checked)
            {
                t = "aa";
                Prix = label250DHver.Text;
                dataGridView1.Rows.Add(checkBoxtenuvert.Text, Prix, Taille, Sex);
                
               
                s.Add("le produit est tenu ver " + " de prix est " + Prix + " du taille est " + Taille + " du sex est " + Sex);
                p4 = 250;
            }
            if (checkBoxtenublanc.Checked)
            {
                t = "aa";
                Prix = label300DH.Text;
                dataGridView1.Rows.Add(checkBoxtenublanc.Text, Prix, Taille, Sex);
                
               
                s.Add("le produit est tenu blanc " + Prod + " de prix est " + Prix + " du taille est " + Taille + " du sex est " + Sex);
                p5 = 300;
            }
            if (checkBoxtenurouge.Checked)
            {
                t = "aa";
                Prix = LABEl250DH.Text;
                dataGridView1.Rows.Add(checkBoxtenurouge.Text, Prix, Taille, Sex);
                
                s.Add("le produit est tenu rouge " + Prod + " de prix est " + Prix + " du taille est " + Taille + " du sex est " + Sex);
                p6 = 250;
            }
            checkBoxtenublanc.Checked = false;
            checkBoxtenurouge.Checked = false;
            checkBoxtenuvert.Checked = false;


            //afficher btn plus
            PB_plus.Visible = true;
        }

        private void buttonsuppr_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void tenu_Load(object sender, EventArgs e)
        {


            //design datagridview
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(179, 255, 204);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 128, 43);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            //fullname
            L_fullname.Text = créer.Nom + " " + créer.Prenom;



            //design duttn
            BTN_trie.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_trie.Width, BTN_trie.Height, 30, 30));
            buttoncommende.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, buttoncommende.Width, buttoncommende.Height, 30, 30));
            buttonsuppr.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonsuppr.Width, buttonsuppr.Height, 30, 30));


        }
    }
}
