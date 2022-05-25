using System;

namespace lecture1._08
{
    class Program
    {
        static void Main(string[] args)
        {
            int broikuche = int.Parse(Console.ReadLine());
            int broikotka = int.Parse(Console.ReadLine());
            double price = broikuche * 2.50 + broikotka * 4;
            Console.WriteLine($"{price} lv.");
        }
    }
}
