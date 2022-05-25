using System;

namespace _08._Sunglasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.Write(new String('*', 2 * n));
                    Console.Write(new String(' ', n));
                    Console.Write(new String('*', 2 * n));
                }
                else
                {
                    Console.Write('*');
                    Console.Write(new String('/', 2 * n - 2));
                    Console.Write('*');
                    if (row == (n + 1) / 2)
                        Console.Write(new String('|', n));
                    else
                        Console.Write(new String(' ', n));
                    Console.Write('*');
                    Console.Write(new String('/', 2 * n - 2));
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
