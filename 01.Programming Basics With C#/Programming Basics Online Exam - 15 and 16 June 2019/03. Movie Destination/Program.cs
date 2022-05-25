using System;

namespace _03._Movie_Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double pricePerDay = 0;
            switch (destination)
            {
                case "Dubai":
                    switch (season)
                    {
                        case "Winter":
                            pricePerDay = 45000 * 0.7;
                            break;
                        default:
                            pricePerDay = 40000 * 0.7;
                            break;
                    }
                    break;
                case "Sofia":
                    switch (season)
                    {
                        case "Winter":
                            pricePerDay = 17000 * 1.25;
                            break;
                        default:
                            pricePerDay = 12500 * 1.25;
                            break;
                    }
                    break;
                default:
                    switch (season)
                    {
                        case "Winter":
                            pricePerDay = 24000;
                            break;
                        default:
                            pricePerDay = 20250;
                            break;
                    }
                    break;
            }
            double price = pricePerDay * days;
            if (price <= budget)
                Console.WriteLine($"The budget for the movie is enough! We have {budget - price:f2} leva left!");
            else
                Console.WriteLine($"The director needs {price - budget:f2} leva more!");
        }
    }
}