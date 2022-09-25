using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_9__LİG_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        Random random = new Random();

        int gspuan = 0;
        int fbpuan = 0;
        int bjpuan = 0;
        int tspuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = random.Next(0,5);
            int b = random.Next(0,5);
            int c = random.Next(0,5);
            int d = random.Next(0,5);

            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label10.Text = c.ToString();
            label8.Text = d.ToString();


            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 3;
                label20.Text = gspuan.ToString();
            }
            
            if(Convert.ToInt32(label4.Text) < Convert.ToInt32(label5.Text))
            {
                fbpuan = fbpuan + 3;
                label15.Text = fbpuan.ToString();
            }
            if(Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                label20.Text=gspuan.ToString();
                label15.Text=fbpuan.ToString();
            }

            if (Convert.ToInt32(label10.Text) > Convert.ToInt32(label8.Text))
            {
                bjpuan = bjpuan + 3;
                label13.Text=bjpuan.ToString();
            }
            
            if(Convert.ToInt32(label10.Text) < Convert.ToInt32(label8.Text))
            {
                tspuan = tspuan + 3;
                label18.Text=tspuan.ToString();
            }

            if(Convert.ToInt32(label10.Text) == Convert.ToInt32(label8.Text))
            {
                bjpuan = bjpuan + 1;
                tspuan = tspuan + 1;
                label13.Text = bjpuan.ToString();
                label18.Text = tspuan.ToString();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int r = random.Next(0, 5);
            int f = random.Next(0, 5);
            int g = random.Next(0, 5);
            int h = random.Next(0, 5);

            label28.Text = r.ToString();
            label26.Text = f.ToString();
            label23.Text = g.ToString();
            label21.Text = h.ToString();


            if (Convert.ToInt32(label28.Text) > Convert.ToInt32(label26.Text))
            {
                gspuan = gspuan + 3;
                label20.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(label28.Text) < Convert.ToInt32(label26.Text))
            {
                bjpuan = bjpuan + 3;
                label13.Text = bjpuan.ToString();
            }
            if (Convert.ToInt32(label28.Text) == Convert.ToInt32(label26.Text))
            {
                gspuan = gspuan + 1;
                bjpuan = bjpuan + 1;
                label20.Text = gspuan.ToString();
                label13.Text = bjpuan.ToString();
            }

            if (Convert.ToInt32(label23.Text) > Convert.ToInt32(label21.Text))
            {
                fbpuan = fbpuan + 3;
                label15.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label23.Text) < Convert.ToInt32(label21.Text))
            {
                tspuan = tspuan + 3;
                label18.Text = tspuan.ToString();
            }

            if (Convert.ToInt32(label23.Text) == Convert.ToInt32(label21.Text))
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                label15.Text = fbpuan.ToString();
                label18.Text = tspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible=true;
            int x = random.Next(0, 5);
            int z = random.Next(0, 5);
            int w = random.Next(0, 5);
            int q = random.Next(0, 5);

            label38.Text = x.ToString();
            label36.Text = z.ToString();
            label33.Text = w.ToString();
            label31.Text = q.ToString();


            if (Convert.ToInt32(label38.Text) > Convert.ToInt32(label36.Text))
            {
                gspuan = gspuan + 3;
                label20.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(label38.Text) < Convert.ToInt32(label36.Text))
            {
                tspuan = tspuan + 3;
                label18.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label38.Text) == Convert.ToInt32(label36.Text))
            {
                gspuan = gspuan + 1;
                tspuan = tspuan + 1;
                label20.Text = gspuan.ToString();
                label18.Text = tspuan.ToString();
            }

            if (Convert.ToInt32(label33.Text) > Convert.ToInt32(label31.Text))
            {
                fbpuan = fbpuan + 3;
                label15.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label33.Text) < Convert.ToInt32(label31.Text))
            {
                bjpuan = bjpuan + 3;
                label13.Text = bjpuan.ToString();
            }

            if (Convert.ToInt32(label33.Text) == Convert.ToInt32(label31.Text))
            {
                fbpuan = fbpuan + 1;
                bjpuan = bjpuan + 1;
                label15.Text = fbpuan.ToString();
                label13.Text = bjpuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(label20.Text) > Convert.ToInt32(label15.Text) && Convert.ToInt32(label20.Text) > Convert.ToInt32(label13.Text) && Convert.ToInt32(label20.Text) > Convert.ToInt32(label18.Text))
            {
                label40.Text = "GALATASARAY";
            }

            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label20.Text) && Convert.ToInt32(label15.Text) > Convert.ToInt32(label13.Text) && Convert.ToInt32(label15.Text) > Convert.ToInt32(label18.Text))
            {
                label40.Text = "FENERBAHÇE";
            }

            if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label15.Text) && Convert.ToInt32(label13.Text) > Convert.ToInt32(label20.Text) && Convert.ToInt32(label13.Text) > Convert.ToInt32(label18.Text))
            {
                label40.Text = "BEŞİKTAŞ";
            }

            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label15.Text) && Convert.ToInt32(label18.Text) > Convert.ToInt32(label13.Text) && Convert.ToInt32(label18.Text) > Convert.ToInt32(label20.Text))
            {
                label40.Text = "TRABZONSPOR";
            }

        }
    }
}
