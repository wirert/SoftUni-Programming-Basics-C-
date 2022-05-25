using System;

namespace _04._Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double targetProfit = double.Parse(Console.ReadLine());
            string coctail = null;
            double accMoney = 0;

            while ((coctail = Console.ReadLine()) != "Party!")
            {
                int priceOfCoctail = coctail.Length;
                int numCoctails = int.Parse(Console.ReadLine());
                int orderPrice = numCoctails * priceOfCoctail;
                if (orderPrice % 2 == 0)
                    accMoney += orderPrice;
                else
                    accMoney += orderPrice * 0.75;
                if (accMoney >= targetProfit)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }
            }
            if (accMoney < targetProfit)
                Console.WriteLine($"We need {targetProfit - accMoney:f2} leva more.");
            Console.WriteLine($"Club income - {accMoney:f2} leva.");
        }
    }
}
