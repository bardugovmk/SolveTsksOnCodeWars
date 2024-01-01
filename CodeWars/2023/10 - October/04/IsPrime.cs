using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CodeWars._2023._10___October._04
{
    internal class Kata
    {
        public static bool IsPrime(decimal n)
        {
            int count = 0;
            if(n < 0)
            {
                return false;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0) count++;
                }
                if (count == 2) return true;
                else return false;
            }
        }
        //public static bool IsPrime2(decimal n)
        //{
        //    // Проверка, что n не является степенью простого числа
        //    for (BigInteger a = 2; a <= Math.Sqrt(n); a++)
        //    {
        //        if (n % a == 0)
        //            return false;
        //    }

        //    // Выбор простого числа r
        //    BigInteger r = 2;
        //    while (r < n)
        //    {
        //        if (BigInteger.GreatestCommonDivisor(r, n) != 1)
        //            return false;

        //        if (IsGoodPower(n, r))
        //            return false;

        //        r++;
        //    }

        //    // Проверка "плохих" коэффициентов
        //    if (IsBadCoefficient(n))
        //        return false;

        //    return true;
        //}

        //private static bool IsGoodPower(BigInteger n, BigInteger r)
        //{
        //    for (int a = 2; a < 4 * Math.Log(n) * Math.Log(n); a++)
        //    {
        //        BigInteger result = BigInteger.ModPow(a, r, n);
        //        if (result == 0 || result == 1)
        //            continue;

        //        for (BigInteger x = r; x < n; x *= r)
        //        {
        //            if (result == n - 1)
        //                break;

        //            result = BigInteger.ModPow(result, r, n);
        //        }

        //        if (result != n - 1)
        //            return true;
        //    }

        //    return false;
        //}

        //private static bool IsBadCoefficient(BigInteger n)
        //{
        //    for (BigInteger a = 1; a <= Math.Sqrt(Phi(n)) * Math.Log(n); a++)
        //    {
        //        BigInteger exponent = BigInteger.ModPow(a, Phi(n), n) - 1;
        //        if (exponent % n != 0)
        //            return true;
        //    }

        //    return false;
        //}

        //private static BigInteger Phi(BigInteger n)
        //{
        //    BigInteger result = n;
        //    for (BigInteger p = 2; p * p <= n; p++)
        //    {
        //        if (n % p == 0)
        //        {
        //            while (n % p == 0)
        //            {
        //                n /= p;
        //            }
        //            result -= result / p;
        //        }
        //    }

        //    if (n > 1)
        //        result -= result / n;

        //    return result;
        //}
    }
}