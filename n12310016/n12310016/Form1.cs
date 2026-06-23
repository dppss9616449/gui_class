using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n12310016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_ClickMe.Text == "按我一下")
                btn_ClickMe.Text = "我已經被點擊過了";
            else if (btn_ClickMe.Text == "我已經被點擊過了")
                btn_ClickMe.Text = "按我一下";

        }

        private void bnt_ChangeLabel_Click(object sender, EventArgs e)
        {
            lab_CangeLabell.Text="按鈕被按過了";
        }

        private void bnt_Counter_Click(object sender, EventArgs e)
        {
            String count = lab_Counter.Text;
            int sum = Int32.Parse(count)+1;
            lab_Counter.Text = sum.ToString();


        }

        private void btnBigger_Click(object sender, EventArgs e)
        {
            new FormBtnBigger().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            label2.Text = str;

        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            new FormCalculator().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FormTimer().Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FormCheckBox().Show();  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new FormLayout().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new FormOlderMenu().Show();
        }
    }
}