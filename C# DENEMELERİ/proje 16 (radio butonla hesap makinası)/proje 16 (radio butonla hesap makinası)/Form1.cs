using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_16__radio_butonla_hesap_makinası_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayı1, sayı2;
        double topla, çıkar, böl, çarp, üs, karakök, mod;

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            mod = sayı1 % sayı2;
            label4.Text = mod.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "00";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            karakök = Math.Sqrt(sayı1);
            label4.Text = karakök.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            üs = Math.Pow(sayı1, sayı2);
            label4.Text = üs.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            çarp = sayı1 * sayı2;
            label4.Text = çarp.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            böl = sayı1 / sayı2;
            label4.Text = böl.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            çıkar = sayı1 - sayı2;
            label4.Text = çıkar.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            topla = sayı1 + sayı2;
            label4.Text = topla.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
                
        }
    }
}
