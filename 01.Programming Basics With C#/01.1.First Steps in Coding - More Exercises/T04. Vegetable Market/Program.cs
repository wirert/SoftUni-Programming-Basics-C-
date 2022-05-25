using System;

namespace T04._Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegeKilos = int.Parse(Console.ReadLine());
            int fruitKilos = int.Parse(Console.ReadLine());
            double price = (vegePrice * vegeKilos + fruitPrice * fruitKilos) / 1.94;
            Console.WriteLine($"{price:f2}");
        }
    }
}
