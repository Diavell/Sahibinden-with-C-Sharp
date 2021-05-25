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
    public partial class Ikinciel : Form
    {
        public Ikinciel()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Ikinciel1 frm2 = new Ikinciel1();
            frm2.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Ikinciel2 frm2 = new Ikinciel2();
            frm2.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Ikinciel3 frm2 = new Ikinciel3();
            frm2.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Ikinciel4 frm2 = new Ikinciel4();
            frm2.Show();
            this.Hide();
        }

        private void Ikinciel_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("İkinciel1_0.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("İkinciel2_0.png");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("İkinciel3_0.png");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("İkinciel4_0.png");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("Logo.jpg");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile("UstBaslik.jpg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kategoriler frm2 = new Kategoriler();
            frm2.Show();
            this.Hide();
        }
    }
}
