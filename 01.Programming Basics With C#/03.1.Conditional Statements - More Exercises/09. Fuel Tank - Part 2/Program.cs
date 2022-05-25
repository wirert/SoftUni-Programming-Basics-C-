using System;

namespace _09._Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double quantityFuel = double.Parse(Console.ReadLine());
            string cardAvaliabla = Console.ReadLine();
            double fuelCost = 0;
            if (cardAvaliabla == "No")
            {
                if (fuel == "Gasoline")
                    fuelCost = quantityFuel * 2.22;
                else if (fuel == "Diesel")
                    fuelCost = quantityFuel * 2.33;
                else
                    fuelCost = quantityFuel * 0.93;
            }
            else
            {
                if (fuel == "Gasoline")
                    fuelCost = quantityFuel * (2.22 - 0.18);
                else if (fuel == "Diesel")
                    fuelCost = quantityFuel * (2.33 - 0.12);
                else
                    fuelCost = quantityFuel * (0.93 - 0.08);
            }
            if (quantityFuel >= 20 && quantityFuel <= 25)
                fuelCost *= 0.92;
            else if (quantityFuel > 25)
            {
                fuelCost *= 0.9;
            }
            Console.WriteLine($"{fuelCost:f2} lv.");
        }
    }
}