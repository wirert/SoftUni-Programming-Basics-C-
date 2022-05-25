using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double appartPrice = 0;
            if (month == "May" || month == "October")
            {
                studioPrice = numNights * 50;
                appartPrice = numNights * 65;
                if (numNights > 14)
                {
                    studioPrice *= 0.7;
                    appartPrice *= 0.9;
                }
                else if (numNights > 7)
                    studioPrice *= 0.95;   
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = numNights * 75.20;
                appartPrice = numNights * 68.70;
                if (numNights > 14)
                {
                    studioPrice *= 0.8;
                    appartPrice *= 0.9;
                }
            }
            else
            {
                studioPrice = numNights * 76;
                appartPrice = numNights * 77;
                if (numNights > 14)
                    appartPrice *= 0.9;
            }
            Console.WriteLine($"Apartment: {appartPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
