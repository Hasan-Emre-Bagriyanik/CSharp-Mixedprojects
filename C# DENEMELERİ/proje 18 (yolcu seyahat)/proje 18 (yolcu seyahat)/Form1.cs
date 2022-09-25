using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_18__yolcu_seyahat_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "hataylı"  &&  textBox2.Text == "2003")
            {
                Form3 seyahat = new Form3();
                seyahat.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız !!!   Tekrar Deneyiniz ");
                textBox1.Clear();
                textBox2.Clear();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
