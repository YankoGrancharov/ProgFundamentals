using System;
namespace Task5CharacterStats
{
    class Task5CharacterStats
    {
        static void Main()
        {
            string nsme = Console.ReadLine();
            int helt = int.Parse(Console.ReadLine());
            int heltLeight = int.Parse(Console.ReadLine());
            int energi = int.Parse(Console.ReadLine());
            int energiLeight = int.Parse(Console.ReadLine());
            string AS = new string('|', helt);
            string BS = new string('.', heltLeight - helt);
            string ES = new string('|', (energi));
            string CS = new string('.', (energiLeight - energi));
            Console.WriteLine($"Name: {nsme}");
            Console.WriteLine($"Health: |{AS}{BS}|");
            Console.WriteLine($"Energy: |{ES}{CS}|");
        }
    }
}
