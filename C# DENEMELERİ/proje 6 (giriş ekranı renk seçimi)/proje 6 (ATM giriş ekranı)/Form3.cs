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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Kırmızı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "rengini seçtiniz";
                button2.BackColor = Color.Red;
            }
            if (comboBox1.Text == "Siyah") 
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "rengini seçtiniz";
                button2.BackColor = Color.Black;
            }
            if (comboBox1.Text == "Mavi") 
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "rengini seçtiniz";
                button2.BackColor = Color.Blue;
            }
            if (comboBox1.Text == "Sarı") 
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "rengini seçtiniz";
                button2.BackColor = Color.Yellow;
            }
            if (comboBox1.Text == "Yeşil") 
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "rengini seçtiniz";
                button2.BackColor = Color.Green;
            }


        }
    }
}
