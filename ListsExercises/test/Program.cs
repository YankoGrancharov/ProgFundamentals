//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace LargestCommonEnd
//{
//    public class LargestCommonEnd
//    {
//        static void Main(string[] args)
//        {
//            string[] firstAr = Console.ReadLine().Split(' ');
//            string[] secondAr = Console.ReadLine().Split(' ');

//            int leftCounter = 0;
//            int rightCounter = 0;

//            for (int i = 0; i <= Math.Min(firstAr.Length, secondAr.Length) - 1; i++)
//            {
//                if (firstAr[i] == secondAr[i])
//                {
//                    leftCounter++;
//                }
//                else
//                {
//                    break;
//                }
//            }

//            for (int i = 0; i <= Math.Min(firstAr.Length, secondAr.Length) - 1; i++)
//            {
//                if (firstAr[firstAr.Length - 1 - i] == secondAr[secondAr.Length - 1 - i])
//                {
//                    rightCounter++;
//                }
//                else
//                {
//                    break;
//                }
//            }

//            Console.WriteLine(Math.Max(leftCounter, rightCounter));
//        }
//    }
//}


////using System;
////using System.Collections.Generic;
////using System.Linq;

////namespace RotateAndSum
////{
////    public class RotateAndSum
////    {
////        static void Main(string[] args)
////        {
////            int[] nUm = Console.ReadLine().Split(' ')
////                .Select(int.Parse)
////                .ToArray();

////            int k = int.Parse(Console.ReadLine());

////            int[] rotated = new int[nUm.Length];

////            for (int i = 0; i < k; i++)
////            {
////                int temp = nUm[nUm.Length - 1];
////                for (int j = nUm.Length - 1; j > 0; j--)
////                {
////                    nUm[j] = nUm[j - 1];

////                }
////                nUm[0] = temp;

////                for (int l = 0; l < nUm.Length; l++)
////                {
////                    rotated[l] += nUm[l];
////                }
////            }

////            Console.WriteLine(string.Join(" ", rotated));
////        }
////    }
////}

//////using System;
//////using System.Collections.Generic;
//////using System.Linq;

//////namespace FoldAndSum
//////{
//////    public class FoldAndSum
//////    {
//////        static void Main(string[] args)
//////        {
//////            int[] array = Console.ReadLine().Split(' ')
//////                .Select(int.Parse)
//////                .ToArray();

//////            int[] part1 = new int[array.Length / 4];
//////            int[] part2 = new int[array.Length / 4];
//////            int[] part3 = new int[array.Length / 4];
//////            int[] part4 = new int[array.Length / 4];

//////            int position = 0;
//////            int part = array.Length / 4;

//////            for (int i = position, j = 0; position < part; position++, j++)
//////            {
//////                part1[j] = array[position];
//////            }
//////            for (int i = position, j = 0; position < (part * 2); position++, j++)
//////            {
//////                part2[j] = array[position];
//////            }
//////            for (int i = position, j = 0; position < (part * 3); position++, j++)
//////            {
//////                part3[j] = array[position];
//////            }
//////            for (int i = position, j = 0; position < (part * 4); position++, j++)
//////            {
//////                part4[j] = array[position];
//////            }

//////            Array.Reverse(part1);
//////            Array.Reverse(part4);

//////            List<int> resultsOne = new List<int>();

//////            resultsOne.AddRange(part1);
//////            resultsOne.AddRange(part4);

//////            List<int> resultsTwo = new List<int>();

//////            resultsTwo.AddRange(part2);
//////            resultsTwo.AddRange(part3);

//////            List<int> finalRes = new List<int>();

//////            for (int i = 0; i < resultsOne.Count; i++)
//////            {
//////                finalRes.Add(resultsOne[i] + resultsTwo[i]);
//////            }

//////            Console.WriteLine(string.Join(" ", finalRes));
//////        }
//////    }
//////}

