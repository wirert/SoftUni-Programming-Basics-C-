using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());
            bool isSpend = false;
            string action = null;
            int countSpendMoney = 0;
            int daysCount = 0;
            while (savedMoney < tripPrice)
            {
                action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCount++;
                if (action == "save")
                {
                    savedMoney += money;
                    countSpendMoney = 0;
                }
                else
                {
                    countSpendMoney++;
                    savedMoney -= money;
                    if (savedMoney < 0)
                        savedMoney = 0;
                }
                if (countSpendMoney >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(daysCount);
                    break;
                }
            }
            if (savedMoney >= tripPrice)
            Console.WriteLine($"You saved the money for {daysCount} days.");
        }
    }
}
