using System;

namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season  = Console.ReadLine();
            string location = null;
            string place = null;
            double price = 0;
            if (budget <= 1000)
            {
                place = "Camp";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = 0.65 * budget;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = 0.45 * budget;
                        break ;
                }
            }
            else if (budget <= 3000)
            {
                place = "Hut";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = 0.80 * budget;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = 0.60 * budget;
                        break;
                }
            }
            else
            {
                place = "Hotel";
                price = 0.90 * budget;
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";                        
                        break;
                    case "Winter":
                        location = "Morocco";                       
                        break;
                }
            }
            Console.WriteLine($"{location} - {place} - {price:f2}");
        }
    }
}
