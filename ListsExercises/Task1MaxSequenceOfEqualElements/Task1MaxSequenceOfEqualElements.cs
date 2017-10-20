using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1MaxSequenceOfEqualElements
{
    class Task1MaxSequenceOfEqualElements
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int counter = 1;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]==input[i+1])
                {
                    counter++;
                }

            }

        }
    }
}
