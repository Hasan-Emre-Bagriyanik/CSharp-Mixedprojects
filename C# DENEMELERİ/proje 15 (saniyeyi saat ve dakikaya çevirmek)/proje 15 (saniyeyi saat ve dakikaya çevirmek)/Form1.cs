using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_15__saniyeyi_saat_ve_dakikaya_çevirmek_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sn, dk, sa ,sayı ,gün;

            sayı =Convert.ToInt32(textBox1.Text);


            sn = sayı % 60;
            label8.Text = sn.ToString();

            dk = (sayı / 60) % 60;
            label4.Text = dk.ToString();

            sa = ((sayı / 60) / 60) % 60;
            label3.Text = sa.ToString();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label8.Text = "00";
            label4.Text = "00";
            label3.Text = "00";
        }
    }
}
