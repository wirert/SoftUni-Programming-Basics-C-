using System;

namespace _09._House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new String('-', (n - 1) / 2));
            int zv = 0;
            if (n % 2 == 0)
            {
                Console.Write("**");
                zv = 2;
            }
            else
            {
                Console.Write('*');
                zv = 1;
            }
            Console.Write(new String('-', (n - 1) / 2));
            Console.WriteLine();
            int m = (n - 1) / 2;
            for (int row = 2; row <= (n + 1) / 2; row++)
            {
                m--;
                Console.Write(new String('-', m));
                zv += 2;
                Console.Write(new String('*', zv));
                Console.Write(new String('-', m));
                Console.WriteLine();
                if (zv == n)
                    break;
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write('|');
                Console.Write(new String('*', n - 2));
                Console.Write('|');
                Console.WriteLine();
            }
        }
    }
}
