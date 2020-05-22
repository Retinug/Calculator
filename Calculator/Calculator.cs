using System;

namespace Calculator
{
    delegate void CalculatorUpdateOutput(Calculator sender, double value, int precision);
    delegate void CalculatorInternalError(Calculator sender, string message);

    enum CalculatorUnOperations {Invert  }
    enum CalculatorOperations { Add, Sub, Mul, Div, Eq }
    

    class Calculator
    {
        double? input = null;
        double? result = null;

        int? fractionDigits = null;

        CalculatorOperations? op = null;

        public event CalculatorUpdateOutput didUpdateValue;
        public event CalculatorInternalError InputError;
        public event CalculatorInternalError ComputationError;
        public void AddDigit(int digit) 
        {
            if (fractionDigits.HasValue == false)
            {
                if (input.HasValue && Math.Log10(input.Value) > 10)
                {
                    InputError?.Invoke(this, "Value is too long for this calculator");
                    return;
                }
                input = (input ?? 0) * 10 + digit;
            }
            else
            {
                fractionDigits++;
                input = (input ?? 0) + digit * Math.Pow(10, -fractionDigits.Value);
                
            }
            didUpdateValue?.Invoke(this, input.Value, fractionDigits ?? 0);
        }

        public void AddPoint()
        {
            fractionDigits = 0;
        }

        public void TransFormInput(CalculatorUnOperations op)
        {
            input = input ?? 0;
            switch (op)
            {
                case CalculatorUnOperations.Invert:
                        input = -input;
                    break;
            }
            didUpdateValue?.Invoke(this, input.Value, fractionDigits ?? 0);

        }

        public void AddOperation(CalculatorOperations op)
        {
            if (this.op.HasValue && input.HasValue && result.HasValue)
            {
                Compute();
                this.op = null;
            }
            else
                this.op = op;

            if (input.HasValue)
            {
                result = input;
                Clear();
            }
        }

        public void Compute()
        {
            switch(op)
            {
                case CalculatorOperations.Add:
                    result = result + input;
                    didUpdateValue?.Invoke(this, result.Value, 0);
                    input = null;
                    break;

                case CalculatorOperations.Sub:
                    result = result - input;
                    didUpdateValue?.Invoke(this, result.Value, 0);
                    input = null;
                    break;

                case CalculatorOperations.Mul:
                    result = result * input;
                    didUpdateValue?.Invoke(this, result.Value, 0);
                    input = null;
                    break;

                case CalculatorOperations.Div:
                    if(input.HasValue && input.Value == 0)
                    {
                        ComputationError?.Invoke(this, "Division by Zero");
                    }
                    else
                    {
                        result = result / input;
                        didUpdateValue?.Invoke(this, result.Value, 0);
                        input = null;
                    }
                    break;

                
            }
        }

        public void Clear()
        {
            input = 0;
            //hasPoint = false;
            fractionDigits = null;
            didUpdateValue?.Invoke(this, 0, 0);
        }
    }
}
