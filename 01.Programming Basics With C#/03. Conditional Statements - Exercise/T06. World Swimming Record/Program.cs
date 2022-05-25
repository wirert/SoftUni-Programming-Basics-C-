using System;

namespace T06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());            
            double time = lenght * speed + Math.Floor(lenght / 15) * 12.5;
            if (time < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {time - record:f2} seconds slower.");
            }

        }
    }
}
