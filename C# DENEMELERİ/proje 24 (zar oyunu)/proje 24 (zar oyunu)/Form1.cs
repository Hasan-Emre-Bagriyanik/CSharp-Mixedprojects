using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_24__zar_oyunu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        Random salla = new Random();
        int ToplamOyuncu1;
        int ToplamOyuncu2;
        int Toplam1;
        int Toplam2;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            int a = salla.Next(1,7);
            int b = salla.Next(1,7);

            label2.Text = a.ToString();
            label4.Text = b.ToString();

            Toplam1 = a + b;
            label5.Text = Toplam1.ToString();


            ToplamOyuncu1 = ToplamOyuncu1 + a + b;
            label17.Text = ToplamOyuncu1.ToString();

            if(a== 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\1.jpg";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\2.png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\4.jpg";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\5.png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\6.png";
            }



            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\1.jpg";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\2.png";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\4.jpg";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\5.png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\6.png";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;

            int c = salla.Next(1, 7);
            int d = salla.Next(1, 7);

            label11.Text = c.ToString();
            label9.Text = d.ToString();

            Toplam2 = c + d;
            label7.Text = Toplam2.ToString();


            ToplamOyuncu2 = ToplamOyuncu2 + c + d;
            label13.Text = ToplamOyuncu2.ToString();

            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\1.jpg";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\2.png";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\3.png";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\4.jpg";
            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\5.png";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\6.png";
            }



            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\1.jpg";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\2.png";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\3.png";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\4.jpg";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\5.png";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\6.png";
            }


            if(ToplamOyuncu1 > 100 && ToplamOyuncu1 > ToplamOyuncu2)
            {
                label15.Text = "Kazanan oyuncu 1 tebrikler !!!";
            }

            if (ToplamOyuncu2 > 100 && ToplamOyuncu2 > ToplamOyuncu1)
            {
                label15.Text = "Kazanan oyuncu 2 tebrikler !!!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
