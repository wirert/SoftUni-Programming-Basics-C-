using System;

namespace _02._Movie_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeForShooting = int.Parse(Console.ReadLine());
            int numScenes = int.Parse(Console.ReadLine());
            int timeOfScene = int.Parse(Console.ReadLine());
            double timeNeeded = 0.15 * timeForShooting + numScenes * timeOfScene;
            if (timeNeeded <= timeForShooting)
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForShooting - timeNeeded)} minutes left!");
            else
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(timeNeeded - timeForShooting)} minutes.");
        }
    }
}
