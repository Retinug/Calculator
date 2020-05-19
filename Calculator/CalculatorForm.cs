using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        Calculator calc;
        public CalculatorForm()
        {
            InitializeComponent();
            calc = new Calculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string button = (sender as Button).Name;
            byte digit = 255;
            if (byte.TryParse(button, out digit))
            {
                calc.AddDigit(digit);
            }

        }
    }
}
