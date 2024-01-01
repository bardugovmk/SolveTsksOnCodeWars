using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars._2024._01___January._01;



namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Kata.IsPrime(0));
            //Console.WriteLine(Kata.IsPrime(1));
            //Console.WriteLine(Kata.IsPrime(2));
            //Console.WriteLine(Kata.IsPrime(-2));
            //Console.WriteLine(Kata.IsPrime(5));

            //BigInteger number = BigInteger.Parse("1234567890"); // Замените на число, которое хотите проверить
            //bool isPrime = IsPrime(number);
            //Console.WriteLine(Kata.IsPrime(2147483648));
            //Console.WriteLine(Kata.IsPrime(-2147483648));
            //Console.WriteLine(Kata.IsPrime(214748361));

            //Console.WriteLine(Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
            //Console.WriteLine(Kata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }));
            //Console.WriteLine(Kata.IsValidWalk(new string[] { "w" }));
            //Console.WriteLine(Kata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));

            Console.WriteLine(Kata.GetReadableTime(0));
            Console.WriteLine(Kata.GetReadableTime(5));
            Console.WriteLine(Kata.GetReadableTime(60));
            Console.WriteLine(Kata.GetReadableTime(86399));

            Console.WriteLine(Kata.GetReadableTime(359999));
            Console.WriteLine(Kata.GetReadableTime(291115));


            //80:51:55
            //string original = "9";
            //original = ":" + original.Insert(0, "0");
            //Console.WriteLine(original);
            //original = original.Insert(0, "39");
            //Console.WriteLine(original);

        }
    } 
}