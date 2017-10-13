using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1RemoveNegativesAndReverse
{
    class Task1RemoveNegativesAndReverse
    {
        static void Main()
        {
            List<int> input = int.ParseConsole.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
