using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Component;

namespace Demo_20190927
{
    public partial class Form1 : Form
    {
        Calculator.Component.Calculator myCalculator = new Calculator.Component.Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowResult(string op, int x, int y, int result)
        {
            listBox1.Items.Add(string.Format("{0} {3} {1} = {2}", x, y, result, op));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string op = button1.Text;
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int result = myCalculator.Add(x, y);
            ShowResult(op, x, y, result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string op = button1.Text;
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int result = myCalculator.Sub(x, y);
            
            listBox1.Items.Add(string.Format("{0} - {1} = {2}", x, y, result));
        }
    }
}
