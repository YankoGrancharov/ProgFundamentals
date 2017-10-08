using System;

namespace problem10CenturiesToNanoseconds
{
    class Problem10CenturiesToNanoseconds
    {
        static void Main()
        {
            byte cent = byte.Parse(Console.ReadLine());
            byte centures = cent;
            ushort years = (ushort)(centures * 100);
            uint days = (uint)(years*365.2422);
            ulong hours = (ulong)(days*24);
            ulong minutes = (ulong)(hours*60);
            ulong sekondes = (ulong)(minutes*60);
            ulong milliseconds = (ulong)(sekondes*1000);
            ulong microseconds = (ulong)(milliseconds*1000);
            decimal nanoseconds = (decimal)(microseconds*1000m);
            Console.WriteLine($"{centures} centuries = {years} years = {days} days" +
                $" = {hours} hours = {minutes} minutes = {sekondes} seconds " +
                $"= {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
