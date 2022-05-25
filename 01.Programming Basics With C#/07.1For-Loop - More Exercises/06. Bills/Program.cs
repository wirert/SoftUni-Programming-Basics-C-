using System;

namespace _06._Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double countElTax = 0;
            for (int i = 1; i <= months; i++)
            {
                double taxEl = double.Parse(Console.ReadLine());
                countElTax += taxEl;
            }
            double taxOthers = (countElTax + months * (20 + 15)) * 1.2;
            Console.WriteLine($"Electricity: {countElTax:f2} lv");
            Console.WriteLine($"Water: {months * 20.0:f2} lv");
            Console.WriteLine($"Internet: {months * 15.0:f2} lv");
            Console.WriteLine($"Other: {taxOthers:f2} lv");
            Console.WriteLine($"Average: {(countElTax + months * (20 + 15) + taxOthers) / months:f2} lv");
        }
    }
}
