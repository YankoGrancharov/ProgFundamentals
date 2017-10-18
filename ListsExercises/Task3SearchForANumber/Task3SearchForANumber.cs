using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3SearchForANumber
{
    class Task3SearchForANumber
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> comandArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = numbers.Take(comandArgs[0]).ToList();
            result.RemoveRange(0, comandArgs[1]);
            if (result.Contains(comandArgs[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
