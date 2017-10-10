using System;
namespace Task2MaxMethod
{
    class Task2MaxMethod
    {
        static void PrintMax(int numA, int numB, int numC)
        {
            Console.WriteLine(Math.Max( Math.Max(numA,numB),numC));
        }

        static void Main()
        {
            int a = int.Parse(Console.ReadLine());          
            int b = int.Parse(Console.ReadLine());          
            int c = int.Parse(Console.ReadLine());
            PrintMax(a, b, c);
        }
        //static void GetMax(int a, int b, int c)
        //{
        //    if (a > b && a > c)
        //    {
        //        Console.WriteLine(a);
        //    }
        //    else if (b > a && b > c)
        //    {
        //        Console.WriteLine(b);
        //    }
        //    else
        //    {
        //        Console.WriteLine(c);
        //    }
        //}

        //static void Main()
        //{
        //    int firstNum = int.Parse(Console.ReadLine());
        //    int secNum = int.Parse(Console.ReadLine());
        //    int thrtNum = int.Parse(Console.ReadLine());
        //    GetMax(firstNum, secNum, thrtNum);
        //}
    }
}
