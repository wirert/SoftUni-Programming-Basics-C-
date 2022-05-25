using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double gradus = radians * 180 / Math.PI;
            Console.WriteLine(gradus);
        }
    }
}
