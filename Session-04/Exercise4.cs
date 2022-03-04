using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise4
    {
        public Exercise4()
        {

        }

        public void Multiplication()
        {
            int[] firstArray = { 2, 4, 9, 12 };
            int[] secondArray = { 1, 3, 7, 10 };
            int[] thirdArray = new int[firstArray.Length * secondArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    thirdArray[i * firstArray.Length + j] = firstArray[i] * secondArray[j];
                    Console.Write("{0} ", thirdArray[i * firstArray.Length + j]);
                }
            }
            
        }
    }
}
