using System;

namespace _03._Oscars_week_in_cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            string roomType = Console.ReadLine();
            int boughtTickets = int.Parse(Console.ReadLine());
            double ticketPrice = 0;
            switch (film)
            {
                case "A Star Is Born":
                    switch (roomType)
                    {
                        case "normal":
                            ticketPrice = 7.5;
                            break;
                        case "luxury":
                            ticketPrice = 10.5;
                            break;
                        default:
                            ticketPrice = 13.5;
                            break;
                    }
                    break;
                case "Bohemian Rhapsody":
                    switch (roomType)
                    {
                        case "normal":
                            ticketPrice = 7.35;
                            break;
                        case "luxury":
                            ticketPrice = 9.45;
                            break;
                        default:
                            ticketPrice = 12.75;
                            break;
                    }
                    break;
                case "Green Book":
                    switch (roomType)
                    {
                        case "normal":
                            ticketPrice = 8.15;
                            break;
                        case "luxury":
                            ticketPrice = 10.25;
                            break;
                        default:
                            ticketPrice = 13.25;
                            break;
                    }
                    break;
                default:
                    switch (roomType)
                    {
                        case "normal":
                            ticketPrice = 8.75;
                            break;
                        case "luxury":
                            ticketPrice = 11.55;
                            break;
                        default:
                            ticketPrice = 13.95;
                            break;
                    }
                    break;
            }
            Console.WriteLine($"{film} -> {ticketPrice * boughtTickets:f2} lv.");
        }
    }
}