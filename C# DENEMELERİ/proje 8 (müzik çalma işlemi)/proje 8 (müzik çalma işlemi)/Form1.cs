using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_8__müzik_çalma_işlemi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Hasan Emre\\Music\\Baba Yak.m4a";
            pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\1.jpg";



        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Hasan Emre\\Music\\Dest & Chef Bi - Lavinia.m4a";
            pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\1.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Hasan Emre\\Music\\Bilal Sonses & Arda Han - Dayanırım (Official Video).m4a";
            pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\1.jpg";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Hasan Emre\\Music\\Bilal Sonses & Yıldız Tilbe - Hasbelkader (Official Video).m4a";
            pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\1.jpg";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Hasan Emre\\Music\\Hidra - Ölüme İnat.m4a";
            pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\1.jpg";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Hasan Emre\\Music\\Taladro - Olsun (Official Video).m4a";
            pictureBox1.ImageLocation = "C:\\Users\\Hasan Emre\\Documents\\C# Fotoğraflar\\1.jpg";
        }
    }
}
