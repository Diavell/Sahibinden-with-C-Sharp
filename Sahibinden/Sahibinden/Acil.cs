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
    public partial class Acil : Form
    {
        public Acil()
        {
            InitializeComponent();
        }

        private void Acil_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Acil.png");

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Ev1.png");

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("Vasitaarac1_0.png");

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("İkinciel1_0.png");

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("sanayi1_0.png");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Sanayi1 frm2 = new Sanayi1();
            frm2.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Emlakev1 frm2 = new Emlakev1();
            frm2.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Vasitaarac1 frm2 = new Vasitaarac1();
            frm2.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Ikinciel1 frm2 = new Ikinciel1();
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
