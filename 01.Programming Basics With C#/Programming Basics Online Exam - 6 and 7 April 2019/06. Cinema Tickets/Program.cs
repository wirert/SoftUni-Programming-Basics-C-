using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            int totalTickets = 0; ;
            string filmName = null;
            while ((filmName = Console.ReadLine()) != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());
                int numTickets = 0;
                for (int i = 1; i <= seats; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                        break;
                    numTickets++;
                    if (ticketType == "student")
                        studentTickets++;
                    else if (ticketType == "standard")
                        standardTickets++;
                    else if (ticketType == "kid")
                        kidTickets++;
                }
                Console.WriteLine($"{filmName} - {numTickets * 100.0 / seats:f2}% full.");
                totalTickets += numTickets;

            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets * 100.0 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{standardTickets * 100.0 / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets * 100.0 / totalTickets:f2}% kids tickets.");
        }
    }
}
