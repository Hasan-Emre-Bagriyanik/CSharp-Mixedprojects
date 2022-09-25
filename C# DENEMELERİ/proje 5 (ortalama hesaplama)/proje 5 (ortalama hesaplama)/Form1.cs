using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_5__ortalama_hesaplama_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kısa1, kısa2, vize, ödev, final, ort;

            kısa1 =Convert.ToInt32(textBox2.Text);
            kısa2 = Convert.ToInt32(textBox5.Text);
            vize = Convert.ToInt32(textBox3.Text);
            final = Convert.ToInt32(textBox6.Text);
            ödev = Convert.ToInt32(textBox4.Text);

            ort = kısa1 * 0.1 + kısa2 * 0.1 + vize * 0.2 + final * 0.5 + ödev * 0.1;

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(textBox4.Text);
            listBox5.Items.Add(textBox5.Text);
            listBox6.Items.Add(textBox6.Text);
            listBox7.Items.Add(ort);

            if(ort>=50 && final>=40)
            {
                listBox8.Items.Add("GEÇTİ");

            }
            else
            {
                listBox8.Items.Add("KALDI");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
