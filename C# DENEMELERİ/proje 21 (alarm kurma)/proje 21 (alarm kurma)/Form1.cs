using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_21__alarm_kurma_
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

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int j=0; j < 60; j++)
            {
                comboBox2.Items.Add(j);
            }
            for (int k=0; k < 60; k++)
            {
                comboBox3.Items.Add(k);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.Hour.ToString();
            label4.Text = DateTime.Now.Minute.ToString();
            label9.Text = DateTime.Now.Second.ToString();

            if (comboBox1.Text == label3.Text && comboBox2.Text == label4.Text && comboBox3.Text == label9.Text)  
            {
                timer1.Enabled = false;
                MessageBox.Show("UYANMA VAKTİ !!!");
            }
            
        }
    }
}
