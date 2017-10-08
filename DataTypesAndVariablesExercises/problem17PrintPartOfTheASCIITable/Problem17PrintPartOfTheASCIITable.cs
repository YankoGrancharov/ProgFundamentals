using System;
namespace problem17PrintPartOfTheASCIITable
{
    class Problem17PrintPartOfTheASCIITable
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            for (int i = firstNum; i <= secondNum; i++)
            {
                char c = Convert.ToChar(i);
                Console.Write($"{c} ");
            }
            Console.WriteLine();
        }
    }
}
