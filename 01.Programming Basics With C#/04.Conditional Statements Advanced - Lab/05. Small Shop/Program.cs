using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();  
            decimal qnt = decimal.Parse(Console.ReadLine());            
            if (town == "Sofia")
            {
                switch (product)
                {
                    case "coffee":                        
                        Console.WriteLine(qnt * 0.5m);
                        break;
                    case "water":
                        Console.WriteLine(qnt * 0.8m);
                        break;
                    case "beer":
                        Console.WriteLine(qnt * 1.2m);
                        break;
                    case "sweets":
                        Console.WriteLine(qnt * 1.45m);
                        break;
                    default:
                        Console.WriteLine(qnt * 1.6m);
                        break;
                }
            }
            else if (town == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(qnt * 0.4m);
                        break;
                    case "water":
                        Console.WriteLine(qnt * 0.7m);
                        break;
                    case "beer":
                        Console.WriteLine(qnt * 1.15m);
                        break;
                    case "sweets":
                        Console.WriteLine(qnt * 1.30m);
                        break;
                    default:
                        Console.WriteLine(qnt * 1.5m);
                        break;
                }
            }
            else
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(qnt * 0.45m);
                        break;
                    case "water":
                        Console.WriteLine(qnt * 0.7m);
                        break;
                    case "beer":
                        Console.WriteLine(qnt * 1.1m);
                        break;
                    case "sweets":
                        Console.WriteLine(qnt * 1.35m);
                        break;
                    default:
                        Console.WriteLine(qnt * 1.55m);
                        break;
                }
            }
        }
    }
}