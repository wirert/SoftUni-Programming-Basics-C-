using System;

namespace _01._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numPeople = int.Parse(Console.ReadLine());
            double ticketPrice = 0;
            double price = 0;
            if (numPeople >= 1 && numPeople < 5)
                money *= 0.25;
            else if (numPeople >= 5 && numPeople < 10)
                money *= 0.4;
            else if (numPeople >= 10 && numPeople < 25)
                money *= 0.5;
            else if (numPeople >= 25 && numPeople < 50)
                money *= 0.6;
            else if (numPeople >= 50)
                money *= 0.75;
            if (category == "VIP")
                ticketPrice = 499.99;
            else
                ticketPrice = 249.99;
            price = ticketPrice * numPeople;
            if (money >= price)
                Console.WriteLine($"Yes! You have {money - price:f2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {price - money:f2} leva.");
        }
    }
}
