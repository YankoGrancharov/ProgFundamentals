//using System;

//namespace test
//{
//    class Program
//    //{
    //    static void Main(string[] args)
    //    {
    //        int numF = int.Parse(Console.ReadLine());
    //        if (numF == 0 || numF == 1)
    //        {
    //            Console.WriteLine("1");
    //        }
    //        if (numF == 2)
    //        {
    //            Console.WriteLine("2");
    //        }
    //        if (numF>2)
    //        {
    //        Console.WriteLine( numRevers(numF) );
    //        }
            
    //    }
    //    static int numRevers(int num)
    //    {
    //        int first = 1;
    //        int sec = 2;
    //        int sumnum = 1;
    //        for (int i = 2; i < num; i++)
    //        {
    //            sumnum = first + sec;
    //            first = sec;
    //            sec = sumnum;
    //        }
    //         return
    //            sumnum;

    //    }
    //}
    using System;
 
namespace FibonacciNumbers
    {
        class MainClass
        {
            public static int Fib(int num)
            {
                int a = 0;
                int b = 1;
                for (int i = 0; i < num; i++)
                {
                    int temp = a;
                    a = b;
                    b = a + temp;
                }
                return b;
            }

            public static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(Fib(n));
            }
        }
    }
//}
