using System;

namespace _06._Name_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            int maxPoints = int.MinValue;
            string winName = null;
            while ((name = Console.ReadLine()) != "Stop")
            {
                int points = 0;
                foreach (var letter in name)
                {
                    int gessNum = int.Parse(Console.ReadLine());
                    if (gessNum == (int)letter)
                        points += 10;
                    else
                        points += 2;
                    
                }
                if (points >= maxPoints)
                {
                    maxPoints = points;
                    winName = name;
                }
            }
            Console.WriteLine($"The winner is {winName} with {maxPoints} points!");
        }
    }
}
