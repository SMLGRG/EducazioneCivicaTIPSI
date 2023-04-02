using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nammasp
{

    public static class Classe1
    {
        public static string Encipher(string input, int key)
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
        public static string Decipher(string input, int key)
        {
            int k = 26 - key;
            return Encipher(input, k);
        }
        //ogni lettera nei char ha un valore fisso 
        public static int calcolaNumeroSomma(string input, int key)
        {
            int output = 0;
            foreach (char ch in input)
            {
                output += ch-96;
            }
            return output*key;
        }

        public static double calcolaNumeroProdotto(string input, int key)
        {
            double output = 1;
            foreach (char ch in input)
            {
                output = output*(ch-96);
            }
            int res = Convert.ToInt32(Math.Ceiling(output /= key));
            return res;
        }

        public static void ScegliFunzione(string input, int key) 
        {
            if (key % 2 == 0)
                calcolaNumeroSomma(input, key);
            else
                calcolaNumeroProdotto(input, key);
        }

        public static void Main(String[] args)
        {
        }
    }
}
