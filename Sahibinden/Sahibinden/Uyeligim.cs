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
    public partial class Uyeligim : Form
    {
        public Uyeligim()
        {
            InitializeComponent();
        }

        private void Uyeligim_Load(object sender, EventArgs e)
        {
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile("UstBaslik.jpg");

            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("Logo.jpg");

            string ad = "";
            string soyad = "";
            string eposta = "";
            string il = "";
            string ilce = "";
            string mahalle = "";
            string tel = "";
            string cinsiyet = "";
            string egitim = "";


            string[] uyelik = System.IO.File.ReadAllLines("Uyelik.txt");
            foreach (string str in uyelik)
            {
                ad = (str.Split(',')[0]);
                soyad = (str.Split(',')[1]);
                eposta = (str.Split(',')[2]);
                il = (str.Split(',')[4]);
                ilce = (str.Split(',')[5]);
                mahalle = (str.Split(',')[6]);
                tel = (str.Split(',')[7]);
                cinsiyet = (str.Split(',')[8]);
                egitim = (str.Split(',')[9]);
            }
            label14.Text = ad;
            label15.Text = soyad;
            label17.Text = eposta;
            label19.Text = il;
            label20.Text = ilce;
            label21.Text = mahalle;
            label18.Text = tel;
            label22.Text = cinsiyet;
            if (egitim=="Seçiniz")
            {
                label23.Text = "";
            }
            else
            {
                label23.Text = egitim;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UyeAnasayfa frm2 = new UyeAnasayfa();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Uyelikiptal frm2 = new Uyelikiptal();
            frm2.Show();
            this.Hide();
        }
    }
}
