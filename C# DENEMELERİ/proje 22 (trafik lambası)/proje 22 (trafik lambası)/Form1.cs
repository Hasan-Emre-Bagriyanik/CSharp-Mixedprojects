using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_22__trafik_lambası_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.BackColor = Color.Red;
        }
        int sayı = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            sayı = Convert.ToInt32(label1.Text);

          
            sayı++;
            label1.Text = sayı.ToString();
           
            if (sayı == 10)
            {
                
                button1.BackColor= Color.White;
                button2.BackColor = Color.Yellow;
            }
            if (sayı == 14)
            {
                button1.BackColor=Color.White;
                button2.BackColor= Color.White;
                button3.BackColor = Color.Green;
            }
            if(sayı == 20)
            {
                sayı = 0;
                label1.Text = sayı.ToString();
                button1.BackColor = Color.Red;
                button3.BackColor= Color.White;
                
                
            }
           


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
