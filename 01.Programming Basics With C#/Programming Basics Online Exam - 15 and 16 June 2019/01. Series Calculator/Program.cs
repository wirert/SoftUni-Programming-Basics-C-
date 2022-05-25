using System;

namespace _01._Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double durationWithoutCommers = double.Parse(Console.ReadLine());
            double totalTime = seasons * episodes * durationWithoutCommers * 1.2 + seasons * 10;
            Console.WriteLine($"Total time needed to watch the {serialName} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
