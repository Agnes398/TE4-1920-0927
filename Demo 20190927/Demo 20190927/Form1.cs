using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_20190927
{
    public partial class Form1 : Form
    {
        Calculator myCalculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = myCalculator.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            listBox1.Items.Add(result);
        }
    }
}
