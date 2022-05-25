using System;

namespace _03._Film_Premiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            string options = Console.ReadLine();
            int numTickets = int.Parse(Console.ReadLine());
            double ticketPrice = 0;
            switch (film)
            {
                case "John Wick":
                    switch (options)
                    {
                        case "Drink":
                            ticketPrice = 12;
                            break;
                        case "Popcorn":
                            ticketPrice = 15;
                            break;
                        default:
                            ticketPrice = 19;
                            break;
                    }
                    break;
                case "Star Wars":
                    switch (options)
                    {
                        case "Drink":
                            ticketPrice = 18;
                            break;
                        case "Popcorn":
                            ticketPrice = 25;
                            break;
                        default:
                            ticketPrice = 30;
                            break;
                    }
                    if (numTickets >= 4)
                        ticketPrice *= 0.7;
                    break;
                default:
                    switch (options)
                    {
                        case "Drink":
                            ticketPrice = 9;
                            break;
                        case "Popcorn":
                            ticketPrice = 11;
                            break;
                        default:
                            ticketPrice = 14;
                            break;
                    }
                    if (numTickets == 2)
                        ticketPrice *= 0.85;
                    break;
            }
            Console.WriteLine($"Your bill is {ticketPrice * numTickets:f2} leva.");
        }
    }
}
