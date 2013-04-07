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
    public partial class CalculatorForm : Form
    {
        
        public CalculatorForm()
        {
            calculator = new Calculator();
            InitializeComponent();          
        }

        private void OnButtonNumberClick(object sender, EventArgs e)
        { 
            int num = Convert.ToInt32(sender.ToString()[sender.ToString().Length - 1]) - 48;
            calculator.GetNewNumber(num);
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void OnButtonResetClick(object sender, EventArgs e)
        {
            calculator.Reset();
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void OnButtonResultClick(object sender, EventArgs e)
        {
            calculator.Count();
            textBox.Text = calculator.GetNumber().ToString();
        }

        private void OnButtonAddClick(object sender, EventArgs e)
        {
            calculator.Add();
        }

        private void OnButtonDivideClick(object sender, EventArgs e)
        {
            calculator.Divide();
        }

        private void OnButtonMultiplyClick(object sender, EventArgs e)
        {
            calculator.Miltiply();
        }

        private void OnButtonMinusClick(object sender, EventArgs e)
        {
            calculator.Subtract();
        }

        private Calculator calculator;
    }
}
