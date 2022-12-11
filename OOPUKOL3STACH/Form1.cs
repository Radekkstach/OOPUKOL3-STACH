using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPUKOL3STACH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Auto brm;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                brm = new Auto(textBox1.Text, double.Parse(textBox2.Text), (int)numericUpDown1.Value);
                button4.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Neco si nezadal");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brm.Rozjezd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            brm.Zastav((int)numericUpDown2.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = brm.ToString();
            }
            catch
            {
                MessageBox.Show("Nemas co vypsat");
            }
        }
    }
}
