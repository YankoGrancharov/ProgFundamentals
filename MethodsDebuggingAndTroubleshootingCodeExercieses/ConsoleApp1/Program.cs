using System;
using System.Numerics;
//14. Factorial Trailing Zeroes
namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = FactRes(n);
            int zeroes = ZeroesCount(factorial);
            Console.WriteLine(zeroes);
        }

        static int ZeroesCount(BigInteger num)
        {
            int zeroes = 0;
            bool hasZero = true;
            while (hasZero == true)
            {
                BigInteger digit = num % 10;
                num /= 10;
                if (digit == 0)
                {
                    zeroes++;
                }
                else
                {
                    hasZero = false;
                }
            }
            return zeroes;
        }

        static BigInteger FactRes(int n)
        {
            BigInteger sum = 0;

            if (n == 1)
            {
                return 1;
            }
            else
            {
                sum = FactRes(n - 1) * n;
                return sum;
            }
        }
    }
}