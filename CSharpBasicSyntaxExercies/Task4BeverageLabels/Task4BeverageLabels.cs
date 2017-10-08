using System;
namespace Task4BeverageLabels
{
    class Task4BeverageLabels
    {
        static void Main()
        {
            string name = Console.ReadLine();
            float volum = float.Parse(Console.ReadLine());
            float energi = float.Parse(Console.ReadLine());
            float sugar = float.Parse(Console.ReadLine());
            float energiContents = (volum / 100) * energi;
            float sugsrContents = (volum / 100) * sugar;
            Console.WriteLine($"{volum}ml {name}:");
            Console.WriteLine($"{energiContents}kcal, {sugsrContents}g sugars");
        }
    }
}
