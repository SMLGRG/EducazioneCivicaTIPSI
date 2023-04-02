﻿using System;
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
        public static int calcolaNumero(string input, int key)
        {
            int output = 0;
            foreach (char ch in input)
            {
                output += ch;
                output = output - 96;
            }
            return output*key;
        }

        public static void Main(String[] args)
        {
        }
    }
}
