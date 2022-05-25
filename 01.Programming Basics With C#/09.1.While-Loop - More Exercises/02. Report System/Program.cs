using System;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int expectSum = int.Parse(Console.ReadLine());
            int sumCash = 0;
            int sumCard = 0;
            string command = null;
            int i = 0;
            int c = 0;
            int ca = 0;
            while ((command = Console.ReadLine()) != "End")
            {                
                i++;
                int currSum = int.Parse(command);
                if (i % 2 == 0)
                {                    
                    if (currSum < 10)
                        Console.WriteLine("Error in transaction!");
                    else
                    {
                        sumCard += currSum;
                        Console.WriteLine("Product sold!");
                        ca++;
                    }
                }
                else
                {                    
                    if (currSum > 100)
                        Console.WriteLine("Error in transaction!");
                    else
                    {
                        sumCash += currSum;
                        Console.WriteLine("Product sold!");
                        c++;
                    }
                }
                if (sumCash + sumCard >= expectSum)
                {
                    Console.WriteLine($"Average CS: {(double)sumCash/c:f2}");
                    Console.WriteLine($"Average CC: {(double)sumCard / ca:f2}");
                    break;
                }
            }
            if (sumCash + sumCard < expectSum)
                Console.WriteLine("Failed to collect required money for charity.");
        }
    }
}
