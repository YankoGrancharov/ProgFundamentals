using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem15FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int ___Do___ = int.Parse(Console.ReadLine());
            for (int DAVIDIM = 2; DAVIDIM <= ___Do___; DAVIDIM++)
            {
                bool TowaLIE = true;
                for (int delio = 2; delio <= Math.Sqrt(DAVIDIM); delio++)
                {
                    if (DAVIDIM % delio == 0)
                    {
                        TowaLIE = false;
                        break;
                    }
                }
                Console.WriteLine($"{DAVIDIM} -> {TowaLIE}");
            }

        }
    }
}
