using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_4__matematiksel_işlemler_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int BKenar;
            int alan, çevre;

            BKenar=Convert.ToInt32(textBox1.Text);

            alan = BKenar * BKenar;
            çevre = 4 * BKenar;

            label4.Text = alan.ToString();
            label5.Text = çevre.ToString();

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label13.Visible = false;
            panel2.Visible = false;
            button2.Visible = true;
            panel1.Visible = true;
            label6.Visible = false;
            textBox2.Visible = false;
            button5.Visible = false;
            label7.Text = "KARE";


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible=false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label13.Visible=false;
            panel2.Visible=false;
            panel1.Visible=true;
            label7.Text = "DİKDÖRTGEN";
            label1.Text = "Kısa Kenar";
            button2.Visible = false;
            button5.Visible = true;
            label6.Visible = true;
            textBox2.Visible=true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int uzun, kısa;
            int alanı, çevresi;

            kısa=Convert.ToInt32(textBox1.Text);
            uzun=Convert.ToInt32(textBox2.Text);

            alanı = uzun * kısa;
            çevresi = (2 * kısa) + (2 * uzun);

            label4.Text=alanı.ToString();
            label5.Text=çevresi.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int yarıçap;
            int alan, çevre;

            yarıçap=Convert.ToInt32(textBox3.Text);

            alan = 3.14 * yarıçap * yarıçap;
            çevre = 2 * 3.14 * yarıçap;

            label12.Text=alan.ToString();
            label10.Text=çevre.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            label7.Visible = false;
            label13.Text = "ÇEMBER";
        }
    }
}
