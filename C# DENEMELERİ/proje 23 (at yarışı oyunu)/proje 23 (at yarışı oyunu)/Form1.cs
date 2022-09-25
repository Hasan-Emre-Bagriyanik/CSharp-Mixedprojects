using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_23__at_yarışı_oyunu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        int birincisolauzaklik, ikincisolauzaklik, ucuncusolauzaklik;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayı;
            sayı = Convert.ToInt32(label7.Text);
            sayı++;
            label7.Text = sayı.ToString();


            int birincigenislik = pictureBox1.Width;
            int ikincigenislik = pictureBox2.Width;
            int ucuncugenislik = pictureBox3.Width;

            int bitiscizgisi = label5.Left;

            pictureBox1.Left += rastgele.Next(5, 15);
            pictureBox2.Left += rastgele.Next(5, 15);
            pictureBox3.Left += rastgele.Next(5, 15);

            if(pictureBox1.Left > pictureBox2.Left +5  && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "";
                label6.Text = "1 NUMARALI AT YARIŞI ÖNDE GÖTÜRÜYOR !!!";
            }

            if(pictureBox2.Left > pictureBox1.Left +5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "";
                label6.Text = "2 NUMARALI AT RAKİPLERİNİ GEÇTİ !!!";
            }

            if(pictureBox3.Left > pictureBox2.Left +5  &&  pictureBox3.Left > pictureBox1.Left + 5)
            {
                label6.Text = "";
                label6.Text = "3 NUMARALI AT HIZLI BİR ATAĞA KALKTI !!!";
            }



            if(birincigenislik + pictureBox1.Left >= bitiscizgisi)
            {
                timer1.Enabled = false;
                label6.Text = "YARIŞI BİR NUMARALI AT KAZANDI !!!";
            }

            if (ikincigenislik + pictureBox2.Left >= bitiscizgisi)
            {
                timer1.Enabled = false;
                label6.Text = "YARIŞI İKİ NUMARALI AT KAZANDI !!!";
            }

            if(ikincigenislik + pictureBox3.Left >= bitiscizgisi)
            {
                timer1.Enabled = false;
                label6.Text = "YARIŞI ÜÇ NUMARALI AT KAZANDI !!!";
            }

        }

        Random rastgele =new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            birincisolauzaklik = pictureBox1.Left;
            ikincisolauzaklik = pictureBox2.Left;
            ucuncusolauzaklik = pictureBox3.Left;
        }
    }
}
