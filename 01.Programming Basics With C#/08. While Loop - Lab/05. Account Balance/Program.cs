using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;
            string inputText;
            while ((inputText = Console.ReadLine()) != "NoMoreMoney")
            {
               double inputMoney = double.Parse(inputText);
                if (inputMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    totalSum += inputMoney;
                    Console.WriteLine($"Increase: {inputMoney:f2}");
                }
            }
            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
