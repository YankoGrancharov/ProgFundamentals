using System;
namespace Task1HelloName
{
    class Task1HelloName
    {
        static void PrintName(string b, string a)
        {
            Console.WriteLine($"{b} {a}!");
        }
        static void Main()
        {
            string name = Console.ReadLine();
            string pozdrav = "Hello,";
            PrintName(pozdrav, name);
        }
    }
}
