using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinası
{
    public partial class Form1 : Form
    {
        int sayı1 = 0, sayı2 = 0, sonuc = 0;
        string i;
        int k = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sonuç(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayıAl("1");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sayıAl("2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sayıAl("3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayıAl("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayıAl("5");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sayıAl("6");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayıAl("7");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayıAl("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sayıAl("9");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            işlem();
            i = "-";
            label10.Text = i;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            işlem();
            i = "/";
            label10.Text = i;


        }

        private void button15_Click(object sender, EventArgs e)
        {
            işlem();
            i = "X";
            label10.Text = i;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayı1 = 0;
            sayı2 = 0;
            sonuc = 0;
            label7.Text = "";
            label10.Text = "";
            label8.Text = "";
            k = 0;
            label4.Text = "";
            label2.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label4.Text != null)
            {
                label4.Text = label4.Text + "0";
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            işlem();
         
            i = "+";
            label10.Text = i;

        }
        public void işlem()
        {
            label10.Text = i;

            if (sayı1 > 0)
            {
                k++;
            }
            if (k == 0)
            {
                sayı1 = Convert.ToInt32(label4.Text);
                label7.Text = sayı1.ToString();
               
                label4.Text = "";
                k++;
            }
            if (k > 1)
            {
                sayı2 = Convert.ToInt32(label4.Text);
                label8.Text = sayı2.ToString();

                label4.Text = "";
            }



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void sayıAl(string sayi)
        {
           
            if (label4.Text != null)
            {
                label4.Text = label4.Text + sayi;
            }
            else if (label4.Text == "0")
            {
                label4.Text = sayi;
            }
        }
        public void sonuç(string islem)
        {
           
            if (islem == "-")
            {
                if (sayı1 > 0 && sayı2 == 0)
                {
                    sayı2 = Convert.ToInt32(label4.Text);
                    label8.Text = sayı2.ToString();
                }
                if (sayı1 > 0 && sayı2 == 0)
                {
                    sonuc = sayı1 - sayı1;
                    label2.Text = sonuc.ToString();
                }
                else
                {
                    sonuc = sayı1 - sayı2;
                    label2.Text = sonuc.ToString();
                }
               
               
            }
            if (islem == "+")
            {
                if (sayı1 > 0 && sayı2 == 0)
                {
                    sayı2 = Convert.ToInt32(label4.Text);
                    label8.Text = sayı2.ToString();
                }
                if (sayı1 > 0 && sayı2 == 0)
                {
                    sonuc = sayı1 + sayı1;
                    label2.Text = sonuc.ToString();
                }
                else
                {
                    sonuc = sayı1 + sayı2;
                    label2.Text = sonuc.ToString();
                }
              
              
            }
            if (islem == "/")
            {
                if (sayı1 > 0 && sayı2 == 0)
                {
                    sayı2 = Convert.ToInt32(label4.Text);
                    label8.Text = sayı2.ToString();
                }
                if (sayı1 > 0 && sayı2 == 0)
                {
                    sonuc = sayı1 / sayı1;
                    label2.Text = sonuc.ToString();
                }
                else
                {
                    sonuc = sayı1 / sayı2;
                    label2.Text = sonuc.ToString();
                }
              
                
            }
            if (islem == "X")
            {
                if (sayı1 > 0 && sayı2 == 0)
                {
                    sayı2 = Convert.ToInt32(label4.Text);
                    label8.Text = sayı2.ToString();
                }
                if (sayı1>0 && sayı2==0)
                {
                    sonuc = sayı1 * sayı1;
                    label2.Text = sonuc.ToString();
                }
                else
                {
                    sonuc = sayı1 * sayı2;
                    label2.Text = sonuc.ToString();
                }
              
                
               
               
            }

            label7.Text = sayı1.ToString();
            if (sayı2==0)
            {
                label8.Text = sayı1.ToString();
            }

            

        }
    }
}
