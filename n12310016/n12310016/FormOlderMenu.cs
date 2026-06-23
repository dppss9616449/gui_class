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
    public partial class FormOlderMenu : Form
    {
        public FormOlderMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currenDate = DateTime.Now;
            string formattedDateTime = currenDate.ToString("yyyyy/MM/dd HH:MM:ss");
            string food = "", sidFood = "", drink = "", dessert = "";

            foreach (var item in drink)
            {
                
            }


















        }
        
    }       
    
}
