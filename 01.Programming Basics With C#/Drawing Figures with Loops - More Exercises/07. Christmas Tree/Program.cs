using System;

namespace _07._Christmas_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n + 1; row++)
            {
                for (int space = n - row; space >= 0; space--)
                {
                    Console.Write(' ');
                }
                for (int x = 1; x <= row - 1; x++)
                {
                    Console.Write('*');
                }
                Console.Write(" |");
                if (row != 1)
                    Console.Write(' ');
                for (int x = row - 1; x > 0; x--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
