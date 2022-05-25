using System;

namespace _01._Pool_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double entrance = double.Parse(Console.ReadLine());
            double launge = double.Parse(Console.ReadLine());
            double unbrella = double.Parse(Console.ReadLine());
            double tax = people * entrance + Math.Ceiling(0.75 * people) * launge + Math.Ceiling(people / 2.0) * unbrella;
            Console.WriteLine($"{tax:f2} lv.");
        }
    }
}
