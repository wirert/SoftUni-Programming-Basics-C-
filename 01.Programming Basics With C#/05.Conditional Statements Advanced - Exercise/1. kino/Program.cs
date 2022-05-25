using System;

namespace _01._kino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int seats  =rows * columns;
            if (type == "Premiere")
                Console.WriteLine($"{seats * 12.00:f2} leva");
            else if (type == "Normal")
                Console.WriteLine($"{seats * 7.50:f2} leva");
            else
                Console.WriteLine($"{seats * 5.00:f2} leva");
        }
    }
}