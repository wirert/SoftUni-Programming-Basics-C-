using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritMoney = double.Parse(Console.ReadLine());
            int wantYear = int.Parse(Console.ReadLine());
            double spend = 0;
            for (int i = 1800; i <= wantYear; i++)
            {
                if (i % 2 == 0)
                    spend += 12000;
                else
                    spend += 12000 + 50 * (18 + i - 1800);
            }
            if (spend > inheritMoney)
                Console.WriteLine($"He will need {spend - inheritMoney:f2} dollars to survive.");
            else
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritMoney - spend:f2} dollars left.");
        }
    }
}
