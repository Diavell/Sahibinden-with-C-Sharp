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
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("Unlem.png");

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("Ok.jpg");

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("Saat.jpg");

            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("Oto360.jpg");

            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile("Emlak360.png");

            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Image = Image.FromFile("Yeni.png");

            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.Image = Image.FromFile("Yeni.png");

            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.Image = Image.FromFile("Emlak.png");

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Vasita.png");

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Yedekparca.png");

            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.Image = Image.FromFile("Ikinciel.png");

            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.Image = Image.FromFile("Ismakineleri.png");

            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.Image = Image.FromFile("Ustalar.png");

            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.Image = Image.FromFile("Ozelders.png");

            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.Image = Image.FromFile("Isilanlari.png");

            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.Image = Image.FromFile("Yardimci.png");

            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox17.Image = Image.FromFile("Hayvanlar.png");

            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.Image = Image.FromFile("Smile.png");

            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.Image = Image.FromFile("Ilginc.png");
        }

        private void linkLabel60_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hayvanlar frm2 = new Hayvanlar();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Emlak frm2 = new Emlak();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vasita frm2 = new Vasita();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Yedekparca frm2 = new Yedekparca();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel27_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ikinciel frm2 = new Ikinciel();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel35_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sanayi frm2 = new Sanayi();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel59_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hayvanlar frm2 = new Hayvanlar();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel44_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ozelders frm2 = new Ozelders();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Emlak frm2 = new Emlak();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Emlak frm2 = new Emlak();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Emlak frm2 = new Emlak();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Emlak frm2 = new Emlak();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Emlak frm2 = new Emlak();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Emlak frm2 = new Emlak();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Emlak frm2 = new Emlak();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vasita frm2 = new Vasita();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vasita frm2 = new Vasita();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vasita frm2 = new Vasita();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vasita frm2 = new Vasita();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vasita frm2 = new Vasita();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vasita frm2 = new Vasita();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel22_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vasita frm2 = new Vasita();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vasita frm2 = new Vasita();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel24_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Yedekparca frm2 = new Yedekparca();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Yedekparca frm2 = new Yedekparca();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel26_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Yedekparca frm2 = new Yedekparca();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel28_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ikinciel frm2 = new Ikinciel();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel29_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ikinciel frm2 = new Ikinciel();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel30_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ikinciel frm2 = new Ikinciel();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel31_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ikinciel frm2 = new Ikinciel();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel32_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ikinciel frm2 = new Ikinciel();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel33_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ikinciel frm2 = new Ikinciel();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel34_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ikinciel frm2 = new Ikinciel();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel36_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sanayi frm2 = new Sanayi();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel37_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sanayi frm2 = new Sanayi();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel38_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sanayi frm2 = new Sanayi();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel39_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sanayi frm2 = new Sanayi();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel61_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hayvanlar frm2 = new Hayvanlar();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel62_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hayvanlar frm2 = new Hayvanlar();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel63_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hayvanlar frm2 = new Hayvanlar();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel64_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hayvanlar frm2 = new Hayvanlar();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel65_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hayvanlar frm2 = new Hayvanlar();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel66_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hayvanlar frm2 = new Hayvanlar();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel67_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hayvanlar frm2 = new Hayvanlar();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel45_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ozelders frm2 = new Ozelders();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel46_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ozelders frm2 = new Ozelders();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel47_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ozelders frm2 = new Ozelders();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Acil frm2 = new Acil();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Fiyatidusenler frm2 = new Fiyatidusenler();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Son48 frm2 = new Son48();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel70_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hafta frm2 = new Hafta();
            frm2.Show();
            this.Hide();
        }

        private void linkLabel71_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ay frm2 = new Ay();
            frm2.Show();
            this.Hide();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
