using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLendth = int.Parse(Console.ReadLine());
            int numCakes = cakeLendth * cakeWidth;
            int cakeNeeded = 0;
            while (cakeNeeded <= numCakes)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    break;
                }
                else
                {
                    int cakesTaken = int.Parse(command);
                    cakeNeeded += cakesTaken;                   
                }
            }
            if (cakeNeeded <= numCakes)
            {
                Console.WriteLine($"{numCakes - cakeNeeded} pieces are left.");
            }
            else
                Console.WriteLine($"No more cake left! You need {cakeNeeded - numCakes} pieces more.");

        }
    }
}
