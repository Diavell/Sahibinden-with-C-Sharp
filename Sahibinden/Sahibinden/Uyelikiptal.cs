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
    public partial class Uyelikiptal : Form
    {
        public Uyelikiptal()
        {
            InitializeComponent();
        }

        private void Uyelikiptal_Load(object sender, EventArgs e)
        {
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("Logo.jpg");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile("UstBaslik.jpg");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eposta = "";
            string sifre = "";

            string[] uyelik = System.IO.File.ReadAllLines("Uyelik.txt");
            foreach (string str in uyelik)
            {
                eposta = (str.Split(',')[2]);
                sifre = (str.Split(',')[3]);
            }
            if (eposta == textBox1.Text && sifre == textBox2.Text)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Üyeliği iptal etmek istediğinizden emin misiniz?", "Üyelik İptali", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    File.Delete("Uyelik.txt");
                    MessageBox.Show("Üyeliğiniz iptal edilmiştir!");
                    Anasayfa frm2 = new Anasayfa();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Üyelik iptali sonlandırıldı!");
                    Uyelikiptal frm2 = new Uyelikiptal();
                    frm2.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("E-posta veya şifreniz yanlış");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Uyeligim frm2 = new Uyeligim();
            frm2.Show();
            this.Hide();
        }
    }
}
