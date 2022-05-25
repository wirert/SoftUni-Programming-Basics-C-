using System;

namespace _02._Bracelet_Stand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pocketMoney = double.Parse(Console.ReadLine());
            double salesMoney = double.Parse(Console.ReadLine());
            double allExpences = double.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double collectedMoney = pocketMoney * 5 + salesMoney * 5 - allExpences;
            if (collectedMoney < presentPrice)
                Console.WriteLine($"Insufficient money: {presentPrice - collectedMoney:f2} BGN.");
            else
                Console.WriteLine($"Profit: {collectedMoney:f2} BGN, the gift has been purchased.");

        }
    }
}
