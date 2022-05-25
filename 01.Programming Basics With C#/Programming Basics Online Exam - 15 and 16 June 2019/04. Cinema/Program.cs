using System;

namespace _04._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seats = int.Parse(Console.ReadLine());
            string command = null;
            int allTickets = 0;
            int allIncome = 0;
            while ((command = Console.ReadLine()) != "Movie time!")
            {
                int tickets = int.Parse(command);
                if (tickets > seats - allTickets)
                {
                    Console.WriteLine("The cinema is full.");
                    Console.WriteLine($"Cinema income - {allIncome} lv.");
                    return;
                }
                int income = tickets * 5;
                allTickets += tickets;
                if (tickets % 3 == 0)
                    income -= 5;
                allIncome += income;
            }
            Console.WriteLine($"There are {seats - allTickets} seats left in the cinema.");
            Console.WriteLine($"Cinema income - {allIncome} lv.");
        }
    }
}
