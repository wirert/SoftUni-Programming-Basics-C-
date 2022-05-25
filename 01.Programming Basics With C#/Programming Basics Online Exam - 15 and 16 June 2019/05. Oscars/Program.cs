using System;

namespace _05._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double allPoints = academyPoints;

            for (int i = 1; i <= n; i++)
            {
                string juryName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());
                int nameLenght = (int)juryName.Length;
                juryPoints = juryPoints * nameLenght / 2;
                allPoints += juryPoints;
                if (allPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {allPoints:f1}!");
                    return;
                }
            }
            Console.WriteLine($"Sorry, {actorName} you need {1250.5 - allPoints:f1} more!");

        }
    }
}
