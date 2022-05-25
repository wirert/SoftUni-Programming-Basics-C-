using System;

namespace _05._Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double runs = double.Parse(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int countInvalid = 0;
            double numSum = 0;
            for (int i = 1; i <= runs; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0 || number > 50)
                {
                    countInvalid++;
                    numSum /= 2;
                }
                else if (number < 10)
                {
                    count1++;
                    numSum += number * 0.2;
                }
                else if (number < 20)
                {
                    count2++;
                    numSum += number * 0.3;
                }
                else if (number < 30)
                {
                    count3++;
                    numSum += number * 0.4;
                }
                else if (number < 40)
                {
                    count4++;
                    numSum += 50;
                }
                else
                {
                    count5++;
                    numSum += 100;
                }
            }
            Console.WriteLine($"{numSum:f2}");
            Console.WriteLine($"From 0 to 9: {count1 * 100 / runs:f2}%");
            Console.WriteLine($"From 10 to 19: {count2 * 100 / runs:f2}%");
            Console.WriteLine($"From 20 to 29: {count3 * 100 / runs:f2}%");
            Console.WriteLine($"From 30 to 39: {count4 * 100 / runs:f2}%");
            Console.WriteLine($"From 40 to 50: {count5 * 100 / runs:f2}%");
            Console.WriteLine($"Invalid numbers: {countInvalid * 100 / runs:f2}%");
        }
    }
}
