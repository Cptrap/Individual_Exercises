namespace Calculator
{
    public class Calc
    {
        //string input = string.Empty;
        //string operand1 = string.Empty;
        //string operand2 = string.Empty;
        //char operation;
        double result = 0.0;
        //int count;
        public Calc()
        {

        }
        public double Compute(int count, string operand1, string operand2, string input, char operation)
        {

            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            switch (count)
            {
                case 1:
                    return result = num1 + num2;


                case 2:
                    return result = num1 - num2;

                case 3:
                    return result = num1 * num2;

                case 4:
                    if (num2 != 0)
                    {
                        return result = num1 / num2;

                    }
                    else
                    {
                        return double.NaN;
                    }

                case 5:
                    return result = Math.Pow(num1, num2);

                case 6:
                    return result = Math.Sqrt(num1);

                default:
                    return double.NaN;
            }
        }
        public void Clear(int count, string operand1, string operand2, string input)
        {

            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            count = 0;
        }

    }
}