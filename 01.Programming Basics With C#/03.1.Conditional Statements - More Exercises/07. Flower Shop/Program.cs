using System;

namespace _07._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numMagn = int.Parse(Console.ReadLine());
            int numZumbs = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());   
            int numCactus = int.Parse(Console.ReadLine());  
            double toyPrice = double.Parse(Console.ReadLine());
            double money = (numMagn * 3.25 + numZumbs * 4 + numRoses * 3.5 + numCactus * 8) * 0.95;
            if (money >= toyPrice)
                Console.WriteLine($"She is left with {Math.Floor(money - toyPrice)} leva.");
            else
                Console.WriteLine($"She will have to borrow {Math.Ceiling(toyPrice - money)} leva.");
        }
    }
}  
