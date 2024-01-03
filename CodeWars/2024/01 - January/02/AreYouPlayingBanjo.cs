using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._2024._01___January._02
{
    internal class Kata
    {
        public static string AreYouPlayingBanjo(string name)
        {
            if (name[0] == 'r' || name[0] == 'R')
            {
                return name + " plays banjo";
            }
            else
            {
                return name + " does not play banjo";
            }
        }
    }
}