////////using System;
////////using System.Collections.Generic;
////////using System.Linq;

////////namespace SieveOfEratosthenes
////////{
////////    class SieveOfEratosthenes
////////    {
////////        static void Main(string[] args)
////////        {
////////            long n = long.Parse(Console.ReadLine());
////////            bool[] num = new bool[n + 1];
////////            for (int i = 2; i <= n; i++)
////////            {
////////                num[i] = true;
////////            }

////////            for (int j = 2; j <= n; j++)
////////            {
////////                if (num[j])
////////                {
////////                    for (long p = 2; (p * j) <= n; p++)
////////                    {
////////                        num[p * j] = false;
////////                    }
////////                }
////////            }

////////            for (int i = 2; i <= n; i++)
////////            {
////////                if (num[i])
////////                {
////////                    Console.Write($"{i} ");
////////                }
////////            }

////////        }
////////    }
////////}

//////////using System;
//////////using System.Collections.Generic;
//////////using System.Linq;

//////////namespace CompareCharArrays
//////////{
//////////    class CompareCharArrays
//////////    {
//////////        static void Main(string[] args)
//////////        {
//////////            char[] arr1 = Console.ReadLine().Split(' ')
//////////                .Select(char.Parse)
//////////                .ToArray();

//////////            char[] arr2 = Console.ReadLine().Split(' ')
//////////                .Select(char.Parse)
//////////                .ToArray();

//////////            bool oneIsFirst = false;
//////////            bool twoIsFirst = false;

//////////            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
//////////            {
//////////                if (arr1[i] < arr2[i])
//////////                {
//////////                    oneIsFirst = true;
//////////                    break;
//////////                }
//////////                else if (arr1[i] > arr2[i])
//////////                {
//////////                    twoIsFirst = true;
//////////                    break;
//////////                }
//////////            }

//////////            if (oneIsFirst)
//////////            {
//////////                Console.WriteLine(string.Join("", arr1));
//////////                Console.WriteLine(string.Join("", arr2));
//////////            }
//////////            else if (twoIsFirst)
//////////            {
//////////                Console.WriteLine(string.Join("", arr2));
//////////                Console.WriteLine(string.Join("", arr1));
//////////            }
//////////            else
//////////            {
//////////                if (arr1.Length > arr2.Length)
//////////                {
//////////                    Console.WriteLine(string.Join("", arr2));
//////////                    Console.WriteLine(string.Join("", arr1));
//////////                }
//////////                else
//////////                {
//////////                    Console.WriteLine(string.Join("", arr1));
//////////                    Console.WriteLine(string.Join("", arr2));
//////////                }
//////////            }
//////////        }
//////////    }
//////////}


////////////using System;
////////////using System.Collections.Generic;
////////////using System.Linq;
////////////namespace MaxSequence
////////////{
////////////    public class MaxSequence
////////////    {
////////////        static void Main(string[] args)
////////////        {
////////////            int[] nUm = Console.ReadLine().Split(' ')
////////////                .Select(int.Parse)
////////////                .ToArray();

////////////            LongSequ(nUm);

////////////        }

////////////        private static void LongSequ(int[] array)
////////////        {
////////////            int start = 0;
////////////            int len = 1;

////////////            int bestPosition = 0;
////////////            int bestLen = 1;

////////////            for (int i = 1; i < array.Length; i++)
////////////            {
////////////                if (array[i] == array[i - 1])
////////////                {
////////////                    len++;
////////////                    if (len > bestLen)
////////////                    {
////////////                        bestLen = len;
////////////                        bestPosition = start;
////////////                    }
////////////                }
////////////                else
////////////                {
////////////                    if (len > bestLen)
////////////                    {
////////////                        bestPosition = start;
////////////                        bestLen = len;
////////////                    }
////////////                    start = i;
////////////                    len = 1;
////////////                }
////////////            }

