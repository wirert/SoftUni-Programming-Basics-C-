using System;

namespace _05._Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numSerials = int.Parse(Console.ReadLine());
            double allPrice = 0;
            for (int i = 1; i <= numSerials; i++)
            {
                string serialName = Console.ReadLine();
                double serialPrice = double.Parse(Console.ReadLine());
                switch (serialName)
                {
                    case "Thrones":
                        serialPrice /= 2;
                        break;
                    case "Lucifer":
                        serialPrice *= 0.6;
                        break;
                    case "Protector":
                        serialPrice *= 0.7;
                        break;
                    case "TotalDrama":
                        serialPrice *= 0.8;
                        break;
                    case "Area":
                        serialPrice *= 0.9;
                        break;
                }
                allPrice += serialPrice;
            }
            if (allPrice > budget)
                Console.WriteLine($"You need {allPrice - budget:f2} lv. more to buy the series!");
            else
                Console.WriteLine($"You bought all the series and left with {budget - allPrice:f2} lv.");
        }
    }
}
