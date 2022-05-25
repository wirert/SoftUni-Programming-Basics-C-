using System;

namespace T05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());
            double decorPrice = 0.1 * budget;
            double totalCostumePrice = statists * costumePrice;
            if (statists > 150)
            {
                totalCostumePrice *= 0.9;
            }
            double moneyNeeded = totalCostumePrice + decorPrice;
            if (budget < moneyNeeded)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget - moneyNeeded:f2} leva left.");
            }
        }
    }
}
