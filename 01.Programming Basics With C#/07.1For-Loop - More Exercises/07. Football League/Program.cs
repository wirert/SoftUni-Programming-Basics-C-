using System;

namespace _07._Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allSeats = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());
            int fansA = 0;
            int fansB = 0;
            int fansV = 0;
            int fansG = 0;
            for (int i = 1; i <= fans; i++)
            {
                string sector = Console.ReadLine();
                if (sector == "A")
                    fansA++;
                else if (sector == "B")
                    fansB++;
                else if (sector == "V")
                    fansV++;
                else if (sector == "G")
                    fansG++;
            }
            Console.WriteLine($"{fansA * 100.0 / fans:f2}%");
            Console.WriteLine($"{fansB * 100.0 / fans:f2}%");
            Console.WriteLine($"{fansV * 100.0 / fans:f2}%");
            Console.WriteLine($"{fansG * 100.0 / fans:f2}%");
            Console.WriteLine($"{fans * 100.0 / allSeats:f2}%");
        }
    }
}
