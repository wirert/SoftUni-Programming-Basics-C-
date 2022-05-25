using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int coinsNum = 0;

            while (change > 0)
            {
                if (change / 2 >= 1)
                {
                    decimal coins2lv = Math.Floor(change / 2);
                    coinsNum += (int)coins2lv;
                    change -= coins2lv * 2;
                }
                else if (Math.Floor(change) == 1)
                {
                    coinsNum++;
                    change--;
                }
                else if (Math.Floor(change / 0.50m) == 1)
                {
                    coinsNum++;
                    change -= 0.5m;
                }
                else if (Math.Floor(change / 0.20m) >= 1)
                {
                    decimal coins20St = Math.Floor(change / 0.2m);
                    coinsNum += (int)coins20St;
                    change -= coins20St * 0.2m;
                }
                else if (Math.Floor(change / 0.1m) == 1)
                {
                    coinsNum++;
                    change -= 0.1m;
                }
                else if (Math.Floor(change / 0.05m) == 1)
                {
                    coinsNum++;
                    change -= 0.05m;
                }
                else if (Math.Floor(change / 0.02m) >= 1)
                {
                    decimal coins2St = Math.Floor(change / 0.02m);
                    coinsNum += (int)coins2St;
                    change -= coins2St * 0.02m;
                }
                else
                {
                    coinsNum++;
                    change -= 0.01m;
                }
            }
            Console.WriteLine(coinsNum);
        }
    }
}
