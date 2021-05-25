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
    public partial class UyeGirisi : Form
    {
        public UyeGirisi()
        {
            InitializeComponent();
        }
        public int hak = 3;
        private void UyeGirisi_Load(object sender, EventArgs e)
        {
            sayac = 60;
            hak = 3;
            timer1.Interval = 1000;
            timer1.Start();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("Logo.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UyeOl frm2 = new UyeOl();
            frm2.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                textBox2.PasswordChar = '*';
            }
            else
            {
                textBox2.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string eposta = "";
                string eposta2 = "";
                string sifre = "";
                string sifre2 = "";


                string[] uyelik = System.IO.File.ReadAllLines("Uyelik.txt");
                foreach (string str in uyelik)
                {
                    eposta = (str.Split(',')[2]);
                    sifre = (str.Split(',')[3]);
                }

                if (eposta == textBox1.Text && sifre == textBox2.Text)
                {
                    timer1.Stop();
                    MessageBox.Show("Başarıyla giriş yaptınız.");
                    UyeAnasayfa frm2 = new UyeAnasayfa();
                    frm2.Show();
                    this.Close();
                }
                else
                {
                    string[] uyelik2 = System.IO.File.ReadAllLines("KurumsaUyelik.txt");
                    foreach (string str in uyelik2)
                    {
                        eposta2 = (str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                        sifre2 = (str.Split(',')[3]); Encoding.GetEncoding("windows-1254");
                    }
                    if (eposta2 == textBox1.Text && sifre2 == textBox2.Text)
                    {
                        timer1.Stop();
                        MessageBox.Show("Başarıyla giriş yaptınız.");
                        UyeAnasayfa frm2 = new UyeAnasayfa();
                        frm2.Show();
                        this.Close();
                    }
                    else
                    {
                        hak--;
                        label7.Text = hak.ToString();
                        MessageBox.Show("E-posta veya şifreniz yanlış");
                        if (hak == 0)
                        {
                            button2.Enabled = false;
                            timer1.Stop();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("E-posta veya şifreniz yanlış");
            }
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Stop();
            Sifremiunuttum frm2 = new Sifremiunuttum();
            frm2.Show();
            this.Close();
        }
        public static int sayac = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = sayac.ToString();
            sayac--;
            if (sayac==0)
            {
                timer1.Stop();
                button2.Enabled = false;
                MessageBox.Show("Süreniz dolmuştur");
                Anasayfa frm2 = new Anasayfa();
                frm2.Show();
                this.Close();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Anasayfa frm2 = new Anasayfa();
            frm2.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
