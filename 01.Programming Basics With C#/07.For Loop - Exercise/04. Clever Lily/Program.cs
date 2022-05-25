using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());
            int toysCount = 0;
            double moneyBirthday = 0;
            double moneyOfYear = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyOfYear = (i * 5) - 1;
                    moneyBirthday += moneyOfYear;
                }
                else
                    toysCount++;
            }
            double money = (toysCount * priceOfToy) + moneyBirthday;
            if (money >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {money - priceWashingMachine:f2}");
            }
            else
                Console.WriteLine($"No! {priceWashingMachine - money:f2}");
        }
    }
}
