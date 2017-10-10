using System;
namespace Task3EnglishNameOfTheLastDigit
{
    class Task3EnglishNameOfTheLastDigit
    {
        static void LastDigit(long a)
        {
            long digit = Math.Abs(a) % 10;
            switch (digit)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 0:
                    Console.WriteLine("zero");
                    break;
            }
        }
        static void Main()
        {
            long inputNum = long.Parse(Console.ReadLine());
            LastDigit(inputNum);
        }
    }
}
