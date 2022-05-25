using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = null;
            while ((destination = Console.ReadLine()) != "End")
            {
                double moneyNeeded = double.Parse(Console.ReadLine());
                double moneyCollected = 0;
                while (moneyCollected < moneyNeeded)
                {
                    moneyCollected += double.Parse(Console.ReadLine());
                    if (moneyCollected >= moneyNeeded)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
            }
        }
    }
}
