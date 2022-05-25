using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int numJury = int.Parse(Console.ReadLine());
            double points = academyPoints;
            for (int i = 1; i <= numJury; i++)
            {
                string nameJury = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());
                juryPoints = (nameJury.Length) * juryPoints / 2;
                points += juryPoints;
                if (points > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
                    return;
                }

            }

            Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:f1} more!");
        }
    }
}
