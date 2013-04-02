using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            calculator = new Calculator();
            InitializeComponent();          
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            calculator.GetNewNumber(1);
            textBox.Text = calculator.GetNumber().ToString();
        }

        private Calculator calculator;

        private void button_2_Click(object sender, EventArgs e)
        {
            calculator.GetNewNumber(2);
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            calculator.GetNewNumber(3);
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            calculator.GetNewNumber(4);
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            calculator.GetNewNumber(5);
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            calculator.GetNewNumber(6);
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            calculator.GetNewNumber(7);
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            calculator.GetNewNumber(8);
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            calculator.GetNewNumber(9);
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            calculator.GetNewNumber(0);
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            calculator.Reset();
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            calculator.Count();
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            calculator.Add();
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            calculator.Divide();
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            calculator.Miltiply();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            calculator.Subtract();
        }
    }
}
