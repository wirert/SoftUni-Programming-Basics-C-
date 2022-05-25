using System;

namespace _06._Wedding_Seats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char lastSector = char.Parse(Console.ReadLine());
            int firstSectorRows = int .Parse(Console.ReadLine());
            int numOddRowSeats = int .Parse(Console.ReadLine());
            int numRowSeats = 0;
            int allSeats = 0;
            int sectorRows = firstSectorRows;
            for (char sector = 'A'; sector <= lastSector; sector++)
            {                
                if (sector != 'A')
                    sectorRows++;
                for (int row = 1; row <= sectorRows; row++)
                {
                    numRowSeats = numOddRowSeats;
                    if (row % 2 == 0)
                        numRowSeats += 2;
                    for (int seat = 97; seat < numRowSeats + 97; seat++)
                    {  
                        allSeats++;
                        Console.WriteLine($"{sector}{row}{(char)seat}");
                    }
                }
            }
            Console.WriteLine(allSeats);
        }
    }
}
