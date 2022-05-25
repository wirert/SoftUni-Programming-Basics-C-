using System;

namespace _03._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numChriz = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holydayOrNot = Console.ReadLine();
            double income = 0;
            switch (season)
            {
                case "Spring":
                    {
                        if (numTulips > 7)
                            income = (numChriz * 2.00 + numRoses * 4.1 + numTulips * 2.5) * 0.95;
                        else
                            income = numChriz * 2.00 + numRoses * 4.1 + numTulips * 2.5;
                        break;
                    }
                case "Summer":
                    income = numChriz * 2.00 + numRoses * 4.1 + numTulips * 2.5;
                    break;
                case "Autumn":
                    income = numChriz * 3.75 + numRoses * 4.5 + numTulips * 4.15;
                    break;
                case "Winter":
                    {
                        if (numRoses >= 10)
                            income = (numChriz * 3.75 + numRoses * 4.5 + numTulips * 4.15) * 0.9;
                        else
                            income = numChriz * 3.75 + numRoses * 4.5 + numTulips * 4.15;
                        break;
                    }
            }
            if (holydayOrNot == "Y")
                income *= 1.15;
            if (numChriz + numRoses + numTulips > 20)
                income *= 0.8;
            income += 2;
            Console.WriteLine($"{income:f2}");

        }
    }
}