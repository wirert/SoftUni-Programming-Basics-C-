using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char simbol = char.Parse(Console.ReadLine());
            double result = 0;
            if (simbol == '+' || simbol == '-' || simbol == '*')
            {
                string evenOrOdd = "odd";
                if (simbol == '+')
                    result = num1 + num2;
                else if (simbol == '-')
                    result = num1 - num2;
                else
                    result = num1 * num2;
                if (result % 2 == 0)
                    evenOrOdd = "even";
                Console.WriteLine($"{num1} {simbol} {num2} = {result} - {evenOrOdd}");
            }
            else
            {
                if (num2 == 0)
                    Console.WriteLine($"Cannot divide {num1} by zero");
                else
                {
                    if (simbol == '/')
                    {
                        result = 1.0 * num1 / num2;
                        Console.WriteLine($"{num1} {simbol} {num2} = {result:f2}");
                    }
                    else
                    {
                        result = num1 % num2;
                        Console.WriteLine($"{num1} {simbol} {num2} = {result}");
                    }

                }
            }
        }
    }
}
