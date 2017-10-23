using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MostFrequentNumber
{
    public class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] num = File.ReadAllText("../../input.txt").Split(' ')
                .Select(int.Parse)
                .ToArray();
            numFind(num);

        }

        private static void numFind(int[] num)
        {
            Dictionary<int, int> nums = new Dictionary<int, int>();

            foreach (int n in num)
            {
                if (!nums.ContainsKey(n))
                {
                    nums.Add(n, 0);
                }
                nums[n] += 1;
            }

            int mostCommonValue = 0;
            int highestCount = 0;

            foreach (KeyValuePair<int, int> pair in nums)
            {
                if (pair.Value > highestCount)
                {
                    mostCommonValue = pair.Key;
                    highestCount = pair.Value;
                }
            }
            File.AppendAllText("../../output.txt",$"{mostCommonValue}" );
        }
    }
}