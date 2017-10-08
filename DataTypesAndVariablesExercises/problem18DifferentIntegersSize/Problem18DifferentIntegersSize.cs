using System;
namespace problem18DifferentIntegersSize
{
    class Problem18DifferentIntegersSize
    {
        static void Main()
        {
            string number = Console.ReadLine();
            try
            {
                long newNum = long.Parse(number);
                Console.WriteLine($"{newNum} can fit in:");

                if (newNum >= sbyte.MinValue && newNum <= sbyte.MaxValue)
                {
                    Console.WriteLine($"* sbyte");
                }
                if (newNum >= byte.MinValue && newNum <= byte.MaxValue)
                {
                    Console.WriteLine($"* byte");
                }
                if (newNum >= short.MinValue && newNum <= short.MaxValue)
                {
                    Console.WriteLine($"* short");
                }
                if (newNum >= ushort.MinValue && newNum <= ushort.MaxValue)
                {
                    Console.WriteLine($"* ushort");
                }
                if (newNum >= int.MinValue && newNum <= int.MaxValue)
                {
                    Console.WriteLine($"* int");
                }
                if (newNum >= uint.MinValue && newNum <= uint.MaxValue)
                {
                    Console.WriteLine($"* uint");
                }
                if (newNum >= long.MinValue && newNum <= long.MaxValue)
                {
                    Console.WriteLine($"* long");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{number} can't fit in any type");
            }

        }

    }
}
