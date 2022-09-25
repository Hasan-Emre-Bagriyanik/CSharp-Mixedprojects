using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_7__zar_oyunu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rasgele=new Random();
            int a=rasgele.Next(1,7);
            int b=rasgele.Next(1,7);
            label1.Text=a.ToString();
            label2.Text=b.ToString();
        }
    }
}
