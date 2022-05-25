using System;

namespace _04._Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string classCar = null;
            string typeCar = null;
            double carPrice = 0;
            if (budget <= 100)
            {
                classCar = "Economy class";
                switch (season)
                {
                    case "Summer":
                        typeCar = "Cabrio";
                        carPrice = 0.35 * budget;
                        break;
                    case "Winter":
                        typeCar = "Jeep";
                        carPrice = 0.65 * budget;
                        break;
                }
            }
            else if (budget <= 500)
            {
                classCar = "Compact class";
                switch (season)
                {
                    case "Summer":
                        typeCar = "Cabrio";
                        carPrice = 0.45 * budget;
                        break;
                    case "Winter":
                        typeCar = "Jeep";
                        carPrice = 0.80 * budget;
                        break;
                }
            }
            else
            {
                classCar = "Luxury class";
                typeCar = "Jeep";
                carPrice = 0.90 * budget;
            }
            Console.WriteLine(classCar);
            Console.WriteLine($"{typeCar} - {carPrice:f2}");
        }
    }
}
