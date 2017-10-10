using System;
namespace Task6PrimeChecker
{
    class Task6PrimeChecker
    {
        static void prime(long pr)
        {
            bool primeN = true;
            if (pr<2)
            {
                primeN = false;
            }
            for (long i = 2; i <= Math.Sqrt(pr); i++)
            {
                if (pr % i == 0)
                {
                    primeN=false;
                    break;
                }
            }
            Console.WriteLine(primeN);
        }
        static void Main()
        {
            long prem = long.Parse(Console.ReadLine());
            prime( prem);
        }
    }
}
