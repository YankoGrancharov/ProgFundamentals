using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testLIst_ov_char
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "fgh 12 kjh 85 lih";

            char[] chars = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                chars[i] = s[i];
            }
        }
    }
}
