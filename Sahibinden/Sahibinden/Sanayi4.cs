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
    public partial class Sanayi4 : Form
    {
        public Sanayi4()
        {
            InitializeComponent();
        }

        private void Sanayi4_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Sanayi4_0.png");

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Sanayi4_1.png");

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("Sanayi4_2.png");

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("Sanayi4_3.png");

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("Sanayi4_0.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Sanayi4_1.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Sanayi4_2.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Sanayi4_3.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Sanayi4_0.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sanayi frm2 = new Sanayi();
            frm2.Show();
            this.Hide();
        }
    }
}
