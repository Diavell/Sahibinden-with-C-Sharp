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
    public partial class Ozelders : Form
    {
        public Ozelders()
        {
            InitializeComponent();
        }

        private void Ozelders_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Ozelders1_0.png");

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Ozelders2_0.png");

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("Ozelders3_0.png");

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("Ozelders4_0.png");

            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("Logo.jpg");

            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile("UstBaslik.jpg");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Ozelders1 frm2 = new Ozelders1();
            frm2.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Ozelders2 frm2 = new Ozelders2();
            frm2.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Ozelders3 frm2 = new Ozelders3();
            frm2.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Ozelders4 frm2 = new Ozelders4();
            frm2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kategoriler frm2 = new Kategoriler();
            frm2.Show();
            this.Hide();
        }
    }
}
