using System;

namespace _03._Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numDrinks = int.Parse(Console.ReadLine());
            double priceOfDrink = 0;
            switch (drink)
            {
                case "Espresso":
                    switch (sugar)
                    {
                        case "Without":
                            priceOfDrink = 0.90;
                            break;
                        case "Normal":
                            priceOfDrink = 1;
                            break;
                        case "Extra":
                            priceOfDrink = 1.2;
                            break;
                    }
                    break;
                case "Cappuccino":
                    switch (sugar)
                    {
                        case "Without":
                            priceOfDrink = 1;
                            break;
                        case "Normal":
                            priceOfDrink = 1.2;
                            break;
                        case "Extra":
                            priceOfDrink = 1.6;
                            break;
                    }
                    break;
                default:
                    switch (sugar)
                    {
                        case "Without":
                            priceOfDrink = 0.5;
                            break;
                        case "Normal":
                            priceOfDrink = 0.6;
                            break;
                        case "Extra":
                            priceOfDrink = 0.7;
                            break;
                    }
                    break;
            }
            double totalPrice = priceOfDrink * numDrinks;
            if (sugar == "Without")
                totalPrice *= 0.65;
            if (numDrinks >= 7 && drink == "Espresso")
                totalPrice *= 0.75;
            if (totalPrice > 15)
                totalPrice *= 0.8;
            Console.WriteLine($"You bought {numDrinks} cups of {drink} for {totalPrice:f2} lv.");
        }
    }
}