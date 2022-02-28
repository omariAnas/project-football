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
    public partial class créer : Form
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

    
        public static String email, modepasse,Nom,Prenom;
        public créer()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        //move the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            string  prenom, ville, sex
;
            int dt, age;
            DateTime dn;
            Nom = textBox_nom.Text;
            prenom = textBox_prenom.Text;
            Prenom = textBox_prenom.Text;
            ville = comboBox_niveau.Text;
            dn = dateTimePicker1.Value;
            dt = DateTime.Today.Year;
            age = dt - dn.Year;
            if (radioButton_homme.Checked == true) sex = "homme";
            else sex = "famme";
            dataGridView1.Rows.Add(Nom, prenom, sex, dn, age, ville);
            email = textBoxemail.Text;
            modepasse = textBoxmodepasse.Text;


            //STYLE BTN


        }

        private void button_vider_Click(object sender, EventArgs e)
        {


            //vider les object
            textBox_prenom.Clear();
            textBox_nom.Clear();
            comboBox_niveau.Text = "";
            radioButton_homme.Checked = false;
            radioButton_famme.Checked = false;
            dateTimePicker1.Value = DateTime.Today;
            textBoxemail.Clear();
            textBoxmodepasse.Clear();
        }

        private void button_suppr_Click(object sender, EventArgs e)
        {

            //suprimee un row
            if (dataGridView1.Rows.Count > 0) dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void PB_creer_Click(object sender, EventArgs e)
        {

        }

        private void créer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void textBoxemail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxemail_Enter(object sender, EventArgs e)
        {
            if (textBoxemail.Text== "example@maroc.ma")
            {
                textBoxemail.Text = "";
                textBoxemail.ForeColor = Color.Black;
            }
        }

        private void textBoxemail_Leave(object sender, EventArgs e)
        {
            if (textBoxemail.Text == "")
            {
                textBoxemail.Text = "example@maroc.ma";
                textBoxemail.ForeColor = Color.Silver;
            }
        }

        private void textBox_nom_Enter(object sender, EventArgs e)
        {
            if (textBox_nom.Text == "entrer votre nom")
            {
                textBox_nom.Text = "";
                textBox_nom.ForeColor = Color.Black;
            }
        }

        private void textBox_nom_Leave(object sender, EventArgs e)
        {
            if (textBox_nom.Text == "")
            {
                textBox_nom.Text = "entrer votre nom";
                textBox_nom.ForeColor = Color.Silver;
            }
        }

        private void textBox_prenom_Enter(object sender, EventArgs e)
        {
            if (textBox_prenom.Text == "entrer votre prenom")
            {
                textBox_prenom.Text = "";
                textBox_prenom.ForeColor = Color.Black;
            }
        }

        private void textBox_prenom_Leave(object sender, EventArgs e)
        {
            if (textBox_prenom.Text == "")
            {
                textBox_prenom.Text = "entrer votre prenom";
                textBox_prenom.ForeColor = Color.Silver;
            }
        }

        private void comboBox_niveau_Enter(object sender, EventArgs e)
        {
            if (comboBox_niveau.Text == "entrer votre ville")
            {
                comboBox_niveau.Text = "";
                comboBox_niveau.ForeColor = Color.Black;
            }
        }

        private void comboBox_niveau_Leave(object sender, EventArgs e)
        {
            if (comboBox_niveau.Text == "")
            {
                comboBox_niveau.Text = "entrer votre ville";
                comboBox_niveau.ForeColor = Color.Silver;
            }
        }

        private void textBoxmodepasse_Enter(object sender, EventArgs e)
        {
            if (textBoxmodepasse.Text == "entrer un mot de pass")
            {
                textBoxmodepasse.Text = "";
                textBoxmodepasse.ForeColor = Color.Black;
            }
        }

        private void textBoxmodepasse_Leave(object sender, EventArgs e)
        {
            if (textBoxmodepasse.Text == "")
            {
                textBoxmodepasse.Text = "entrer un mot de pass";
                textBoxmodepasse.ForeColor = Color.Silver;
            }
        }

        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonreour_Click(object sender, EventArgs e)
        {
            
            connecter co = new connecter();
            this.Hide();

            co.Show();
        }

        private void créer_Load(object sender, EventArgs e)
        {
           





            //design les button
            button_ajouter.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0,button_ajouter.Width,button_ajouter.Height, 30,30));
            button_suppr.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button_suppr.Width,button_suppr.Height,30,30));
            button_suppr.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button_suppr.Width, button_suppr.Height, 30, 30));
            buttonreour.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonreour.Width, buttonreour.Height, 30, 30));
            button_vider.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button_vider.Width, button_vider.Height, 30, 30));

            //design data grid view
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 0, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            
        }
    }
}
