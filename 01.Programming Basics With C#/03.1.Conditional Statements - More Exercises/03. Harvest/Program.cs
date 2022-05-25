using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grapePerSquare = double.Parse(Console.ReadLine());
            int wineForSale = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double grape = grapePerSquare * vineyard;
            double wine = grape * 0.4 / 2.5;
            if (wine < wineForSale)
                Console.WriteLine($"It will be a tough winter! More {Math.Floor((double)wineForSale - wine)} liters wine needed.");
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {wine} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - (double)wineForSale)} liters left -> {Math.Ceiling((wine - (double)wineForSale)/workers)} liters per person.");
            }
        }
    }
}
