using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            for (int x1 = p; x1 <= q; x1++)
            {
                for (int x2 = p; x2 <= q; x2++)
                {
                    combinations++;
                    if (x1 + x2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({x1} + {x2} = {magicNumber})");
                        return;
                    }
                }

            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}
