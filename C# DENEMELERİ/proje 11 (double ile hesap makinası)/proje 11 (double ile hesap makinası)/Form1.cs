using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_11__double_ile_hesap_makinası_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2;
            double toplam, fark, çarpım, bölüm;

            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);

            toplam = sayı1 + sayı2;
            fark = sayı1 - sayı2;
            çarpım = sayı1 * sayı2;
            bölüm = sayı1 / sayı2;

            label7.Text = toplam.ToString();
            label8.Text = fark.ToString();
            label9.Text = çarpım.ToString();
            label10.Text = bölüm.ToString();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label7.Text = "00";
            label8.Text = "00";
            label9.Text = "00";
            label10.Text = "00";
        }
    }
}
