using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._2023._10___October._02
{
    internal class Kata
    {
        public static int Find(int[] integers)
        {
            int count = 0;
            int count2 = 0;
            for (int i = 0; i < 3; i++)
            {
                if (integers[i] % 2 == 0) count++;
                else count2++;
            }
            int imposter = 0;
            if (count > count2)
            {
                for (int i = 0; i < integers.Length; i++)
                {
                    if (integers[i] % 2 == 1)
                    {
                        imposter = integers[i];
                    }
                }
                return imposter;
            }
            else
            {
                for (int i = 0; i < integers.Length; i++)
                {
                    if (integers[i] % 2 == 0)
                    {
                        imposter = integers[i];
                    }
                }
                return imposter;
            }
        }
    }
}