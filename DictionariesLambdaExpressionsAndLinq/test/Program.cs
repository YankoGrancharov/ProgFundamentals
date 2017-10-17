//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace test
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            List<int> numbers = new List<int>();
//            for (int i = 0; i < n; i++)
//            {
//                numbers.Add(int.Parse(Console.ReadLine()));

//            }
//        }
//    }
//}

////////using System;
////////using System.Linq;

////////namespace Exer_11_EqualSums
////////{
////////    class Program
////////    {
////////        static void Main(string[] args)
////////        {
////////            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
////////            bool foundSums = false;

////////            for (int i = 0; i < inputArray.Length; i++)
////////            {
////////                int[] leftSide = inputArray.Take(i).ToArray();
////////                int[] rightSide = inputArray.Skip(i + 1).ToArray();

////////                if (leftSide.Sum() == rightSide.Sum())
////////                {
////////                    Console.WriteLine(i);
////////                    foundSums = true;
////////                    break;
////////                }
////////            }

////////            if (!foundSums)
////////            {
////////                Console.WriteLine("no");
////////            }
////////        }
////////    }
////////}

using System;
using System.Linq;

namespace Exer_10_PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i ; j < inputArray.Length; j++)
                {
                    if (Math.Abs(inputArray[i] - inputArray[j]) == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}