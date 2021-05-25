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
    public partial class Favorilerim : Form
    {
        public Favorilerim()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            UyeAnasayfa frm2 = new UyeAnasayfa();
            frm2.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string str in uyelik)
                {
                    favori1 = (str.Split(',')[0]);
                }
                if (favori1 == "Emlakev1")
                {
                    Emlakev1 frm2 = new Emlakev1();
                    frm2.Show();
                    this.Hide();
                }
                else if (favori1 == "Emlakev2")
                {
                    Emlakev2 frm2 = new Emlakev2();
                    frm2.Show();
                    this.Hide();
                }
                else if (favori1 == "Emlakev3")
                {
                    Emlakev3 frm2 = new Emlakev3();
                    frm2.Show();
                    this.Hide();
                }
                else if (favori1 == "Emlakev4")
                {
                    Emlakev4 frm2 = new Emlakev4();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Favori sekmeniz boş");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favori sekmeniz boş");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string str in uyelik)
                {
                    favori2 = (str.Split(',')[1]);
                }
                if (favori2 == "Emlakev2")
                {
                    Emlakev2 frm2 = new Emlakev2();
                    frm2.Show();
                    this.Hide();
                }
                else if (favori2 == "Emlakev1")
                {
                    Emlakev1 frm2 = new Emlakev1();
                    frm2.Show();
                    this.Hide();
                }
                else if (favori2 == "Emlakev3")
                {
                    Emlakev3 frm2 = new Emlakev3();
                    frm2.Show();
                    this.Hide();
                }
                else if (favori2 == "Emlakev4")
                {
                    Emlakev4 frm2 = new Emlakev4();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Favori sekmeniz boş");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favori sekmeniz boş");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string str in uyelik)
                {
                    favori3 = (str.Split(',')[2]);
                }
                if (favori1 == "Emlakev1")
                {
                    Emlakev1 frm2 = new Emlakev1();
                    frm2.Show();
                    this.Hide();
                }
                else if (favori3 == "Emlakev2")
                {
                    Emlakev2 frm2 = new Emlakev2();
                    frm2.Show();
                    this.Hide();
                }
                else if (favori3 == "Emlakev3")
                {
                    Emlakev3 frm2 = new Emlakev3();
                    frm2.Show();
                    this.Hide();
                }
                else if (favori3 == "Emlakev4")
                {
                    Emlakev4 frm2 = new Emlakev4();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Favori sekmeniz boş");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favori sekmeniz boş");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string str in uyelik)
                {
                    favori4 = (str.Split(',')[3]);
                }
                    if (favori4 == "Emlakev1")
                {
                    Emlakev1 frm2 = new Emlakev1();
                    frm2.Show();
                    this.Hide();
                }
                else if (favori4 == "Emlakev2")
                {
                    Emlakev2 frm2 = new Emlakev2();
                    frm2.Show();
                    this.Hide();
                }
                else if (favori4 == "Emlakev3")
                {
                    Emlakev3 frm2 = new Emlakev3();
                    frm2.Show();
                    this.Hide();
                }
                else if (favori4 == "Emlakev4")
                {
                    Emlakev4 frm2 = new Emlakev4();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Favori sekmeniz boş");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favori sekmeniz boş");
            }
            
        }
        public static string favori1 = "";
        public static string favori2 = "";
        public static string favori3 = "";
        public static string favori4 = "";
        public static string[] uyelik = System.IO.File.ReadAllLines("Favorilerim1.txt");
        private void Favorilerim_Load(object sender, EventArgs e)
        {
            
        }
    }
}
