using System;

namespace T07._House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideX = double.Parse(Console.ReadLine());
            double sideY = double.Parse(Console.ReadLine());
            double roofH = double.Parse(Console.ReadLine());
            double wallsArea = sideX * sideX * 2 - 1.2 * 2 + sideX * sideY * 2 - 1.5 * 1.5 * 2;
            double roofArea = sideX * sideY * 2 + sideX * roofH;
            double greenPaint = wallsArea / 3.4;
            double redPaint = roofArea / 4.3;
            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
