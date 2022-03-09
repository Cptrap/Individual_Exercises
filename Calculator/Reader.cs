using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Reader
    {
        public string ButtonReader(object sender, string text)
        {

            object button = sender;
            if (text == "0")
            {
                text = string.Empty;
            }
            text += button;
            return text;


        }
    }
}
