using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = null;
            int sumPrimeNums = 0;
            int sumNonPrimeNums = 0;
            while ((command = Console.ReadLine()) != "stop")
            {
                int currNum = int.Parse(command);
                if (currNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                if (currNum == 0)
                    continue;

                bool isPrime = false;
                for (int i = 2; i < currNum; i++)
                {
                    if (currNum % i == 0)
                    {
                        sumNonPrimeNums += currNum;
                        isPrime = true;
                        break;
                    }
                }
                if (!isPrime)
                    sumPrimeNums += currNum;
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNums}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNums}");
        }
    }
}
