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
    public partial class Emlakilan : Form
    {
        public Emlakilan()
        {
            InitializeComponent();
        }

        private void Emlakilan_Load(object sender, EventArgs e)
        {

        }
        public static string DosyaYolu;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg; *.png";
            dosya.Title = "İlan Resmi";
            dosya.ShowDialog();
            DosyaYolu = dosya.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = DosyaYolu;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string ilanbaslık = textBox1.Text;
            string ilandetay = textBox2.Text;
            string fiyat = textBox3.Text;
            string brut = textBox4.Text;
            string net = textBox5.Text;
            string odasayisi = comboBox1.Text;
            if (ilandetay != "" || ilandetay != "" || fiyat != "" || brut != "" || net != "" || odasayisi != "" || DosyaYolu != "")
            {
                StreamWriter uyelik = File.AppendText("Emlakilan.txt");
                uyelik.Write(ilanbaslık + ",");
                uyelik.Write(ilandetay + ",");
                uyelik.Write(fiyat + ",");
                uyelik.Write(brut + ",");
                uyelik.Write(net + ",");
                uyelik.Write(odasayisi + ",");
                uyelik.Write(DosyaYolu + ",");
                uyelik.Close();

                MessageBox.Show("İlanınız başarıyla yayınlandı");
                UyeAnasayfa frm2 = new UyeAnasayfa();
                frm2.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            UyeAnasayfa frm2 = new UyeAnasayfa();
            frm2.Show();
            this.Hide();
        }
    }
}
