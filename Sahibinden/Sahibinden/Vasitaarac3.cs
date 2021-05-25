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
    public partial class Vasitaarac3 : Form
    {
        public Vasitaarac3()
        {
            InitializeComponent();
        }

        private void Vasitaarac3_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Vasitaarac3_0.png");

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Vasitaarac3_1.png");

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("Vasitaarac3_2.png");

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("Vasitaarac3_3.png");

            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("Oto360_2.png");

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("Vasitaarac3_0.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Vasitaarac3_1.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Vasitaarac3_2.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Vasitaarac3_3.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Vasitaarac3_0.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vasita frm2 = new Vasita();
            frm2.Show();
            this.Hide();
        }
    }
}
