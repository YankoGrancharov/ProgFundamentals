using System;

namespace Problem4VariableInHexadecimalFormat
{
    class Problem4VariableInHexadecimalFormat
    {
        static void Main()
        {
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a, 16);
            Console.WriteLine(b);
        }
    }
}
