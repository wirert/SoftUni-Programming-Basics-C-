using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargos = int.Parse(Console.ReadLine());
            int tons = 0;
            double price = 0;
            int truckTons = 0;
            int busTons = 0;
            int trainTons = 0;
            for (int i = 1; i <= cargos; i++)
            {
                int currTons = int.Parse(Console.ReadLine());
                tons += currTons;
                if (currTons <= 3)
                {
                    busTons += currTons;
                    price += 200 * currTons;
                }
                else if (currTons <= 11)
                {
                    truckTons += currTons;
                    price += 175 * currTons;
                }
                else
                {
                    trainTons += currTons;
                    price += 120 * currTons;
                }
            }
            Console.WriteLine($"{price / tons:f2}");
            Console.WriteLine($"{(double)busTons * 100 / tons:f2}%");
            Console.WriteLine($"{(double)truckTons * 100 / tons:f2}%");
            Console.WriteLine($"{(double)trainTons * 100 / tons:f2}%");
        }
    }
}
