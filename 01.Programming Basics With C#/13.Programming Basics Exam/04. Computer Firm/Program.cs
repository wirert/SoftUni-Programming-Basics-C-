using System;

namespace _04._Computer_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numModels = int.Parse(Console.ReadLine());
            double allSales = 0;
            double allRatings = 0;
            for (int comp = 1; comp <= numModels; comp++)
            {
                int salesAndRating = int.Parse(Console.ReadLine());
                double rating = salesAndRating % 10;
                allRatings += rating;
                double sales = salesAndRating / 10;
                switch (rating)
                {
                    case 2:
                        sales = 0;
                        break;
                    case 3:
                        sales *= 0.5;
                        break;
                    case 4:
                        sales *= 0.7;
                        break;
                    case 5:
                        sales *= 0.85;
                        break;
                }
                allSales += sales;
            }
            Console.WriteLine($"{allSales:f2}");
            Console.WriteLine($"{allRatings / numModels:f2}");
        }
    }
}