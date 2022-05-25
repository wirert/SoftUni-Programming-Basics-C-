using System;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double price = 0;
            if (distance >= 20 && distance < 100)
                price = distance * 0.09;
            else if (distance >= 100)
                price = distance * 0.06;
            else
            {
                if (dayOrNight == "day")
                    price = distance * 0.79 + 0.7;
                else
                    price = distance * 0.9 + 0.7;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
