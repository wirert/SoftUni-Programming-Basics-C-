using System;

namespace _04._Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wallHeigth = int.Parse(Console.ReadLine());
            int wallLength = int.Parse(Console.ReadLine());
            double percentNotPaint = double.Parse(Console.ReadLine());
            double hallWalls = wallHeigth * wallLength * 4;
            hallWalls -= (percentNotPaint * hallWalls / 100);
            hallWalls = (int)Math.Ceiling(hallWalls);
            string command = null;
            int wallsPainted = 0;
            while ((command = Console.ReadLine()) != "Tired!")
            {
                int numPaint = int.Parse(command);
                wallsPainted += numPaint;
                if (wallsPainted >= hallWalls)
                    break;
            }
            if (wallsPainted < hallWalls)
                Console.WriteLine($"{hallWalls - wallsPainted} quadratic m left.");
            else if (wallsPainted > hallWalls)
                Console.WriteLine($"All walls are painted and you have {wallsPainted - hallWalls} l paint left!");
            else
                Console.WriteLine("All walls are painted! Great job, Pesho!");

        }
    }
}
