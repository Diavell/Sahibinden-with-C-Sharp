using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sahibinden
{
    public partial class Emlakev1 : Form
    {
        public Emlakev1()
        {
            InitializeComponent();
        }

        private void Emlakev1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Ev1.png");

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Emlakev1_1.png");

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("Emlakev1_2.png");

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("Emlakev1_3.png");

            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("Emlak360_3.png");

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("Ev1.png");
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Emlakev1_1.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Emlakev1_2.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Emlakev1_3.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Ev1.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Emlak frm2 = new Emlak();
            frm2.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter uyelik = File.AppendText("Favorilerim1.txt");
            uyelik.Write("Emlakev1" + ",");
            uyelik.Close();
            MessageBox.Show("İlan favorilerinize eklendi");
        }
    }
}
