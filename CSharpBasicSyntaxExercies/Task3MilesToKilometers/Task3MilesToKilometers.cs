using System;
namespace Task3MilesToKilometers
{
    class Task3MilesToKilometers
    {
        static void Main()
        {
            double miles = double.Parse(Console.ReadLine());
            double kilometer = 1.60934;
            double resut = miles * kilometer;
            Console.WriteLine($"{resut:f2}");
        }
    }
}
