namespace CalculatorProgram
{
    class Calculator
    {
        public static double DoOperationWithTwoOrMany(List<double> num, string op)
        {
            double result = 0; 
            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    foreach (double nub in num)
                    {
                        result += nub;
                    }
                    break;
                case "s":
                    foreach (double nub in num)
                    {
                        result -= nub;
                    }
                    break;
                case "m":
                    foreach (double nub in num)
                    {
                        result *= nub;
                    }
                    break;
                case "p":
                    if ( num.Count == 2)
                    {
                        result = Math.Pow(num[0], num[1]);
                    }
                    else
                    {
                        result = double.NaN;
                    }
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num[-1] != 0)
                    {
                        result = num[0];
                        for (int i = 0; i < num.Count; i++)
                        {
                            result /= num[i];
                        }
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public static double DoOperationWithOne(double num1, string op)
        {
            double result = 0;
            switch (op)
            {
                case "s":
                    if (num1 >= 0)
                    {
                        result = Math.Sqrt(num1);
                    }
                    break;
                case "p":
                    if (num1 != 0)
                    {
                        result = num1 * num1;
                    }
                    break;
                case "sin":
                    result = Math.Sin(num1);
                    break;
                case "cos":
                    result = Math.Cos(num1);
                    break;
                case "tan":
                    result = Math.Tan(num1);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}

