using System;

namespace _06._Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double distance = double.Parse (Console.ReadLine());
            double salary = 0;
            if (distance <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        salary = 0.75 * distance * 4;
                        break;
                    case "Summer":
                        salary = 0.9 * distance * 4;
                        break;
                    case "Winter":
                        salary = 1.05 * distance * 4;
                        break;
                }
            }
            else if (distance <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        salary = 0.95 * distance * 4;
                        break;
                    case "Summer":
                        salary = 1.1 * distance * 4;
                        break;
                    case "Winter":
                        salary = 1.25 * distance * 4;
                        break;
                }
            }
            else if (distance <= 20000)
                salary = 1.45 * distance * 4;
            salary *= 0.9;
            Console.WriteLine($"{salary:f2}");
        }
    }
}