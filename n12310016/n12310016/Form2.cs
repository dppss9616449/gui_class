using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n12310016
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Int32.Parse(textBox1.Text);
            int f = c *(9/ 5) +32;
            label2.Text = f.ToString() + "度F";
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
 