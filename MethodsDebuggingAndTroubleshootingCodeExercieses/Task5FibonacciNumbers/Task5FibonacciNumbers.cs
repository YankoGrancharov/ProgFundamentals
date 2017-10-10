using System;
namespace Task5FibonacciNumbers
{
    class Task5FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int numF = int.Parse(Console.ReadLine());
            //if (numF == 0 || numF == 1)
            //{
            //    Console.WriteLine("1");
            //}
            //if (numF == 2)
            //{
            //    Console.WriteLine("2");
            //}
            //if (numF > 2)
            //{
                Console.WriteLine(numRevers(numF));
            //}

        }
        static int numRevers(int num)
        {
            int first = 0;
            int sec = 1;
            int sumnum = 1;
            for (int i = 0; i < num; i++)
            {
                sumnum = first + sec;
                first = sec;
                sec = sumnum;
            }
            return
               sumnum;

        }
    }
}
