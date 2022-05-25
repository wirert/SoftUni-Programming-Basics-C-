using System;

namespace _05._Football_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int numMatches = int.Parse(Console.ReadLine());
            if (numMatches == 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
                return;
            }
            int points = 0;
            int wins = 0;
            int equals = 0;
            int losses = 0;
            for (int i = 1; i <= numMatches; i++)
            {
                string result = Console.ReadLine();
                if (result == "W")
                {
                    wins++;
                    points += 3;
                }
                else if (result == "D")
                {
                    equals++;
                    points += 1;
                }
                else
                    losses++;
            }
            Console.WriteLine($"{teamName} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {wins}");
            Console.WriteLine($"## D: {equals}");
            Console.WriteLine($"## L: {losses}");
            Console.WriteLine($"Win rate: {wins * 100.0 / numMatches:f2}%");
        }
    }
}
