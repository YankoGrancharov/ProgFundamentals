using System;
namespace problem13VowelOrDigit
{
    class Problem13VowelOrDigit
    {
        static void Main()
        {
            char simbol = char.Parse(Console.ReadLine());
            if (simbol >= 48 && simbol <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                switch (simbol)
                {
                    case ('a'):
                    case ('e'):
                    case ('i'):
                    case ('o'):
                    case ('u'):
                    case ('y'):
                        Console.WriteLine("vowel");
                        break;
                    default:
                        Console.WriteLine("other");
                        break;
                }
            }
        }
    }
}
