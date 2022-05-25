using System;

namespace _10._Multiply_by_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            while (n >= 0)
            {
                double result = n * 2;
                Console.WriteLine($"Result: {result:f2}");
                n = double.Parse(Console.ReadLine());
            }
            if (n < 0)
                Console.WriteLine("Negative number!");
        }
    }
}
