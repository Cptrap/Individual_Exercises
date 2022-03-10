using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class FinalResult
    {
        public double firstNum = 0.0f;
        public double secondNum = 0.0f;
        public double result = 0.0f;
        private int operatorType = (int)MathOperations.NoOpperator;
        public string ValueAndOperator(int operation, string text)
        {
            operatorType = operation;
            firstNum = Convert.ToDouble(text);
            text = "0";
            return text;
        }
        public string Equals(string text)
        {

            secondNum = Convert.ToDouble(text);
            switch (operatorType)
            {
                case (int)MathOperations.Add:
                    result = firstNum + secondNum;
                    break;
                case (int)MathOperations.Minus:
                    result = firstNum - secondNum;
                    break;
                case (int)MathOperations.Multiply:
                    result = firstNum * secondNum;
                    break;
                case (int)MathOperations.Divide:
                    result = firstNum / secondNum;
                    break;
                case (int)MathOperations.Power:
                    result = Math.Pow(firstNum, secondNum);
                    break;
                case (int)MathOperations.SquareRoot:
                    result = Math.Sqrt(firstNum);
                    break;
            }
            text = result.ToString();
            return text;
        }
    }  
}
