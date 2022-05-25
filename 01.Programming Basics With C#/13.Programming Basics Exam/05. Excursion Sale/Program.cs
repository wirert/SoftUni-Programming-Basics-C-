using System;

namespace _05._Excursion_Sale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSea = int.Parse(Console.ReadLine());
            int numMountain = int.Parse(Console.ReadLine());
            string typeExcursion = null;
            double profit = 0;
            while ((typeExcursion = Console.ReadLine()) != "Stop")
            {
                if (typeExcursion == "sea")
                {
                    if (numSea != 0)
                    {
                        profit += 680;
                        numSea--;
                    }
                }
                else if (typeExcursion == "mountain")
                {
                    if (numMountain != 0)
                    {
                        profit += 499;
                        numMountain--;
                    }
                }
                if (numSea + numMountain == 0)
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }
            }
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
