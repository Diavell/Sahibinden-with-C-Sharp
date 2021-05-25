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
    public partial class Ay : Form
    {
        public Ay()
        {
            InitializeComponent();
        }

        private void Ay_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Ay.png");

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Ev5.jpg");

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("Hayvanlar1_0.png");

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("Hayvanlar2_0.png");

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("Yedekparca1_0.png");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Yedekparca1 frm2 = new Yedekparca1();
            frm2.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Emlakev5 frm2 = new Emlakev5();
            frm2.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Hayvanlar1 frm2 = new Hayvanlar1();
            frm2.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Hayvanlar2 frm2 = new Hayvanlar2();
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
