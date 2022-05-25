using System;

namespace T08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());
            double lunchTime = breakTime * 0.125;
            double restTime = breakTime * 0.25;
            double timeLeft = breakTime - lunchTime - restTime;
            if (timeLeft >= episodeTime)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(timeLeft - episodeTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(episodeTime - timeLeft)} more minutes.");
            }

        }
    }
}
