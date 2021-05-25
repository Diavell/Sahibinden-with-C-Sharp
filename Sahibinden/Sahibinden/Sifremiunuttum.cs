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
    public partial class Sifremiunuttum : Form
    {
        public Sifremiunuttum()
        {
            InitializeComponent();
        }

        private void Sifremiunuttum_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string eposta = "";
                string sifre = "";
                string[] uyelik = System.IO.File.ReadAllLines("Uyelik.txt");
                foreach (string str in uyelik)
                {
                    eposta = (str.Split(',')[2]);
                    sifre = (str.Split(',')[3]);
                }
                if (eposta == textBox1.Text)
                {
                    label2.Text = "Şifreniz";
                    label3.Text = sifre;
                }
                else
                {
                    MessageBox.Show("Bu e-posta adresiyle kayıtlı bir üyelik bulunamadı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Üye Değilsiniz!");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            UyeGirisi frm2 = new UyeGirisi();
            frm2.Show();
            this.Hide();
        }
    }
}
