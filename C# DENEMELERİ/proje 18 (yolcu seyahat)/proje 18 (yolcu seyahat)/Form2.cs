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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox3.Text);
            listBox2.Items.Add("1");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);
            if(radioButton1 != null)
            {
                listBox6.Items.Add("Bay");
            }
            else
            {
                listBox6.Items.Add("Bayan");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox3.Text);
            listBox2.Items.Add("2");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);
            if (radioButton1 != null)
            {
                listBox6.Items.Add("Bay");
            }
            else
            {
                listBox6.Items.Add("Bayan");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox3.Text);
            listBox2.Items.Add("3");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);
            if (radioButton1 != null)
            {
                listBox6.Items.Add("Bay");
            }
            else
            {
                listBox6.Items.Add("Bayan");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox3.Text);
            listBox2.Items.Add("4");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);
            if (radioButton1 != null)
            {
                listBox6.Items.Add("Bay");
            }
            else
            {
                listBox6.Items.Add("Bayan");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox3.Text);
            listBox2.Items.Add("5");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);
            if (radioButton1 != null)
            {
                listBox6.Items.Add("Bay");
            }
            else
            {
                listBox6.Items.Add("Bayan");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox3.Text);
            listBox2.Items.Add("6");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);
            if (radioButton1 != null)
            {
                listBox6.Items.Add("Bay");
            }
            else
            {
                listBox6.Items.Add("Bayan");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox3.Text);
            listBox2.Items.Add("7");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);
            if (radioButton1 != null)
            {
                listBox6.Items.Add("Bay");
            }
            else
            {
                listBox6.Items.Add("Bayan");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox3.Text);
            listBox2.Items.Add("8");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);
            if (radioButton1 != null)
            {
                listBox6.Items.Add("Bay");
            }
            else
            {
                listBox6.Items.Add("Bayan");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
