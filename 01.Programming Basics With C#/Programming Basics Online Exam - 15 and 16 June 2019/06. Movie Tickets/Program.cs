using System;

namespace _06._Movie_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int s1 = a1; s1 <= a2 - 1; s1++)
            {
                if (s1 % 2 == 0)
                    continue;
                for (int s2 = 1; s2 <= n - 1; s2++)
                {
                    for (int s3 = 1; s3 <= n / 2 - 1; s3++)
                    {
                        if ((s2 + s3 + s1) % 2 == 0)
                            continue;
                        char sch1 = (char)s1;
                        Console.WriteLine($"{sch1}-{s2}{s3}{s1}");
                    }
                }
            }
        }
    }
}
