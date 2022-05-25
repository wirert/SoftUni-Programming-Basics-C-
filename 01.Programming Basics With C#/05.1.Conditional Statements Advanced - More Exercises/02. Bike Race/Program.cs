using System;

namespace _02._Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numJuniors = int.Parse(Console.ReadLine());
            int numSeniors = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();
            double income = 0;
            switch (track)
            {
                case "trail":
                    income = numJuniors * 5.5 + numSeniors * 7.0;
                    break;
                case "cross-country":
                    {
                        if (numJuniors + numSeniors >= 50)
                            income = (numJuniors * 8 + numSeniors * 9.5) * 0.75;
                        else
                            income = numJuniors * 8 + numSeniors * 9.5;
                        break;
                    }
                case "downhill":
                    income = numJuniors * 12.25 + numSeniors * 13.75;
                    break;
                case "road":
                    income = numJuniors * 20 + numSeniors * 21.50;
                    break;
            }
            income *= 0.95;
            Console.WriteLine($"{income:f2}");
        }
    }
}
