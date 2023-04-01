using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nammasp
{

    public static class Classe1
    {
        public static string Primo(string input, int key)
        {
            string output = "";

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        public static void Main(String[] args)
        {
        }
    }
}
