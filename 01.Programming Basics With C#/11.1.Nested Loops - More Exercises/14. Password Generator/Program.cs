using System;

namespace _14._Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int d1 = 1; d1 <= n; d1++)
            {
                for (int d2 = 1; d2 <= n; d2++)
                {
                    for (int d3 = 97; d3 < l + 97; d3++)
                    {
                        for (int d4 = 97; d4 < l + 97; d4++)
                        {
                            for (int d5 = 1; d5 <= n; d5++)
                            {
                                if (d5 <= d1 || d5 <= d2)                                
                                    continue;                                
                                Console.Write($"{d1}{d2}{(char)d3}{(char)d4}{d5} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
