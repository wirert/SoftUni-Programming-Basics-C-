using System;

namespace T02._Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = side * height * 0.5;
            Console.WriteLine($"{area:f2}");
                    }
    }
}
