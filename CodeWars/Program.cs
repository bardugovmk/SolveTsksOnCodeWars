using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
            //Console.WriteLine(Kata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }));
            //Console.WriteLine(Kata.IsValidWalk(new string[] { "w" }));
            //Console.WriteLine(Kata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));

            Console.WriteLine(Kata.IsValidWalk(new string[] { "n", "s", "e", "w", "n", "s", "e", "w", "n", "s" }));

        }
    } 
}