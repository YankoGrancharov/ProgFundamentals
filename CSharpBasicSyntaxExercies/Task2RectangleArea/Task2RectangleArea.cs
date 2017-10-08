using System;
namespace Task2RectangleArea
{
    class Task2RectangleArea
    {
        static void Main()
        {
            float height = float.Parse(Console.ReadLine());
            float widht = float.Parse(Console.ReadLine());
            float areaRectange = height * widht;
            Console.WriteLine($"{areaRectange:F2}");
        }
    }
}
