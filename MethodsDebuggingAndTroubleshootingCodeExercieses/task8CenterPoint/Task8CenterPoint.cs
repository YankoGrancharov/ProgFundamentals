using System;
namespace task8CenterPodouble
{
    class Task8CenterPodouble
    {
        static void PodoubleDistans(double a, double b, double c, double d)
        {
            double PodoubleDistans1 = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double PodoubleDistans2 = Math.Sqrt(Math.Pow(c, 2) + Math.Pow(d, 2));
            if (PodoubleDistans1 == PodoubleDistans2)
            {
                Console.WriteLine($"({a}, {b})");
            }
            if (PodoubleDistans1 > PodoubleDistans2)
            {
                Console.WriteLine($"({c}, {d})");
            }
            if (PodoubleDistans1<PodoubleDistans2)
            {
                Console.WriteLine($"({a}, {b})");
            }
        }
        static void Main()
        {
            double x1Num = double.Parse(Console.ReadLine());
            double y1Num = double.Parse(Console.ReadLine());
            double x2Num = double.Parse(Console.ReadLine());
            double y2Num = double.Parse(Console.ReadLine());
            PodoubleDistans(x1Num, y1Num, x2Num, y2Num);
        }
    }
}
