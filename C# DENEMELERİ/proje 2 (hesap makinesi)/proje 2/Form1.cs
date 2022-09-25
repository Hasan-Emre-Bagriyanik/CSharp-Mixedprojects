using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sayı1;
            float sayı2;
            float toplama_sonucu;
            float çarpma_sonucu;
            float çıkarma_sonucu;
            float bölme_sonucu;

            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);

            toplama_sonucu = sayı1 + sayı2;
            çıkarma_sonucu = sayı1 - sayı2;
            çarpma_sonucu = sayı1 * sayı2;
            bölme_sonucu = sayı1 / sayı2;





            label4.Text = toplama_sonucu.ToString();
            label6.Text = çıkarma_sonucu.ToString();
            label8.Text = çarpma_sonucu.ToString();
            label10.Text = bölme_sonucu.ToString();


        }
    }
}
