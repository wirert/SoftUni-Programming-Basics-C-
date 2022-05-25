using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string roof = "";
            string destination = "";
            double spentMoney = 0.00;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        spentMoney = budget * 0.3;
                        roof = "Camp";
                        break;
                    default:
                        roof = "Hotel";
                        spentMoney = budget * 0.7;
                        break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        spentMoney = budget * 0.4;
                        roof = "Camp";
                        break;
                    default:
                        roof = "Hotel";
                        spentMoney = budget * 0.8;
                        break;
                }
            }
            else
            {
                destination = "Europe";
                roof = "Hotel";
                spentMoney = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{roof} - {spentMoney:f2}");

        }
    }
}
