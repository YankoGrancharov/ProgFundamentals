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
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> comand = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        }
    }
}
