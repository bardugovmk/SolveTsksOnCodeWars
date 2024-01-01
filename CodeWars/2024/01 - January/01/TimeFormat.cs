using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._2024._01___January._01
{
    internal class Kata
    {
        public static string GetReadableTime(int seconds)
        {
            string result = "";
            for (int i = 0; i < 3; i++)
            {
                if (i == 2 && ((seconds % 60).ToString().Length == 1))
                {
                    result = result.Insert(0, "0");
                    break;
                }
                result = result.Insert(0, ((seconds % 60).ToString()));

                if ((seconds % 60).ToString().Length == 1) result = result.Insert(0, "0");
                if (i == 2) break;
                if (i != 2) result = result.Insert(0, ":");
                if (i != 1) seconds = seconds / 60;
                if (i == 1)
                {
                    result = result.Insert(0, ((seconds / 60).ToString()));
                }
            }
            return result;
        }
    }
}