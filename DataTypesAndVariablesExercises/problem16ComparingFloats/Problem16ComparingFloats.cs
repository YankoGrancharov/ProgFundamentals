using System;
namespace problem16ComparingFloats
{
    class Problem16ComparingFloats
    {
        static void Main()
        {
            double firstInput = double.Parse(Console.ReadLine());
            double secondInput = double.Parse(Console.ReadLine());
            double diferens = 0.000001;
            ;
            if ( Math.Abs(firstInput-secondInput)< diferens)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");

        }
    }
}
