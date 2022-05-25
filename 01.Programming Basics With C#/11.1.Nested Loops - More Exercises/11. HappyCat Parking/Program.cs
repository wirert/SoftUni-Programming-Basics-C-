using System;

namespace _11._HappyCat_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double allPrice = 0;
            for (int day = 1; day <= days; day++)
            {
                double priceForDay = 0;
                if (day % 2 == 0)
                {
                    for (int hour = 1; hour <= hours; hour++)
                    {
                        if ((hour % 2) != 0)
                            priceForDay += 2.5;
                        else
                            priceForDay += 1;
                    }
                }
                else
                {
                    for (int hour = 1; hour <= hours; hour++)
                    {
                        if ((hour % 2) == 0)
                            priceForDay += 1.25;
                        else
                            priceForDay += 1;
                    }
                }
                allPrice += priceForDay;
                Console.WriteLine($"Day: {day} - {priceForDay:f2} leva");
            }
            Console.WriteLine($"Total: {allPrice:f2} leva");
        }
    }
}
