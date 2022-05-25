using System;

namespace _05._Tourist_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double moneySpent = 0;
            string product = Console.ReadLine();
            int numProducts = 0;

            while (product != "Stop")
            {
                double price = double.Parse(Console.ReadLine());

                numProducts++;
                if (numProducts % 3 == 0)
                {
                    moneySpent += price / 2;
                }
                else
                    moneySpent += price;
                if (moneySpent > budget)
                {
                    
                    numProducts--;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {moneySpent - budget:f2} leva!");
                    return;
                }
                product = Console.ReadLine();

            }
            if (product == "Stop")
                Console.WriteLine($"You bought {numProducts} products for {moneySpent:f2} leva.");

        }
    }
}
