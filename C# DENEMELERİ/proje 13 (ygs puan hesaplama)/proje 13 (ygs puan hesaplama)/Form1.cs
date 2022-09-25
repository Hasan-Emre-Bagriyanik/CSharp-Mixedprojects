using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_13__ygs_puan_hesaplama_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double türkçe, matematik, fen, sosyal;
            double td, ty, md, my, fd, fy, sd, sy, ygs;

            türkçe = Convert.ToDouble(label19.Text);
            matematik = Convert.ToDouble(label20.Text);
            sosyal = Convert.ToDouble(label21.Text);
            fen = Convert.ToDouble(label22.Text);

            td = Convert.ToDouble(textBox1.Text);
            ty = Convert.ToDouble(textBox2.Text);

            md = Convert.ToDouble(textBox6.Text);
            my = Convert.ToDouble(textBox5.Text);

            fd = Convert.ToDouble(textBox12.Text);
            fy = Convert.ToDouble(textBox11.Text);

            sd = Convert.ToDouble(textBox9.Text);
            sy = Convert.ToDouble(textBox8.Text);

            if (ty >= 0)
            {
                türkçe = td - (ty / 4);
                label19.Text = türkçe.ToString();
            }
            

            if(my >= 0)
            {
                matematik = md - (my / 4);
                label20.Text = matematik.ToString();
            }
            


            if(fy >= 0)
            {
                fen = fd - (fy / 4);
                label22.Text= fen.ToString();
            }
            


            if(sy >= 0)
            {
                sosyal = sd - (sy / 4);
                label21.Text = sosyal.ToString();
            }
            

            ygs = 100.160 + (türkçe * 1.999) + (matematik * 3.998) + (sosyal * 1) + (fen * 2.999);
            label17.Text=ygs.ToString();


        }
    }
}
