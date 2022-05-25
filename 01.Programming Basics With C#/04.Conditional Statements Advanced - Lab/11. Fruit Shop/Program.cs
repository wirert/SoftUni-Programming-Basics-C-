using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qnt = double.Parse(Console.ReadLine());
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{qnt * 2.5:f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{qnt * 1.2:f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{qnt * 0.85:f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{qnt * 1.45:f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{qnt * 2.7:f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{qnt * 5.5:f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{qnt * 3.85:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{qnt * 2.70:f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{qnt * 1.25:f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{qnt * 0.9:f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{qnt * 1.60:f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{qnt * 3.0:f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{qnt * 5.60:f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{qnt * 4.20:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }                   
            }
            else
                Console.WriteLine("error");
        }
    }
}
   