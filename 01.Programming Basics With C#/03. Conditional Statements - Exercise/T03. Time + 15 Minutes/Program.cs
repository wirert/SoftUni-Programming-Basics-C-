using System;

namespace T03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            minute += 15;
            if (minute >= 60)
            {
                hours += 1;
                minute -= 60;
            }
            if (hours >= 24)
            {
                hours -= 24;
            }
            Console.WriteLine($"{hours}:{minute:d2}");
        }
    }
}
