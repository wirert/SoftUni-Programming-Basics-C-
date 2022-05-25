using System;

namespace _07._Safe_Passwords_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxNumPass = int.Parse(Console.ReadLine());
            int numPass = 0;
            int A = 34;
            int B = 63;
            int maxComb = 0;
            for (int x = 1; x <= a; x++)
            {
                for (int y = 1; y <= b; y++)
                {
                    A++;
                    if (A > 55)
                        A = 35;
                    B++;
                    if (B > 96)
                        B = 64;
                    numPass++;
                    maxComb++;
                    Console.Write($"{(char)A}{(char)B}{x}{y}{(char)B}{(char)A}|");
                    if (maxComb >= a * b)
                        return;
                    if (numPass >= maxNumPass)
                        return;
                }
            }
        }
    }
}
