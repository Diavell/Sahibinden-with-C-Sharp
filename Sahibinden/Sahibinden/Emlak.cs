using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahibinden
{
    public partial class Emlak : Form
    {
        public Emlak()
        {
            InitializeComponent();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            comboBox13.Enabled = false;
            if (comboBox22.Text != "")
            {
                comboBox13.Enabled = true;
            }
        }

        private void Emlak_Load(object sender, EventArgs e)
        { 
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Ev1.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Ev2.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("Ev3.jpg");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("Ev4.jpg");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("Ev5.jpg");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("Logo.jpg");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile("UstBaslik.jpg");
            string dosyayolu = "";
            try
            {
                string[] uyelik3 = System.IO.File.ReadAllLines("Emlakilan.txt");
                foreach (string str in uyelik3)
                {
                    dosyayolu = (str.Split(',')[6]); Encoding.GetEncoding("windows-1254");
                }
                pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox8.Image = Image.FromFile(dosyayolu);
            }

            catch (Exception)
            {
                
            }
            //string[] uyelik2 = System.IO.File.ReadAllLines("KurumsaUyelik.txt");
            //foreach (string str in uyelik2)
            //{
            //    eposta2 = (str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
            //    sifre2 = (str.Split(',')[3]); Encoding.GetEncoding("windows-1254");
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Emlakev1 frm2 = new Emlakev1();
            frm2.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Emlakev2 frm2 = new Emlakev2();
            frm2.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Emlakev3 frm2 = new Emlakev3();
            frm2.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Emlakev4 frm2 = new Emlakev4();
            frm2.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Emlakev5 frm2 = new Emlakev5();
            frm2.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            Kategoriler frm2 = new Kategoriler();
            frm2.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Emlakilan1 frm2 = new Emlakilan1();
            frm2.Show();
            this.Hide();
        }
    }
}
