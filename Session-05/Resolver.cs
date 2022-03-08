using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public abstract class Resolver:ActionResponse
    {
        public Resolver()
        {
        }
        public abstract string Resolve(string message, MessageLogger logger);

    }
    internal class ConvertResolver : Resolver {
        public ConvertResolver()
        {

        }
        public override string Resolve(string message, MessageLogger logger)
        {
            int num = Convert.ToInt32(message);
            string result = String.Empty;
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            return result;

        }
    }
    internal class UppercaseResolver : Resolver {
        public UppercaseResolver()
        {

        }
        public string LongestWord(string line)
        {
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = String.Empty;
            for(int i=0; i<words.Length; i++)
            {
                string individualWord = words[i];
                if(individualWord.Length > word.Length)
                {
                    word = individualWord;
                }
            }
            string upperWord = word.ToUpper();
            return upperWord;
        }

        public override string Resolve(string message, MessageLogger logger)
        {
            return LongestWord(message);
        }
    }
    internal class ReverseResolver : Resolver {
        public ReverseResolver()
        {

        }
        public override string Resolve(string message, MessageLogger logger)
        {
            if (message.All(char.IsLetter))
            {
                char[] charArray = message.ToCharArray();
                string reverse = String.Empty;
                for (int i = charArray.Length - 1; i > -1; i--)
                {
                    reverse += charArray[i];
                }
                return reverse;
            }
            else
            {
                return message;

            }
        }
    }
}
