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
    public partial class Hayvanlar3 : Form
    {
        public Hayvanlar3()
        {
            InitializeComponent();
        }

        private void Hayvanlar3_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Hayvanlar3_0.png");

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Hayvanlar3_1.png");

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("Hayvanlar3_2.png");

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("Hayvanlar3_3.png");

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("Hayvanlar3_0.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Hayvanlar3_1.png");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Hayvanlar3_2.png");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Hayvanlar3_3.png");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Hayvanlar3_0.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hayvanlar frm2 = new Hayvanlar();
            frm2.Show();
            this.Hide();
        }
    }
}
