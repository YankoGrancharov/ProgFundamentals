using System;
namespace Task1DebitCardNumber
{
    class Task1DebitCardNumber
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secandNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNum:D4} {secandNum:D4} {thirdNum:D4} {lastNum:D4}");
        }
    }
}
