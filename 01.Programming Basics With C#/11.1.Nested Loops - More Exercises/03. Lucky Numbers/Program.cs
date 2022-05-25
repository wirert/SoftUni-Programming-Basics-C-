using System;

namespace _03._Lucky_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int dig1 = 1; dig1 <= 9 && dig1 < n; dig1++)
            {

                for (int dig2 = 1; dig2 <= 9 && dig2 < n; dig2++)
                {
                    if (((dig1 + dig2) % n != 0) && (n % (dig1 + dig2) != 0))
                        continue;
                    for (int dig3 = 1; dig3 <= 9 && dig3 < n; dig3++)
                    {
                        for (int dig4 = 1; dig4 <= 9 && dig4 < n; dig4++)
                        {
                            if (dig1 + dig2 == dig3 + dig4)
                            {
                                Console.Write($"{dig1}{dig2}{dig3}{dig4} ");
                            }
                        }
                    }
                }

            }
        }
    }
}
