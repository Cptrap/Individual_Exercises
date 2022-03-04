using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise2
    {
        public Exercise2()
        {


        }
        public void Calculations()
        {
            Console.Write("Give a number:");
            string input = Console.ReadLine();
            int number;
            if (Int32.TryParse(input, out number))
            {
                number = Convert.ToInt32(input);
                int sum = GetSum(number);
                int product = GetProduct(number);
                Console.WriteLine("The sum is: {0} and the product is: {1}", sum, product);
            }
            else
            {
                Console.WriteLine("You didn't give a number!");
            }
        }
        public int GetProduct(int i)
        {
            int prod = 1;
            for (int j = 1; j <= i; j++)
            {
                prod *= j;
            }
            return prod;
        }
        public int GetSum(int i)
        {
            int sum = 0;
            for (int j = 0; j <= i; j++)
            {
                sum += j;
            }
            return sum;

        }
    }
       
}
