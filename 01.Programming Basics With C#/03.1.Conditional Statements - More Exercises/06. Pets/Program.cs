using System;

namespace _06._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFoodDay = double.Parse(Console.ReadLine());
            double catFoodDay = double.Parse(Console.ReadLine());
            double turtleFoodDayGram = double.Parse(Console.ReadLine());
            double foodNeeded =(dogFoodDay + catFoodDay + turtleFoodDayGram / 1000 ) * days;
            if (foodNeeded <= food)
                Console.WriteLine($"{Math.Floor(food - foodNeeded)} kilos of food left.");
            else
                Console.WriteLine($"{Math.Ceiling(foodNeeded - food)} more kilos of food are needed.");
        }
    }
}
