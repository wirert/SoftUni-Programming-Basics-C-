using System;

namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours < 24; hours++)
            {
                for (int min = 0; min < 60; min++)
                {
                    Console.WriteLine($"{hours}:{min}");
                }
            }            
        }
    }
}
