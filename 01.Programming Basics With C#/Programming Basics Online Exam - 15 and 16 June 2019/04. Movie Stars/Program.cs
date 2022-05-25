using System;

namespace _04._Movie_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string actorName = null;
            double allSallaries = 0;
            while ((actorName = Console.ReadLine()) != "ACTION")
            {
                int nameLenght = (int)actorName.Length;
                double actorSallary = 0;
                if (nameLenght <= 15)
                    actorSallary = double.Parse(Console.ReadLine());
                else
                    actorSallary = (budget - allSallaries) * 0.2;
                allSallaries += actorSallary;
                if (allSallaries > budget)
                {
                    Console.WriteLine($"We need {allSallaries - budget:f2} leva for our actors.");
                    return;
                }
            }
            Console.WriteLine($"We are left with {budget - allSallaries:f2} leva.");
        }
    }
}
