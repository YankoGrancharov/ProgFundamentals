using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    public class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numOrder = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            bomb(numOrder);
        }

        private static void bomb(List<int> numOrder)
        {
            List<int> area = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int specialNumber = area[0];
            int pover = area[1];

            List<int> indexes = new List<int>();

            for (int i = 0; i < numOrder.Count; i++)
            {
                if (numOrder[i] == specialNumber)
                {
                    indexes.Add(i);
                    foreach (int indx in indexes)
                    {
                        int start = 0;
                        int end = 0;
                        if (indx - pover > 0)
                        {
                            start = indx - pover;
                        }

                        if (indx + pover > numOrder.Count - 1)
                        {
                            end = numOrder.Count - 1;
                        }
                        else
                        {
                            end = indx + pover;
                        }

                        for (int l = start; l <= end; l++)
                        {
                            numOrder[l] = 0;
                        }
                    }
                }

            }

            int sum = numOrder.Sum();
            Console.WriteLine(sum);
        }
    }
}