using System;

namespace T06._Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double palamudKilos = double.Parse(Console.ReadLine());
            double scadKikos  = double.Parse(Console.ReadLine());
            double clamKikos = double.Parse(Console.ReadLine());
            double palamudPrice = mackerelPrice * 1.6 * palamudKilos;
            double scadPrice = spratPrice * 1.8 * scadKikos;
            double clamPrice = clamKikos * 7.5;
            double totalPrice = palamudPrice + scadPrice + clamPrice;
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
