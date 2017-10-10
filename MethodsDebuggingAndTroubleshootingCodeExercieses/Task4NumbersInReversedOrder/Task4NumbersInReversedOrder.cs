using System;
namespace Task4NumbersInReversedOrder
{
    class Task4NumbersInReversedOrder
    {
        static void Main()
        {
            string num = Console.ReadLine();
            Console.WriteLine(NumRevers(num));
        }
        static string NumRevers(string num)
        {
            string rezult = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                rezult += num[i];
            }
            return rezult;
        }
    }
}
