using System;
namespace problem7ExchangeVariableValues
{
    class Problem7ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int temp = 0;
            temp = a;
            a = b ;
            b = temp;
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {b}");
            Console.WriteLine($"b = {a}");
            Console.WriteLine($"After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
