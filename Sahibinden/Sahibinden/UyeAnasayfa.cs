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
    public partial class UyeAnasayfa : Form
    {
        public UyeAnasayfa()
        {
            InitializeComponent();
        }

        private void UyeAnasayfa_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("UstBaslik.jpg");

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Logo.jpg");

            string ad = "";
            string soyad = "";

            string[] adsoyad = System.IO.File.ReadAllLines("KurumsaUyelik.txt");
            foreach (string str in adsoyad)
            {
                ad = (str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                soyad = (str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
            }
            linkLabel2.Text = ad + " " + soyad;

            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile("Ev3.jpg");

            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("Hayvanlar2_0.png");

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("İkinciel2_0.png");

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("Ozelders2_0.png");

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("Sanayi2_0.png");

            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.Image = Image.FromFile("Vasitaarac2_0.png");

            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.Image = Image.FromFile("Yedekparca2_0.png");

            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.Image = Image.FromFile("Ev2.jpg");

            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.Image = Image.FromFile("Hayvanlar1_0.png");

            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Image = Image.FromFile("İkinciel1_0.png");

            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox17.Image = Image.FromFile("Ozelders1_0.png");

            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.Image = Image.FromFile("Sanayi1_0.png");

            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.Image = Image.FromFile("Vasitaarac1_0.png");

            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.Image = Image.FromFile("Yedekparca1_0.png");

            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.Image = Image.FromFile("Ev1.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kategoriler frm2 = new Kategoriler();
            frm2.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Emlakev3 frm2 = new Emlakev3();
            frm2.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Hayvanlar2 frm2 = new Hayvanlar2();
            frm2.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Ikinciel2 frm2 = new Ikinciel2();
            frm2.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Ozelders2 frm2 = new Ozelders2();
            frm2.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Sanayi2 frm2 = new Sanayi2();
            frm2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Vasitaarac2 frm2 = new Vasitaarac2();
            frm2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Yedekparca2 frm2 = new Yedekparca2();
            frm2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Emlakev2 frm2 = new Emlakev2();
            frm2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hayvanlar1 frm2 = new Hayvanlar1();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ikinciel1 frm2 = new Ikinciel1();
            frm2.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Ozelders1 frm2 = new Ozelders1();
            frm2.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Sanayi1 frm2 = new Sanayi1();
            frm2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Vasitaarac1 frm2 = new Vasitaarac1();
            frm2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Yedekparca1 frm2 = new Yedekparca1();
            frm2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Emlakev1 frm2 = new Emlakev1();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Emlak" || textBox1.Text == "emlak")
            {
                Emlak frm2 = new Emlak();
                frm2.Show();
            }
            else if (textBox1.Text == "İkinci el" || textBox1.Text == "ikinci el")
            {
                Ikinciel frm2 = new Ikinciel();
                frm2.Show();
            }
            else if (textBox1.Text == "Özel ders" || textBox1.Text == "özel ders")
            {
                Ozelders frm2 = new Ozelders();
                frm2.Show();
            }
            else if (textBox1.Text == "Sanayi" || textBox1.Text == "sanayi")
            {
                Sanayi frm2 = new Sanayi();
                frm2.Show();
            }
            else if (textBox1.Text == "Vasıta" || textBox1.Text == "vasıta")
            {
                Vasita frm2 = new Vasita();
                frm2.Show();
            }
            else if (textBox1.Text == "Yedek parça" || textBox1.Text == "yedek parça")
            {
                Yedekparca frm2 = new Yedekparca();
                frm2.Show();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Anasayfa frm2 = new Anasayfa();
            frm2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Uyeligim frm2 = new Uyeligim();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İlanver frm2 = new İlanver();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Favorilerim frm2 = new Favorilerim();
            frm2.Show();
        }
    }
}
