using System;

namespace _03._Courier_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packageWeight = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double pricePerKm = 0;

            if (packageWeight < 1)
                pricePerKm = 0.03;
            else if (packageWeight < 10)
                pricePerKm = 0.05;
            else if (packageWeight < 40)
                pricePerKm = 0.1;
            else if (packageWeight < 90)
                pricePerKm = 0.15;
            else if (packageWeight < 150)
                pricePerKm = 0.2;
            double standartPrice = pricePerKm * distance;
            double charge = 0;
            if (serviceType == "express")
            {
                if (packageWeight < 1)
                    charge = 0.03 * 0.8;
                else if (packageWeight < 10)
                    charge = 0.05 * 0.4;
                else if (packageWeight < 40)
                    charge = 0.1 * 0.05;
                else if (packageWeight < 90)
                    charge = 0.15 * 0.02;
                else if (packageWeight < 150)
                    charge = 0.2 * 0.01;
            }
            double allcharge = charge * packageWeight * distance;
            Console.WriteLine($"The delivery of your shipment with weight of {packageWeight:f3} kg. would cost {standartPrice + allcharge:f2} lv.");
        }
    }
}