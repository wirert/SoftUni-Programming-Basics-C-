using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCompetitions = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int earntPoints = 0;
            int numWinning = 0;
            for (int i = 1; i <= numCompetitions; i++)
            {
                string position = Console.ReadLine();
                if (position == "W")
                {
                    earntPoints += 2000;
                    numWinning++;
                }
                else if (position == "F")
                    earntPoints += 1200;
                else if (position == "SF")
                    earntPoints += 720;
            }
            Console.WriteLine($"Final points: {earntPoints + startPoints}");
            Console.WriteLine($"Average points: {earntPoints/numCompetitions}");
            Console.WriteLine($"{numWinning*100.0/numCompetitions:f2}%");
        }
    }
}
