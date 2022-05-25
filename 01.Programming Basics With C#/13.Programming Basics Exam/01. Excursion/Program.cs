using System;

namespace _01._Excursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopelInGroup = int.Parse(Console.ReadLine());
            int numNights = int.Parse(Console.ReadLine());
            int transportCards = int.Parse(Console.ReadLine());
            int museumTickets = int.Parse(Console.ReadLine());
            double price = (numNights * 20.0 + transportCards * 1.6 + museumTickets * 6.0) * peopelInGroup;
            price *= 1.25;
            Console.WriteLine($"{price:f2}");
        }
    }
}
