using System;

namespace _02._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numStatists = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());
            double decorPrice = 0.1 * budget;
            double allCostums = costumePrice * numStatists;
            if (numStatists > 150)
                allCostums *= 0.9;
            double money = decorPrice + allCostums;
            if (money > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {money - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - money:f2} leva left.");
            }
        }
    }
}
