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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        private void UyeOl_Load(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Logo.jpg");

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Uyeollogo.png");

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("Dikkat.png");

            radioButton1.Checked = true;

            string karakter1;
            string[] dizi1 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z" };
            int sembol1 = rastgele.Next(0, dizi1.Length);
            karakter1 = (dizi1[sembol1]);

            string karakter2;
            string[] dizi2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int sembol2 = rastgele.Next(0, dizi2.Length);
            karakter2 = (dizi2[sembol2]);

            string karakter3;
            string[] dizi3 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z" };
            int sembol3 = rastgele.Next(0, dizi3.Length);
            karakter3 = (dizi3[sembol3]);

            string karakter4;
            string[] dizi4 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int sembol4 = rastgele.Next(0, dizi4.Length);
            karakter4 = (dizi4[sembol4]);

            label5.Text = karakter1 + karakter2 + karakter3 + karakter4;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                UyeOlKurumsal frm3 = new UyeOlKurumsal();
                frm3.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string email = textBox3.Text;
            string sifre = textBox4.Text;

            if (ad == "" || soyad == "" || email == "" || sifre == "")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
            }

            else if (label5.Text != textBox5.Text)
            {
                MessageBox.Show("Lütfen güvenlik kodunu doğru giriniz");
            }

            else if (checkBox1.Checked == false)
            {
                MessageBox.Show("Üyelik Sözleşmesini ve Eklerini kabul etmediniz");
            }
            else if (ad != "" || soyad != "" || email != "" || sifre != "" && label5.Text == textBox5.Text && checkBox1.Checked == true)
            {
                MessageBox.Show("Üyelik Başarıyla Oluşturuldu");
                MessageBox.Show("Üyelik detayları sayfasına yönlendiriliyorsunuz");

                StreamWriter uyelik = File.AppendText("Uyelik.txt");
                uyelik.Write(ad + ",");
                uyelik.Write(soyad + ",");
                uyelik.Write(email + ",");
                uyelik.Write(sifre + ",");
                uyelik.Close();


                Uyedetay frm4 = new Uyedetay();
                frm4.Show();
                this.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string karakter1;
            string[] dizi1= { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z" };
            int sembol1 = rastgele.Next(0, dizi1.Length);
            karakter1 = (dizi1[sembol1]);

            string karakter2;
            string[] dizi2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int sembol2 = rastgele.Next(0, dizi2.Length);
            karakter2 = (dizi2[sembol2]);

            string karakter3;
            string[] dizi3 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z" };
            int sembol3 = rastgele.Next(0, dizi3.Length);
            karakter3 = (dizi3[sembol3]);

            string karakter4;
            string[] dizi4 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int sembol4 = rastgele.Next(0, dizi4.Length);
            karakter4 = (dizi4[sembol4]);

            label5.Text = karakter1 + karakter2 + karakter3 + karakter4;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Anasayfa frm2 = new Anasayfa();
            frm2.Show();
            this.Hide();
        }
    }
}
