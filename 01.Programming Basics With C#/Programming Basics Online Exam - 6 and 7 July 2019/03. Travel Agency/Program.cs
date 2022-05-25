using System;

namespace _03._Travel_Agency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string mode = Console.ReadLine();
            string vipOrNot = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double pricePerDay = 0;
            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            switch (town)
            {
                case "Bansko":
                case "Borovets":
                    switch (mode)
                    {
                        case "withEquipment":
                            pricePerDay = 100;
                            if (vipOrNot == "yes")
                                pricePerDay *= 0.9;
                            break;
                        case "noEquipment":
                            pricePerDay = 80;
                            if (vipOrNot == "yes")
                                pricePerDay *= 0.95;
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            return;
                    }
                    break;
                case "Varna":
                case "Burgas":
                    switch (mode)
                    {
                        case "withBreakfast":
                            pricePerDay = 130;
                            if (vipOrNot == "yes")
                                pricePerDay *= 0.88;
                            break;
                        case "noBreakfast":
                            pricePerDay = 100;
                            if (vipOrNot == "yes")
                                pricePerDay *= 0.93;
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            return;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input!");
                    return;

            }
            double totalPrice = days * pricePerDay;
            if (days > 7)
                totalPrice -= pricePerDay;
            Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
        }
    }
}