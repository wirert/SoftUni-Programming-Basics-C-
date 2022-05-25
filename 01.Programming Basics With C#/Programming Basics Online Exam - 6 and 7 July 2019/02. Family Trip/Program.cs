using System;

namespace _02._Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double taxForNight = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());            
            if (nights > 7)
                taxForNight *= 0.95;
            double neededMoney = percent * budget / 100 + nights * taxForNight;
            if (neededMoney <= budget)
                Console.WriteLine($"Ivanovi will be left with {budget - neededMoney:f2} leva after vacation.");
            else
                Console.WriteLine($"{neededMoney - budget:f2} leva needed.");

        }
    }
}
