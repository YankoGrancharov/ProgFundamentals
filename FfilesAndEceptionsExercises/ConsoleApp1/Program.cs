using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace IndexOfLetters
{
    public class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string inputFile = "../../input.txt";
            string outpulFile = "../../output.txt";

            char[] let = File.ReadAllText(inputFile).ToLower().ToCharArray();

            positia(let);
        }

        private static void positia(char[] let)
        {
            Dictionary<char, int> leterandP = new Dictionary<char, int>();

            int pos = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                if (!leterandP.ContainsKey(i))
                {
                    leterandP.Add(i, pos);
                }
                pos++;
            }

            foreach (char c in let)
            {
                if (leterandP.ContainsKey(c))
                {
                    File.AppendAllText("../../output.txt", ($"{c} -> {leterandP[c]}"+ Environment.NewLine));
                }
            }
        }
    }
}