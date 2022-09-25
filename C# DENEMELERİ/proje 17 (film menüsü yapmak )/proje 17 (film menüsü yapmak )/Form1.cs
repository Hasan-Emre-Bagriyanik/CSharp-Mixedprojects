using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_17__film_menüsü_yapmak__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void felektenBirGeceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "dflsdnfjsfnsjbfjhjfjffsnljnbfjvsldknvldkmkdnvlkdmvdm";
            listBox1.Items.Add("Yüzüklerin Efendisi");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void esaretinBedeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "sadfghjjhhhhhhhhhhhhhhhfklkjdklıluguykıuk";
            listBox1.Items.Add("Esareten Bedeli");
            listBox2.Items.Add(toolStripComboBox1.Text);
            

        }

        private void amelieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "dflsdnfjsfnsjbffsnljfjjjjjjjjjjjjjjjjjjjnbfjvsldknvldkmkdnvlkdmvdm";
            listBox1.Items.Add("Amelie");
            listBox2.Items.Add(toolStripComboBox1.Text);

        }

        private void felektenBirGeceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "dflsdnfjsfnsjbffsnljnbfjvslchkllhffhhhhhhhhhhhhhhhhdknvldkmkdnvlkdmvdm";
            listBox1.Items.Add("Felekten Bir Gece");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }
    }
}
