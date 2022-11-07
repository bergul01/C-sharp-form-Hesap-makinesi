using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        double ekranSayisiIlk = 0;
        double ekranSayisiSon = 0;
        bool ekranTemizle = false;
        char secim;

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                ekranTemizle = false;
                lblEkran.Text = "";
            }

            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "2";
        }

        private void buttonPayda_Click(object sender, EventArgs e)
        {
            ekranSayisiIlk = Convert.ToDouble(lblEkran.Text);
            ekranTemizle = true;
            secim = '1';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                ekranTemizle = false;
                lblEkran.Text = "";
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                ekranTemizle = false;
                lblEkran.Text = "";
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                ekranTemizle = false;
                lblEkran.Text = "";
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                ekranTemizle = false;
                lblEkran.Text = "";
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                ekranTemizle = false;
                lblEkran.Text = "";
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                ekranTemizle = false;
                lblEkran.Text = "";
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                ekranTemizle = false;
                lblEkran.Text = "";
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                ekranTemizle = false;
                lblEkran.Text = "";
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                ekranTemizle = false;
                lblEkran.Text = "";
            }
            if (lblEkran.Text == "0")
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "0";
        }

        private void buttonAlDelete_Click(object sender, EventArgs e)
        {
            lblEkran.Text = "";
        }

        private void buttonArtı_Click(object sender, EventArgs e)
        {
            ekranSayisiIlk = Convert.ToDouble(lblEkran.Text);
            ekranTemizle = true;
            secim = '+';
        }

        private void buttonEsittir_Click(object sender, EventArgs e)
        {
            ekranSayisiSon = Convert.ToDouble(lblEkran.Text);
            ekranTemizle = true;
            double sonuc = 0;

            switch (secim)
            {
                case '+': sonuc = ekranSayisiIlk + ekranSayisiSon;
                    break;
                case '-':
                    sonuc = ekranSayisiIlk - ekranSayisiSon;
                    break;
                case '*':
                    sonuc = ekranSayisiIlk * ekranSayisiSon;
                    break;
                case '/':
                    sonuc = ekranSayisiIlk / ekranSayisiSon;
                    break;
                case '1':
                    sonuc = 1 / ekranSayisiIlk;
                    break;
                case '%':
                    sonuc = ekranSayisiIlk * (ekranSayisiSon / 100);
                    break;
                case '2':
                    sonuc = Math.Pow(ekranSayisiIlk, 2);
                    break;
                case '3':
                    sonuc = Math.Sqrt(ekranSayisiIlk);
                    break;
            }
            lblEkran.Text = sonuc.ToString();
            ekranTemizle = true;

        }

        private void buttonEksi_Click(object sender, EventArgs e)
        {
            ekranSayisiIlk = Convert.ToDouble(lblEkran.Text);
            ekranTemizle = true;
            secim = '-';
        }

        private void buttonCarpma_Click(object sender, EventArgs e)
        {
            ekranSayisiIlk = Convert.ToDouble(lblEkran.Text);
            ekranTemizle = true;
            secim = '*';
        }

        private void buttonBolme_Click(object sender, EventArgs e)
        {
            ekranSayisiIlk = Convert.ToDouble(lblEkran.Text);
            ekranTemizle = true;
            secim = '/';
        }

        private void buttonYuzde_Click(object sender, EventArgs e)
        {
            ekranSayisiIlk = Convert.ToDouble(lblEkran.Text);
            ekranTemizle = true;
            secim = '%';
        }

        private void buttonUstu_Click(object sender, EventArgs e)
        {
            ekranSayisiIlk = Convert.ToDouble(lblEkran.Text);
            ekranTemizle = true;
            secim = '2';
        }

        private void buttonKok_Click(object sender, EventArgs e)
        {
            ekranSayisiIlk = Convert.ToDouble(lblEkran.Text);
            ekranTemizle = true;
            secim = '3';
        }
    }
}
