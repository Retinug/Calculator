using System;
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
            calc.didUpdateValue += CalculatorDidUpdateValue;
            calc.InputError += CalculatorError;
            calc.ComputationError += CalculatorError;
            calc.Clear();
        }

        private void CalculatorError(Calculator sender, string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CalculatorDidUpdateValue(Calculator sender, double value, int precision)
        {
            lb_Digit.Text = (value / Math.Pow(value, precision)).ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int digit = -1;

            if (int.TryParse(button.Text, out digit))
            {
                calc.AddDigit(digit);
            }
            else
            {    
                switch (button.Tag)
                {
                    case "Add":
                        calc.AddOperation(CalculatorOperations.Add);
                        break;
                    case "Sub":
                        calc.AddOperation(CalculatorOperations.Sub);
                        break;
                    case "Mul":
                        calc.AddOperation(CalculatorOperations.Mul);
                        break;
                    case "Div":
                        calc.AddOperation(CalculatorOperations.Div);
                        break;
                    case "Eq":
                        calc.AddOperation(CalculatorOperations.Eq);
                        break;
                    case "Invert":
                        calc.TransFormInput(CalculatorUnOperations.Invert);
                        break;
                    case "Point":
                        calc.AddPoint();
                        break;
                }
            }

        }
    }
}
