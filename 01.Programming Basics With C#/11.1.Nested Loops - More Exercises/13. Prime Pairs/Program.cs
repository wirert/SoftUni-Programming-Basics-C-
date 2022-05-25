using System;

namespace _13._Prime_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start1 = int.Parse(Console.ReadLine());
            int start2 = int.Parse(Console.ReadLine());
            int end1 = int.Parse(Console.ReadLine());
            int end2 = int.Parse(Console.ReadLine());
            end1 += start1;
            end2 += start2;
            for (int first = start1; first <= end1; first++)
            {
                bool isPrime1 = false;
                for (int i = 2; i <= (int)Math.Sqrt((double)first) + 1; i++)
                {
                    if (first % i == 0)
                    {
                        isPrime1 = false;
                        break;
                    }
                    else
                        isPrime1 = true;
                }
                if (isPrime1)
                {
                    for (int second = start2; second <= end2; second++)
                    {
                        bool isPrime2 = false;
                        for (int j = 2; j <= (int)Math.Sqrt((double)second) + 1; j++)
                        {
                            if (second % j == 0)
                            {
                                isPrime2 = false;
                                break;
                            }
                            else
                                isPrime2 = true;
                        }
                        if (isPrime2)
                            Console.WriteLine($"{first}{second}");
                    }
                }
            }
        }
    }
}
