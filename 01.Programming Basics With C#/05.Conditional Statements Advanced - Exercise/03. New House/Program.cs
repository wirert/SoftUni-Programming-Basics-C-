using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.00;
            switch (flower)
            {
                case "Roses":
                    price = numFlowers * 5.00;
                    if (numFlowers > 80)
                        price *= 0.9;
                    break;
                case "Dahlias":
                    price = numFlowers * 3.80;
                    if (numFlowers > 90)
                        price *= 0.85;
                    break;
                case "Tulips":
                    price = numFlowers * 2.80;
                    if (numFlowers > 80)
                        price *= 0.85;
                    break;
                case "Narcissus":
                    price = numFlowers * 3.00;
                    if (numFlowers < 120)
                        price *= 1.15;
                    break;
                case "Gladiolus":
                    price = numFlowers * 2.50;
                    if (numFlowers < 80)
                        price *= 1.2;
                    break;
            }
            if (budget >= price)
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flower} and {budget - price:f2} leva left.");
            else
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
        }
    }
}
