using System;

namespace _10._Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1Coins = int.Parse(Console.ReadLine());
            int num2Coins = int.Parse(Console.ReadLine());
            int num5Banknotes = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            for (int count1 = 0; count1 <= num1Coins; count1++)
            {
                for (int count2 = 0; count2 <= num2Coins; count2++)
                {
                    for (int count5 = 0; count5 <= num5Banknotes; count5++)
                    {
                        int currSum = count1 + 2 * count2 + 5 * count5;
                        if (currSum == sum)
                            Console.WriteLine($"{count1} * 1 lv. + {count2} * 2 lv. + {count5} * 5 lv. = {sum} lv.");
                    }
                }
            }
        }
    }
}
