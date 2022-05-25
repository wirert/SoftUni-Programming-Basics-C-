using System;

namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();
            string currPass;
            while ((currPass = Console.ReadLine()) != password)
            {

            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
