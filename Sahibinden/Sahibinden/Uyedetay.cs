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
    public partial class Uyedetay : Form
    {
        public Uyedetay()
        {
            InitializeComponent();
        }

        private void Uyedetay_Load(object sender, EventArgs e)
        {
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("Logo.jpg");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile("UstBaslik.jpg");
            radioButton1.Checked = true;
        }
        public static string cinsiyet;
        private void button1_Click(object sender, EventArgs e)
        {
            string il = comboBox1.Text;
            string ilce = comboBox2.Text;
            string mahalle = comboBox3.Text;
            string tel = textBox1.Text;
            string egitim = comboBox4.Text;
            if (il=="Seçiniz"||ilce=="Seçiniz"||mahalle=="Seçiniz"||tel==""||egitim=="Seçiniz")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
            }
            else
            {
                MessageBox.Show("Üyelik Başarıyla Tamamlandı");
                MessageBox.Show("Giriş yap sayfasına yönlendiriliyorsunuz");

                StreamWriter uyelik = File.AppendText("Uyelik.txt");
                uyelik.Write(il + ",");
                uyelik.Write(ilce + ",");
                uyelik.Write(mahalle + ",");
                uyelik.Write(tel + ",");
                uyelik.Write(cinsiyet + ",");
                uyelik.Write(egitim + ",");
                
                uyelik.Close();

                UyeGirisi frm4 = new UyeGirisi();
                frm4.Show();
                this.Close();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                cinsiyet = "";
                cinsiyet = "Erkek";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                cinsiyet = "";
                cinsiyet = "Kadın";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "İstanbul")
            {
                comboBox2.Items.Clear();
                string[] isimler = System.IO.File.ReadAllLines("Istanbul.txt");

                foreach (string str in isimler)
                {
                    comboBox2.Items.Add(str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[3]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[4]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[5]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[6]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[7]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[8]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[9]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[10]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[11]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[12]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[13]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[14]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[15]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[16]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[17]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[18]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[19]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[20]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[21]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[22]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[23]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[24]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[25]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[26]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[27]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[28]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[29]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[30]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[31]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[32]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[33]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[34]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[35]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[36]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[37]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[38]); Encoding.GetEncoding("windows-1254");
                }
                comboBox3.Items.Clear();
                string[] istanbulmahalle = File.ReadAllLines("Istanbulmahalle.txt");

                foreach (string str in istanbulmahalle)
                {
                    comboBox3.Items.Add(str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[3]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[4]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[5]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[6]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[7]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[8]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[9]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[10]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[11]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[12]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[13]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[14]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[15]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[16]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[17]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[18]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[19]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[20]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[21]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[22]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[23]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[24]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[25]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[26]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[27]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[28]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[29]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[30]); Encoding.GetEncoding("windows-1254");
                }
            }
            if (comboBox1.Text == "İzmir")
            {
                comboBox2.Items.Clear();
                string[] izmir = File.ReadAllLines("Izmir.txt");

                foreach (string str in izmir)
                {
                    comboBox2.Items.Add(str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[3]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[4]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[5]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[6]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[7]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[8]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[9]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[10]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[11]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[12]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[13]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[14]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[15]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[16]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[17]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[18]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[19]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[20]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[21]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[22]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[23]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[24]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[25]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[26]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[27]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[28]); Encoding.GetEncoding("windows-1254");
                    comboBox2.Items.Add(str.Split(',')[29]); Encoding.GetEncoding("windows-1254");
                }
                comboBox3.Items.Clear();
                string[] izmirmahalle = File.ReadAllLines("Izmirmahalle.txt");

                foreach (string str in izmirmahalle)
                {
                    comboBox3.Items.Add(str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[3]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[4]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[5]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[6]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[7]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[8]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[9]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[10]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[11]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[12]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[13]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[14]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[15]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[16]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[17]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[18]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[19]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[20]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[21]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[22]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[23]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[24]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[25]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[26]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[27]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[28]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[29]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[30]); Encoding.GetEncoding("windows-1254");
                }
            }
                    if (comboBox1.Text == "Ankara")
                    {
                        comboBox2.Items.Clear();
                        string[] ankara = File.ReadAllLines("Ankara.txt");

                        foreach (string str in ankara)
                        {
                            comboBox2.Items.Add(str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[3]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[4]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[5]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[6]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[7]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[8]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[9]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[10]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[11]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[12]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[13]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[14]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[15]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[16]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[17]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[18]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[19]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[20]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[21]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[22]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[23]); Encoding.GetEncoding("windows-1254");
                            comboBox2.Items.Add(str.Split(',')[24]); Encoding.GetEncoding("windows-1254");
                        }
                        comboBox3.Items.Clear();
                        string[] ankaramahalle = File.ReadAllLines("ankaramahalle.txt");

                        foreach (string str in ankaramahalle)
                        {
                            comboBox3.Items.Add(str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[3]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[4]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[5]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[6]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[7]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[8]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[9]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[10]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[11]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[12]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[13]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[14]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[15]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[16]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[17]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[18]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[19]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[20]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[21]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[22]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[23]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[24]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[25]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[26]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[27]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[28]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[29]); Encoding.GetEncoding("windows-1254");
                            comboBox3.Items.Add(str.Split(',')[30]); Encoding.GetEncoding("windows-1254");
                        }
                    }
                
            
        }
    }
}
