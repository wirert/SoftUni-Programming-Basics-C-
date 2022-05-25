using System;

namespace _03._ClassAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.Write("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }                     
        }
    }
}
