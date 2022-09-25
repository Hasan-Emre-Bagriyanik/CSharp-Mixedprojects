using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_6__ATM_giriş_ekranı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== "hataylı"  &&  textBox2.Text== "203941")
            {
                Form3 fr3=new Form3();
                fr3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifreniz hatalı !!!   Tekrar Deneyiniz");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
