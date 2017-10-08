using System;
namespace problem14IntegerToHexAndBinary
{
    class Problem14IntegerToHexAndBinary
    {
        static void Main()
        {
            int numberToConvert = int.Parse(Console.ReadLine());
            string numberBin = Convert.ToString(numberToConvert, 2).ToUpper();
            string numberXes = Convert.ToString(numberToConvert, 16).ToUpper();
            Console.WriteLine(numberXes);
            Console.WriteLine(numberBin);
        }
    }
}
