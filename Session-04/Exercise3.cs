using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise3
    {
        public Exercise3()
        {

        }
        public void PrimeNumber()
        {
            Console.WriteLine("Enter The Start Number: ");
            string input1 = Console.ReadLine();
            int startNumber;
            Console.WriteLine("Enter the End Number : ");
            string input2 = Console.ReadLine();
            int endNumber;

            if (Int32.TryParse(input1, out startNumber) && Int32.TryParse(input2, out endNumber))
            {
                startNumber = Convert.ToInt32(input1);
                endNumber = Convert.ToInt32(input2);

                Console.WriteLine($"The Prime Numbers between {startNumber} and {endNumber} are : ");
                for (int i = startNumber; i <= endNumber; i++)
                {
                    int counter = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            counter++;
                            break;
                        }
                    }
                    if (counter == 0 && i != 1)
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }
            else
            {
                Console.WriteLine("You didn't give a valid numbers!");
            }
        }
    }
}
