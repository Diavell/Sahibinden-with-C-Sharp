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
    public partial class Hafta : Form
    {
        public Hafta()
        {
            InitializeComponent();
        }

        private void Hafta_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("1Hafta.png");

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Ev4.jpg");

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("Vasitaarac4_0.png");

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("İkinciel4_0.png");

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("sanayi4_0.png");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Sanayi4 frm2 = new Sanayi4();
            frm2.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Emlakev4 frm2 = new Emlakev4();
            frm2.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Vasitaarac4 frm2 = new Vasitaarac4();
            frm2.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Ikinciel4 frm2 = new Ikinciel4();
            frm2.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Kategoriler frm2 = new Kategoriler();
            frm2.Show();
            this.Hide();
        }
    }
}
