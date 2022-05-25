using System;

namespace _08._Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = sum;
            int diff = 0;
            int maxDiff = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                sum1 = sum;
                int p = int.Parse(Console.ReadLine());
                int q = int.Parse(Console.ReadLine());
                sum = p + q;
                if (sum != sum1 && i != 1)
                    diff = Math.Abs(sum - sum1);
                if (diff > maxDiff)
                    maxDiff = diff;
            }
            if (maxDiff != 0)
                Console.WriteLine($"No, maxdiff={maxDiff}");
            else
                Console.WriteLine($"Yes, value={sum}");
        }
    }
}