////////////            for (int i = bestPosition; i < bestPosition + bestLen; i++)
////////////            {
////////////                Console.Write($"{array[i]} ");
////////////            }
////////////        }
////////////    }
////////////}


//////////////using System;
//////////////using System.Collections.Generic;
//////////////using System.Linq;

//////////////namespace MaxSeqIncrEle
//////////////{
//////////////    public class MaxSeqIncrEle
//////////////    {
//////////////        static void Main(string[] args)
//////////////        {
//////////////            int[] num = Console.ReadLine().Split(' ')
//////////////                .Select(int.Parse)
//////////////                .ToArray();

//////////////            longSecu(num);

//////////////        }

//////////////        private static void longSecu(int[] array)
//////////////        {
//////////////            int start = 0;
//////////////            int len = 1;

//////////////            int bestPosition = 0;
//////////////            int bestLen = 1;

//////////////            for (int i = 1; i < array.Length; i++)
//////////////            {
//////////////                if (array[i] > array[i - 1])
//////////////                {
//////////////                    len++;
//////////////                    if (len > bestLen)
//////////////                    {
//////////////                        bestLen = len;
//////////////                        bestPosition = start;
//////////////                    }
//////////////                }
//////////////                else
//////////////                {
//////////////                    if (len > bestLen)
//////////////                    {
//////////////                        bestPosition = start;
//////////////                        bestLen = len;
//////////////                    }
//////////////                    start = i;
//////////////                    len = 1;
//////////////                }
//////////////            }

//////////////            for (int i = bestPosition; i < bestPosition + bestLen; i++)
//////////////            {
//////////////                Console.Write($"{array[i]} ");
//////////////            }
//////////////        }
//////////////    }
//////////////}

//////////////////using System;
//////////////////using System.Collections.Generic;
//////////////////using System.Linq;

//////////////////namespace MostFrequentNumber
//////////////////{
//////////////////    public class MostFrequentNumber
//////////////////    {
//////////////////        static void Main(string[] args)
//////////////////        {
//////////////////            int[] num = Console.ReadLine().Split(' ')
//////////////////                .Select(int.Parse)
//////////////////                .ToArray();
//////////////////            numFind(num);

//////////////////        }

//////////////////        private static void numFind(int[] num)
//////////////////        {
//////////////////            Dictionary<int, int> nums = new Dictionary<int, int>();

//////////////////            foreach (int n in num)
//////////////////            {
//////////////////                if (!nums.ContainsKey(n))
//////////////////                {
//////////////////                    nums.Add(n, 0);
//////////////////                }
//////////////////                nums[n] += 1;
//////////////////            }

//////////////////            int mostCommonValue = 0;
//////////////////            int highestCount = 0;

//////////////////            foreach (KeyValuePair<int, int> pair in nums)
//////////////////            {
//////////////////                if (pair.Value > highestCount)
//////////////////                {
//////////////////                    mostCommonValue = pair.Key;
//////////////////                    highestCount = pair.Value;
//////////////////                }
//////////////////            }
//////////////////            Console.WriteLine(mostCommonValue);
//////////////////        }
//////////////////    }
//////////////////}

//////////////////////using System;
//////////////////////using System.Collections.Generic;
//////////////////////using System.Linq;
//////////////////////namespace IndexOfLetters
//////////////////////{
//////////////////////    public class IndexOfLetters
//////////////////////    {
//////////////////////        static void Main(string[] args)
//////////////////////        {
//////////////////////            char[] let = Console.ReadLine().ToLower().ToCharArray();

//////////////////////            positia(let);
//////////////////////        }

//////////////////////        private static void positia(char[] let)
//////////////////////        {
//////////////////////            Dictionary<char, int> leterandP = new Dictionary<char, int>();

//////////////////////            int pos = 0;
//////////////////////            for (char i = 'a'; i <= 'z'; i++)
//////////////////////            {
//////////////////////                if (!leterandP.ContainsKey(i))
//////////////////////                {
//////////////////////                    leterandP.Add(i, pos);
//////////////////////                }
//////////////////////                pos++;
//////////////////////            }

