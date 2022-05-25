using System;

namespace _09._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                        combinations++;
                    if (a + b == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({a} + {b} = {magicNumber})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}
