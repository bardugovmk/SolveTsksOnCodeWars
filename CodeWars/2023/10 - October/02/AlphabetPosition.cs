using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._2023._10___October._02
{
    internal class Kata2
    {
        public static string AlphabetPosition(string text)
        {
            string text2 = "";
            foreach (char c in text.ToLower())
            {
                if (((int)c >= 65 && (int)c <= 90) ||
                    ((int)c >= 97 && (int)c <= 122))
                    text2 += ((int)c - 96) + " ";
            }
            text = "";
            for (int i = 0; i < text2.Length - 1; i++)
            {
                text += text2[i];
            }
            return text;
        }
    }
}
