using System;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal b1 = decimal.Parse(Console.ReadLine());
            decimal b2 = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());
            decimal area = (b1 + b2) * h / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
