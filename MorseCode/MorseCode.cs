using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class MorseCode
    {
        static void Main(string[] args)
        {
            string msg = "hello world";
            Console.WriteLine(MorseCode.Transmit(msg));
           
        }

        public static string Transmit(string message)
        {
            string transmit = "";
            //string pattern;

            message = message.Trim().ToUpper();
            char[] cha = message.ToCharArray();

            foreach (char c in cha)
            {
                switch (c)
                {
                    case ' ':
                        transmit += "  ";
                        break;
                    default:
                        break;
                }

                Console.WriteLine(message);
            }
            return transmit;
        }

        //Make a Dictionary for morse code
        static Dictionary<char, string> morse = new Dictionary<char, string>()
            {
                {'a', ".-" },
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."},

                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "...."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {'0', "-----"},
            };
    }
}
