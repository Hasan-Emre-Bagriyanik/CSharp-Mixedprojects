using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_14__matematiksel_işlemler_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, üs;

            sayı1 =Convert.ToDouble(textBox1.Text);
            sayı2 =Convert.ToDouble(textBox2.Text);

            üs = Math.Pow(sayı1, sayı2);
            label4.Text=üs.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();   
            textBox2.Clear();
            label4.Text = "00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayı3, karakök;

            sayı3 = Convert.ToDouble(textBox3.Text);

            karakök = Math.Sqrt(sayı3);
            label7.Text=karakök.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            label7.Text = "00";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayı4, sayı5, mod;

            sayı4 = Convert.ToDouble(textBox4.Text);
            sayı5 = Convert.ToDouble(textBox5.Text);

            mod = sayı4 % sayı5;
            label9.Text=mod.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            label9.Text = "00";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
