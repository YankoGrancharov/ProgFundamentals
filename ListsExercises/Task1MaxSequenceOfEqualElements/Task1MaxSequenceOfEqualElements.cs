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
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int count = 1;
            int num = 0;
            int maxCount = 0;

            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    
                    if (count > maxCount)
                    {
                        maxCount = count;
                        num = numbers[i];
                    }

                }
                else
                {
                    count = 1;
                }
            }
            for (int j = 0; j < maxCount; j++)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
