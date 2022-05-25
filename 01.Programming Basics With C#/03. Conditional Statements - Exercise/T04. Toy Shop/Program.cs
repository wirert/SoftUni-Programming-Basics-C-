using System;

namespace T04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal tripPrice = decimal.Parse(Console.ReadLine());
            int numberPuzzles = int.Parse(Console.ReadLine());
            int numberDolls = int.Parse(Console.ReadLine());
            int numberBears = int.Parse(Console.ReadLine());
            int numberMinions = int.Parse(Console.ReadLine());
            int numberTrucks = int.Parse(Console.ReadLine());
            int totalToys = numberPuzzles + numberDolls + numberBears + numberMinions + numberTrucks;
            decimal toysPrice = numberPuzzles * 2.6m + numberDolls * 3m + numberBears * 4.1m + numberMinions * 8.2m + numberTrucks * 2m;
            if (totalToys >= 50)
            {
                toysPrice *= 0.75m;
            }
            toysPrice *= 0.9m;
            if (toysPrice >= tripPrice)
            {
                Console.WriteLine($"Yes! {(toysPrice - tripPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - toysPrice:f2} lv needed.");
            }
        }
    }
}
