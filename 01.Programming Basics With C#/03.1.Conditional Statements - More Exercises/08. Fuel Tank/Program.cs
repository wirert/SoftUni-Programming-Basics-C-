using System;

namespace _08._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litersHave = double.Parse(Console.ReadLine());
            if (fuel == "Diesel" || fuel == "Gasoline" || fuel == "Gas")
            {
                fuel = fuel.ToLower();
                if (litersHave >= 25)
                    Console.WriteLine($"You have enough {fuel}.");
                else
                    Console.WriteLine($"Fill your tank with {fuel}!");
               
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }


        }
    }
}
