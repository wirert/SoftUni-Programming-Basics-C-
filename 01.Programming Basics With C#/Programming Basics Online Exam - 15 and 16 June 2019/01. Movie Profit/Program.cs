using System;

namespace _01._Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            int daysInCinema = int.Parse(Console.ReadLine());
            int ticketsForDay = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percentForHall = int.Parse(Console.ReadLine());
            double income = daysInCinema * ticketsForDay * ticketPrice * (100 - percentForHall)/100;
            Console.WriteLine($"The profit from the movie {film} is {income:f2} lv.");
        }
    }
}
