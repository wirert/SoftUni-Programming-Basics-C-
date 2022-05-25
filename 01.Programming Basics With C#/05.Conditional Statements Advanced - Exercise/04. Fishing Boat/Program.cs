using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFisherman = int.Parse(Console.ReadLine());
            double price = 0.00;
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    if (numFisherman <= 6)
                        price *= 0.9;
                    else if (numFisherman <= 11)
                        price *= 0.85;
                    else
                        price *= 0.75;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    if (numFisherman <= 6)
                        price *= 0.9;
                    else if (numFisherman <= 11)
                        price *= 0.85;
                    else
                        price *= 0.75;
                    break;
                default:
                    price = 2600;
                    if (numFisherman <= 6)
                        price *= 0.9;
                    else if (numFisherman <= 11)
                        price *= 0.85;
                    else
                        price *= 0.75;
                    break;
            }
            if (numFisherman % 2 == 0 && season != "Autumn")
                price *= 0.95;
            if (budget >= price)
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
        }
    }
}
