using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_20__kronometre_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ssn, sn;

            ssn = Convert.ToInt32(label2.Text);
            sn = Convert.ToInt32(label1.Text);

            ssn++;
            label2.Text = ssn.ToString();

            if(ssn == 100)
            {
                ssn = 0;
                label2.Text = ssn.ToString();
                sn++;
                label1.Text = sn.ToString();
            }
        }
    }
}
