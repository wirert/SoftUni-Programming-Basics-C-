using System;

namespace T05._Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double roomLength = double.Parse(Console.ReadLine());
            double roomWidth = double.Parse(Console.ReadLine());
            double deskPerRow = Math.Floor((roomWidth * 100 - 100) / 70);
            double rows = Math.Floor(roomLength * 100 / 120);
            double desks = deskPerRow * rows - 3;
            Console.WriteLine(desks);
        }
    }
}
