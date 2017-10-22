using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1oddLines
{
    class Task1oddLines
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Input.txt");
            List<string> OddLinex = new List<string>();
            for (int i = 1; i < lines.Length; i+= 2)
            {

                File.AppendAllText("OddLines.txt");

            }
            File.WriteAllLines("OddLines.txt");
        }
    }
}
