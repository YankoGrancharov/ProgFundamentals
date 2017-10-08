using System;
namespace problem11ConvertSpeedUnits
{
    class Problem11ConvertSpeedUnits
    {
        static void Main()
        {
            float dist = float.Parse(Console.ReadLine());
            float hour = float.Parse(Console.ReadLine());
            float min= float.Parse(Console.ReadLine());
            float sec = float.Parse(Console.ReadLine());
            float time = hour * 3600 + min * 60 + sec;
            float timeH = hour + min / 60 + sec / 3600;
            float meterPerSecond = dist / time;
            float kilometerPerHour = (dist / 1000) / timeH;
            float milesPerHour = (dist / 1609) / timeH;
            Console.WriteLine(meterPerSecond);
            Console.WriteLine("{0}",kilometerPerHour);
            Console.WriteLine("{0}", milesPerHour);

        }
    }
}
