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
    public partial class Emlakilan1 : Form
    {
        public Emlakilan1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Emlak frm2 = new Emlak();
            frm2.Show();
            this.Hide();
        }
        Random rnd = new Random();
        private void Emlakilan1_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox6.Image = Image.FromFile("Emlak360_3.png");

                string ilanbaslık = "";
                string ilandetay = "";
                string fiyat = "";
                string brut = "";
                string net = "";
                string odasayisi = "";
                string dosyayolu = "";
                string ad = "";
                string soyad = "";
                string tel = "";
                int ilanno = rnd.Next(800000000, 900000000);
                DateTime bugun = DateTime.Now;


                string[] uyelik2 = System.IO.File.ReadAllLines("Emlakilan.txt");
                foreach (string str in uyelik2)
                {
                    ilanbaslık = (str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                    ilandetay = (str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                    fiyat = (str.Split(',')[2]); Encoding.GetEncoding("windows-1254");
                    brut = (str.Split(',')[3]); Encoding.GetEncoding("windows-1254");
                    net = (str.Split(',')[4]); Encoding.GetEncoding("windows-1254");
                    odasayisi = (str.Split(',')[5]); Encoding.GetEncoding("windows-1254");
                    dosyayolu = (str.Split(',')[6]); Encoding.GetEncoding("windows-1254");
                }

                label1.Text = ilanbaslık;
                label25.Text = ilandetay;
                label2.Text = fiyat;
                label18.Text = brut;
                label19.Text = net;
                label20.Text = odasayisi;
                label15.Text = ilanno.ToString();
                label16.Text = bugun.ToString();
                string[] uyelik3 = System.IO.File.ReadAllLines("Uyelik.txt");
                foreach (string str in uyelik3)
                {
                    ad = (str.Split(',')[0]); Encoding.GetEncoding("windows-1254");
                    soyad = (str.Split(',')[1]); Encoding.GetEncoding("windows-1254");
                    tel = (str.Split(',')[7]); Encoding.GetEncoding("windows-1254");
                }
                label26.Text = ad + " " + soyad;
                label29.Text = tel;

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(dosyayolu);
            }
            catch (Exception)
            {
                
            }
            

        }
    }
}
