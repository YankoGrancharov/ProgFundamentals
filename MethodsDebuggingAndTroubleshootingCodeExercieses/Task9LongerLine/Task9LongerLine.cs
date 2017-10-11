using System;
namespace Task9LongerLine
{
    class Task9LongerLine
    {
        static void FirstPoint(double a, double b, double c, double d)
        {
            double Point1 = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double Point2 = Math.Sqrt(Math.Pow(c, 2) + Math.Pow(d, 2));
            if (Point1 == Point2)
            {
                Console.WriteLine($"({a}, {b})({c}, {d})");
            }
            if (Point1 > Point2)
            {
                Console.WriteLine($"({c}, {d})({a}, {b})");
            }
            if (Point1 < Point2)
            {
                Console.WriteLine($"({a}, {b})({c}, {d})");
            }
        }
        static double PodoubleDistans(double a, double b, double c, double d)
        {

            double disttans = 0;
            //if (a==c)
            //{
            //    disttans = Math.Abs(b)+Math.Abs(d);
            //}
            //if (b==d)
            //{
            //    disttans = Math.Abs(a) + Math.Abs(c);
            //}
            //else 
            //{
            //    double PodoubleDistans1 = Math.Pow(a, 2) + Math.Pow(b, 2);
            //    double PodoubleDistans2 = Math.Pow(c, 2) + Math.Pow(d, 2);
            disttans = Math.Sqrt(Math.Pow((a - c), 2) + Math.Pow((b - d), 2));
        //}
            return disttans;
        }
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double l1 = PodoubleDistans(x1, y1, x2, y2);
            double l2 = PodoubleDistans(x3, y3, x4, y4);
            //if (l1==l2)
            //{
            //    FirstPoint(x1, y1, x2, y2);
            //}
            if (l1>=l2)
            {
                FirstPoint(x1, y1, x2, y2);
            }
            if (l1<l2)
            {
                FirstPoint(x3, y3, x4, y4);
            }
        }
    }
}
