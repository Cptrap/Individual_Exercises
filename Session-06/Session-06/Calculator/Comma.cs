using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Comma
    {
        public string Dot(string text)
        {
            if (!(text.Contains(".")))
            {
                return text += ".";
            }
            else { return text; }
        }
    }
}
