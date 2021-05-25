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
    public partial class UyeOlKurumsal : Form
    {
        public UyeOlKurumsal()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        private void UyeOlKurumsal_Load(object sender, EventArgs e)
        {
            textBox6.Enabled = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("Logo.jpg");

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("Dikkat.png");

            radioButton2.Checked = true;

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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                textBox6.Enabled = true;
            }
            if (radioButton4.Checked == true)
            {
                label20.Text = "Vergi No";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                textBox6.Enabled = false;
            }
            if (radioButton3.Checked == true)
            {
                label20.Text = "TC Kimlik No";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                UyeOl frm2 = new UyeOl();
                frm2.Show();
                this.Hide();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hocam çok çok çok uzun süreceği için sadece istanbul ankara ve izmirin ilçelerini ve mahallelerini yaptım.

            if (comboBox2.Text == "İstanbul")
            {
                comboBox3.Items.Clear();
                string[] isimler = System.IO.File.ReadAllLines("Istanbul.txt");

                foreach (string str in isimler)
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
                    comboBox3.Items.Add(str.Split(',')[31]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[32]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[33]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[34]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[35]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[36]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[37]); Encoding.GetEncoding("windows-1254");
                    comboBox3.Items.Add(str.Split(',')[38]); Encoding.GetEncoding("windows-1254");
                }
                comboBox5.Items.Clear();
                string[] istanbulvergi = System.IO.File.ReadAllLines("Istanbulvergi.txt");

                foreach (string str in istanbulvergi)
                {
                    comboBox5.Items.Add(str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                    comboBox5.Items.Add(str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                    comboBox5.Items.Add(str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                }
                comboBox4.Items.Clear();
                string[] istanbulmahalle = File.ReadAllLines("Istanbulmahalle.txt");

                foreach (string str in istanbulmahalle)
                {
                    comboBox4.Items.Add(str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[3]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[4]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[5]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[6]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[7]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[8]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[9]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[10]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[11]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[12]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[13]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[14]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[15]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[16]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[17]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[18]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[19]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[20]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[21]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[22]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[23]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[24]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[25]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[26]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[27]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[28]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[29]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[30]); Encoding.GetEncoding("windows-1254");
                }
            }
            if (comboBox2.Text == "İzmir")
            {
                comboBox3.Items.Clear();
                string[] izmir = File.ReadAllLines("Izmir.txt");

                foreach (string str in izmir)
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
                }
                comboBox5.Items.Clear();
                string[] izmirvergi = File.ReadAllLines("Izmirvergi.txt");

                foreach (string str in izmirvergi)
                {
                    comboBox5.Items.Add(str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                    comboBox5.Items.Add(str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                    comboBox5.Items.Add(str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                }
                comboBox4.Items.Clear();
                string[] izmirmahalle = File.ReadAllLines("Izmirmahalle.txt");

                foreach (string str in izmirmahalle)
                {
                    comboBox4.Items.Add(str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[3]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[4]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[5]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[6]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[7]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[8]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[9]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[10]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[11]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[12]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[13]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[14]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[15]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[16]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[17]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[18]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[19]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[20]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[21]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[22]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[23]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[24]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[25]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[26]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[27]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[28]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[29]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[30]); Encoding.GetEncoding("windows-1254");
                }
            }
            if (comboBox2.Text == "Ankara")
            {
                comboBox3.Items.Clear();
                string[] ankara = File.ReadAllLines("Ankara.txt");

                foreach (string str in ankara)
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
                }
                comboBox5.Items.Clear();
                string[] ankaravergi = File.ReadAllLines("Ankaravergi.txt");

                foreach (string str in ankaravergi)
                {
                    comboBox5.Items.Add(str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                    comboBox5.Items.Add(str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                    comboBox5.Items.Add(str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                }
                comboBox4.Items.Clear();
                string[] ankaramahalle = File.ReadAllLines("ankaramahalle.txt");

                foreach (string str in ankaramahalle)
                {
                    comboBox4.Items.Add(str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[3]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[4]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[5]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[6]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[7]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[8]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[9]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[10]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[11]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[12]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[13]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[14]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[15]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[16]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[17]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[18]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[19]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[20]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[21]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[22]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[23]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[24]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[25]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[26]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[27]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[28]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[29]); Encoding.GetEncoding("windows-1254");
                    comboBox4.Items.Add(str.Split(',')[30]); Encoding.GetEncoding("windows-1254");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string email = textBox3.Text;
            string sifre = textBox4.Text;
            string faaliyet = comboBox1.SelectedItem.ToString();
            string unvan = textBox6.Text;
            string il = comboBox2.SelectedItem.ToString();
            string ilce = comboBox3.SelectedItem.ToString();
            string mahalle = comboBox4.SelectedItem.ToString();
            string adresdetay = textBox7.Text;
            string vergidaire = comboBox5.SelectedItem.ToString();
            string tcvergino = textBox8.Text;
            string tel = textBox9.Text;

            if (radioButton3.Checked==true)
            {
                if (ad == "" || soyad == "" || email == "" || sifre == "" || faaliyet == "" ||  il == "" || ilce == "" || mahalle=="" || adresdetay == "" || vergidaire == "" || tcvergino == "")
                {
                    MessageBox.Show("LÜtfen bilgileri eksiksiz giriniz");
                }

                else if (label5.Text != textBox5.Text)
                {
                    MessageBox.Show("Lütfen güvenlik kodunu doğru giriniz");
                }

                else if (checkBox1.Checked == false)
                {
                    MessageBox.Show("Üyelik Sözleşmesini ve Eklerini kabul etmediniz");
                }
                if (ad != "" || soyad != "" || email != "" || sifre != "" || faaliyet != "" || il != "" || ilce != "" || adresdetay != "" || vergidaire != "" || tcvergino != "" && label5.Text == textBox5.Text && checkBox1.Checked == true)
                {
                    MessageBox.Show("Üyelik Başarıyla Oluşturuldu");
                    MessageBox.Show("Giriş Yap sayfasına yönlendiriliyorsunuz");

                    StreamWriter kurumsaluyelik = File.AppendText("KurumsaUyelik.txt");
                    kurumsaluyelik.Write(ad + ",");
                    kurumsaluyelik.Write(soyad + ",");
                    kurumsaluyelik.Write(email + ",");
                    kurumsaluyelik.Write(sifre + ",");
                    kurumsaluyelik.Write(faaliyet + ",");
                    kurumsaluyelik.Write(il + ",");
                    kurumsaluyelik.Write(ilce + ",");
                    kurumsaluyelik.Write(mahalle + ",");
                    kurumsaluyelik.Write(adresdetay + ",");
                    kurumsaluyelik.Write(vergidaire + ",");
                    kurumsaluyelik.Write(tcvergino + ",");
                    kurumsaluyelik.Write(tel + ",");
                    kurumsaluyelik.Close(); ;
                    

                    UyeGirisi frm4 = new UyeGirisi();
                    frm4.Show();
                    this.Close();
                }
            }
            else if (radioButton4.Checked==true)
            {
                if (ad == "" || soyad == "" || email == "" || sifre == "" || faaliyet == "" || unvan == "" || il == "" || ilce == "" || mahalle == "" || adresdetay == "" || vergidaire == "" || tcvergino == "")
                {
                    MessageBox.Show("LÜtfen bilgileri eksiksiz giriniz");
                }

                else if (label5.Text != textBox5.Text)
                {
                    MessageBox.Show("Lütfen güvenlik kodunu doğru giriniz");
                }

                else if (checkBox1.Checked == false)
                {
                    MessageBox.Show("Üyelik Sözleşmesini ve Eklerini kabul etmediniz");
                }
                if (ad != "" || soyad != "" || email != "" || sifre != "" || faaliyet != "" || unvan != "" || il != "" || ilce != "" || mahalle != "" || adresdetay != "" || vergidaire != "" || tcvergino != "" && label5.Text == textBox5.Text && checkBox1.Checked == true)
                {
                    MessageBox.Show("Üyelik Başarıyla Oluşturuldu");
                    MessageBox.Show("Giriş Yap sayfasına yönlendiriliyorsunuz");

                    StreamWriter kurumsaluyelik = File.AppendText("KurumsaUyelik.txt");
                    kurumsaluyelik.Write(ad + "\n");
                    kurumsaluyelik.Write(soyad + "\n");
                    kurumsaluyelik.Write(email + "\n");
                    kurumsaluyelik.Write(sifre + "\n");
                    kurumsaluyelik.Write(faaliyet + "\n");
                    kurumsaluyelik.Write(unvan + "\n");
                    kurumsaluyelik.Write(il + "\n");
                    kurumsaluyelik.Write(ilce + "\n");
                    kurumsaluyelik.Write(mahalle + "\n");
                    kurumsaluyelik.Write(adresdetay + "\n");
                    kurumsaluyelik.Write(vergidaire + "\n");
                    kurumsaluyelik.Write(tcvergino + "\n");
                    kurumsaluyelik.Write(tel + "\n");
                    kurumsaluyelik.Close();


                    UyeGirisi frm4 = new UyeGirisi();
                    frm4.Show();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("LÜtfen bilgileri eksiksiz giriniz");
            }
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
