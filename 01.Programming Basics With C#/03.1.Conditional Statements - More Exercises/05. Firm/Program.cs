using System;

namespace _05._Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysAvailable = int.Parse(Console.ReadLine());
            int workersOverTime = int.Parse(Console.ReadLine());
            double workingDays = daysAvailable * 0.9;
            double workingHours = workersOverTime * daysAvailable * 2 + workingDays * 8;
            if (workingHours < hoursNeeded)
            {
                Console.WriteLine($"Not enough time!{Math.Ceiling(hoursNeeded - workingHours)} hours needed.");
            }
            else
                Console.WriteLine($"Yes!{Math.Floor(workingHours - hoursNeeded)} hours left.");
        }
    }
}
