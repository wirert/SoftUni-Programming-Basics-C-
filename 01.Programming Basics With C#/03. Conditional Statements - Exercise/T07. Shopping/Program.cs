using System;

namespace T07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCount = int.Parse(Console.ReadLine());
            int processorCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());
            double videoPrice = videoCount * 250;
            double processorPrice = processorCount * videoPrice * 0.35;
            double ramPrice = ramCount * videoPrice * 0.1;
            double totalPrice = videoPrice + processorPrice + ramPrice;
            if (videoCount > processorCount)
            {
                totalPrice *= 0.85;
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {(budget - totalPrice):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalPrice - budget):f2} leva more!");
            }
        }
    }
}
