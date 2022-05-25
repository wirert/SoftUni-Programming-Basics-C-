using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                int currNum = i;
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 6; j > 0; j--)
                {
                    int num = currNum % 10;
                    currNum /= 10;
                    if (j % 2 == 0)
                        evenSum += num;
                    else
                        oddSum += num;

                }
                if (evenSum == oddSum)
                    Console.Write(i + " ");

            }

        }
    }
}
