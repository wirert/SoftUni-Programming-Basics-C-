using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spaceWidth = int.Parse (Console.ReadLine());
            int spaceLength = int.Parse (Console.ReadLine());
            int spaceHeight = int.Parse (Console.ReadLine());
            int spaceVolume = spaceHeight * spaceWidth * spaceLength;
            int spaceNeeded = 0;
            while (spaceNeeded <= spaceVolume)
            {
                string command = Console.ReadLine ();
                if (command == "Done")
                    break;
                else
                {
                    int boxes = int.Parse (command);
                    spaceNeeded += boxes;
                }
            }
            if (spaceNeeded <= spaceVolume)
                Console.WriteLine($"{spaceVolume - spaceNeeded} Cubic meters left.");
            else
                Console.WriteLine($"No more free space! You need {spaceNeeded - spaceVolume} Cubic meters more.");
        }
    }
}
