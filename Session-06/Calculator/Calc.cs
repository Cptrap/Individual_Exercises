using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public enum MathOperations
    {
        NoOpperator = 0,
        Add = 1,
        Minus = 2,
        Multiply = 3,
        Divide = 4,
        Power = 5,
        SquareRoot = 6
    }
    public class Calc
    {
        public double firstNum = 0.0f;
        public double secondNum = 0.0f;
        public double result = 0.0f;
        public Calc()
        {

        }
        public string Clear(string text)
        {
            text = "0";
            firstNum = 0.0f;
            secondNum = 0.0f;
            result = 0.0f;
            return text;
        }

    }
}
