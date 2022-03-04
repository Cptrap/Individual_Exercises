using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise1
    {
        public Exercise1()
        {

        }
        public void Reverse()
        {
            string name = "Stergios Vogiatzis";
            Console.WriteLine(name, "\n");
            

            string reversedName = ReverseStringFor(name);
            Console.WriteLine(reversedName);

            

            string reversedNameLib = ReverseStringLib(name);
            Console.WriteLine(reversedNameLib);
        }
        private string ReverseStringFor(string name)
        {

            char[] charArray = name.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reverse += charArray[i];
            }
            return reverse;

        }
        private string ReverseStringLib(string name)
        {
            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }


    }
}
