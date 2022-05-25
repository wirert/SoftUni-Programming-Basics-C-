using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsCount = 0;
            string goingHome = null;
            int stepsGoingHome = 0;
            while (stepsCount < 10000)
            {
                goingHome = Console.ReadLine();
                if (goingHome == "Going home")
                {
                    stepsGoingHome = int.Parse(Console.ReadLine());
                    stepsCount += stepsGoingHome;
                    if (stepsCount < 10000)
                        Console.WriteLine($"{10000 - stepsCount} more steps to reach goal.");
                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{stepsCount - 10000} steps over the goal!");
                    }
                    break;
                }
                else
                {
                    int stepsPerWalk = int.Parse(goingHome);
                    stepsCount += stepsPerWalk;
                    if (stepsCount >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{stepsCount - 10000} steps over the goal!");
                    }
                }
            }
            
        }
    }
}
