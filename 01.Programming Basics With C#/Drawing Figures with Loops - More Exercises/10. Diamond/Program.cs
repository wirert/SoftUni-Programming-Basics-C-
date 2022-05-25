using System;

namespace _10._Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("*");
                return;
            }
            if (n == 2)
            {
                Console.WriteLine("**");
                return;
            }
            int dashes = (n - 1) / 2;
            int mid = 0;
            Console.Write(new String('-', dashes));
            if (n % 2 == 0)
            {
                mid = 2;
                Console.Write("**");
            }
            else
            {
                mid = 1;
                Console.Write("*");
            }

            Console.Write(new String('-', dashes));
            Console.WriteLine();
            for (int row1 = 2; row1 <= (n + 1) / 2; row1++)
            {
                dashes--;
                Console.Write(new String('-', dashes));
                Console.Write("*");
                Console.Write(new String('-', mid));
                Console.Write("*");
                Console.Write(new String('-', dashes));
                Console.WriteLine();
                mid += 2;
            }
            mid -= 4;
            for (int row2 = (n + 1) / 2 - 1; row2 >= 2; row2--)
            {
                dashes++;
                Console.Write(new String('-', dashes));
                Console.Write("*");
                Console.Write(new String('-', mid));
                Console.Write("*");
                Console.Write(new String('-', dashes));
                Console.WriteLine();
                mid -= 2;
            }
            Console.Write(new String('-', (n - 1) / 2));
            if (n % 2 == 0)
                Console.Write("**");
            else
                Console.Write("*");
            Console.Write(new String('-', (n - 1) / 2));
        }
    }
}
