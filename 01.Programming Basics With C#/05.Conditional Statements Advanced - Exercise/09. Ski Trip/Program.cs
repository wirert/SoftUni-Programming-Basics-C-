using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string opinion = Console.ReadLine();
            double price = 0;
            if (room == "room for one person")
                price = (days - 1) * 18;
            else if (room == "apartment")
            {
                price = (days - 1) * 25;
                if (days < 10)
                    price *= 0.7;
                else if (days <= 15)
                    price *= 0.65;
                else
                    price *= 0.5;
            }
            else
            {
                price = (days - 1) * 35;
                if (days < 10)
                    price *= 0.9;
                else if (days <= 15)
                    price *= 0.85;
                else
                    price *= 0.8;
            }
            if (opinion == "positive")
                price *= 1.25;
            else
                price *= 0.9;
            Console.WriteLine($"{price:f2}");

        }
    }
}