//////////////////////            foreach (char c in let)
//////////////////////            {
//////////////////////                if (leterandP.ContainsKey(c))
//////////////////////                {
//////////////////////                    Console.WriteLine($"{c} -> {leterandP[c]}");
//////////////////////                }
//////////////////////            }
//////////////////////        }
//////////////////////    }
//////////////////////}


////using System;
////using System.Collections.Generic;
////using System.Linq;
////namespace pairBydifer
////{
////    public class pairBydifer
////    {
////        static void Main(string[] args)
////        {
////            int[] num = Console.ReadLine().Split()
////                .Select(int.Parse)
////                .ToArray();

////            pair(num);
////        }

////        private static void pair(int[] num)
////        {
////            int difer = int.Parse(Console.ReadLine());
////            int pair = 0;

////            for (int i = 0; i < num.Length; i++)
////            {
////                for (int j = i; j < num.Length; j++)
////                {
////                    if (i == j)
////                    {
////                        continue;
////                    }
////                    else
////                    {
////                        if (Math.Abs(num[i] - num[j]) == difer)
////                        {
////                            pair++;
////                        }
////                    }
////                }
////            }
////            Console.WriteLine(pair);
////        }
////    }
////}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _10.pair_by_difer
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//            int difer = int.Parse(Console.ReadLine());
//            int pair = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                for (int j = i + 1; j < array.Length; j++)
//                {
//                    if (Math.Abs(array[i] - array[j]) == difer)
//                    {
//                        pair++;
//                    }
//                }
//            }

//            Console.WriteLine(pair);
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    if (Math.Abs(numbers[k] - numbers[i]) == n && i < k)
                    {
                        //Console.WriteLine(numbers[i] + " " + numbers[k]);
                        counter++;
                    }
                }
            }//end of for

            Console.WriteLine(counter);

        }
    }
}


////////////////////////////////////////using System;
////////////////////////////////////////using System.Collections.Generic;
////////////////////////////////////////using System.Linq;
////////////////////////////////////////namespace EqualSums
////////////////////////////////////////{
////////////////////////////////////////    class EqualSums
////////////////////////////////////////    {
////////////////////////////////////////        static void Main(string[] args)
////////////////////////////////////////        {
////////////////////////////////////////            long[] array = Console.ReadLine()
////////////////////////////////////////                .Split()
////////////////////////////////////////                .Select(long.Parse)
////////////////////////////////////////                .ToArray();

////////////////////////////////////////            sumFinder(array);
////////////////////////////////////////        }

////////////////////////////////////////        private static void sumFinder(long[] array)
////////////////////////////////////////        {

////////////////////////////////////////            bool hasIndex = false;

////////////////////////////////////////            for (int i = 0; i < array.Length; i++)
////////////////////////////////////////            {
////////////////////////////////////////                long left = 0;
////////////////////////////////////////                for (int j = 0; j < i; j++)
////////////////////////////////////////                {
////////////////////////////////////////                    left += array[j];
////////////////////////////////////////                }

////////////////////////////////////////                long right = 0;
////////////////////////////////////////                for (int l = array.Length + 1; l >= i; l--)
////////////////////////////////////////                {
////////////////////////////////////////                    right += array[l];
////////////////////////////////////////                }

////////////////////////////////////////                if (left == right)
////////////////////////////////////////                {
////////////////////////////////////////                    Console.WriteLine(i);
////////////////////////////////////////                    hasIndex = true;
////////////////////////////////////////                    return;
////////////////////////////////////////                }
////////////////////////////////////////            }
////////////////////////////////////////            if (hasIndex == false)
////////////////////////////////////////            {
////////////////////////////////////////                Console.WriteLine("no");
////////////////////////////////////////            }
////////////////////////////////////////        }
////////////////////////////////////////    }
////////////////////////////////////////}
