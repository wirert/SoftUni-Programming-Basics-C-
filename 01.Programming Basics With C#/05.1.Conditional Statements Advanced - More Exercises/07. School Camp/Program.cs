using System;

namespace _07._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int numStudents = int.Parse(Console.ReadLine());
            int numNights = int.Parse(Console.ReadLine());
            string sport = null;
            double priceNights = 0;
            switch (season)
            {
                case "Winter":
                    {
                        switch (groupType)
                        {
                            case "girls":
                                sport = "Gymnastics";
                                priceNights = 9.6 * numNights * numStudents;
                                break;
                            case "boys":
                                sport = "Judo";
                                priceNights = 9.6 * numNights * numStudents;
                                break;
                            default:
                                sport = "Ski";
                                priceNights = 10 * numNights * numStudents;
                                break;                                
                        }
                        break;
                    }
                case "Spring":
                    {
                        switch (groupType)
                        {
                            case "girls":
                                sport = "Athletics";
                                priceNights = 7.2 * numNights * numStudents;
                                break;
                            case "boys":
                                sport = "Tennis";
                                priceNights = 7.2 * numNights * numStudents;
                                break;
                            default:
                                sport = "Cycling";
                                priceNights = 9.5 * numNights * numStudents;
                                break;
                        }
                        break;
                    }
                case "Summer":
                    {
                        switch (groupType)
                        {
                            case "girls":
                                sport = "Volleyball";
                                priceNights = 15 * numNights * numStudents;
                                break;
                            case "boys":
                                sport = "Football";
                                priceNights = 15 * numNights * numStudents;
                                break;
                            default:
                                sport = "Swimming";
                                priceNights = 20 * numNights * numStudents;
                                break;
                        }
                        break;
                    }                    
            }
            if (numStudents >= 50)
                priceNights *= 0.5;
            else if (numStudents >= 20)
                priceNights *= 0.85;
            else if (numStudents >= 10)
                priceNights *= 0.95;
            Console.WriteLine($"{sport} {priceNights:f2} lv.");
        }
    }
}