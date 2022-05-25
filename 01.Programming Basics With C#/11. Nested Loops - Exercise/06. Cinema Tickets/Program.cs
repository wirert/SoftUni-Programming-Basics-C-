using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalTickets = 0;
            int studentsT = 0;
            int standartT = 0;
            int kidsT = 0;
            string film = Console.ReadLine();
            while (film != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());
                int tickets = 0;
                string typeSeats = Console.ReadLine(); 
                while (typeSeats != "End")
                {                    
                    tickets++;
                    if (typeSeats == "student")
                        studentsT++;
                    else if (typeSeats == "standard")
                        standartT++;
                    else if (typeSeats == "kid")
                        kidsT++;
                    if (seats == tickets)
                        break;
                    typeSeats = Console.ReadLine();
                }
                totalTickets += tickets;
                Console.WriteLine($"{film} - {tickets * 100.0 / seats:f2}% full.");
                
                film = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentsT * 100.0 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{standartT * 100.0 / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{kidsT * 100.0 / totalTickets:f2}% kids tickets.");
        }
    }
}
