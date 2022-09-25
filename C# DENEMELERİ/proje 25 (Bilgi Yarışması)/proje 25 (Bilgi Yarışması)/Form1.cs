using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_25__Bilgi_Yarışması_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0;
        int doğru = 0;
        int yanlış = 0;
        int süre = 20;

        private void button5_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            süre = 20;
            label12.Text = süre.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            button5.Text = "İLERİ";
            soruno++;
            label2.Text =soruno.ToString();

            if(soruno == 1)
            {
                richTextBox1.Text = "Mustafa Kemal kaç yılında doğmuştur? ";
                button1.Text = "1880";
                button2.Text = "1881";
                button3.Text = "1882";
                button4.Text = "1883";
                
                label4.Text = "1881";
            }

            if(soruno == 2)
            {
                label3.Text = "0";
                richTextBox1.Text = "Türkiye kaç coğrafi bölgeye ayrılır?";
                button1.Text = "7";
                button2.Text = "21";
                button3.Text = "63";
                button4.Text = "81";

                label4.Text = "7";
            }

            if(soruno == 3)
            {
                label3.Text = "0";
                richTextBox1.Text = "Türkiye'nin en büyük yüz ölçümüne sahip ili hangisidir?";
                button1.Text = "İstanbul";
                button2.Text = "Ankara";
                button3.Text = "Erzurum";
                button4.Text = "Konya";

                label4.Text = "Konya";

            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;
            label3.Text = button1.Text;
            
            if(label3.Text==label4.Text)
            {
                MessageBox.Show("Tebrikler doğru cevap");
                doğru++;
                label10.Text =doğru.ToString();
            }
            else
            {
                MessageBox.Show("Üzgünüm yanlış cevap");
                yanlış++;
                label11.Text=yanlış.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;
            label3.Text = button2.Text;
           
            if (label3.Text == label4.Text)
            {
                MessageBox.Show("Tebrikler doğru cevap");
                doğru++;
                label10.Text = doğru.ToString();
            }
            else
            {
                MessageBox.Show("Üzgünüm yanlış cevap");
                yanlış++;
                label11.Text = yanlış.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;
            label3.Text = button3.Text;
           
            if (label3.Text == label4.Text)
            {
                MessageBox.Show("Tebrikler doğru cevap");
                doğru++;
                label10.Text = doğru.ToString();
            }
            else
            {
                MessageBox.Show("Üzgünüm yanlış cevap");
                yanlış++;
                label11.Text = yanlış.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label3.Text = button4.Text;
            
            if (label3.Text == label4.Text)
            {
                MessageBox.Show("Tebrikler doğru cevap");
                doğru++;
                label10.Text = doğru.ToString();
            }
            else
            {
                MessageBox.Show("Üzgünüm yanlış cevap");
                yanlış++;
                label11.Text = yanlış.ToString();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre = Convert.ToInt32(label12.Text);

            süre = süre - 1;
            label12.Text=süre.ToString();
            
            if(süre == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Üzgünüm süreniz bitti !!!");
                yanlış++;
                label11.Text = yanlış.ToString();
            }

        }
    }
}
