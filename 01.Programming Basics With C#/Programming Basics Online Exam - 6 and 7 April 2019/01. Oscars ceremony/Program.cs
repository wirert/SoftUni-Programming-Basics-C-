using System;

namespace _01._Oscars_ceremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hallPrice = int.Parse(Console.ReadLine());
            double statuePrice = 0.7 * hallPrice;
            double foodPrice = 0.85 * statuePrice;
            double soundPrice = foodPrice / 2;
            double payPrice = hallPrice + statuePrice + foodPrice + soundPrice;
            Console.WriteLine($"{payPrice:f2}");
        }
    }
}
