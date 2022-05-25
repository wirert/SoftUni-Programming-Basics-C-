using System;

namespace _04._Car_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int dig1 = start; dig1 <= end; dig1++)
            {
                if (dig1 % 2 == 0)
                {
                    for (int dig2 = start; dig2 <= end; dig2++)
                    {
                        for (int dig3 = start; dig3 <= end; dig3++)
                        {
                            if ((dig2 + dig3) % 2 != 0)
                                continue;
                            for (int dig4 = start; dig4 <= end; dig4++)
                            {
                                if (dig4 % 2 == 0 || dig4 > dig1)
                                    continue;
                                Console.Write($"{dig1}{dig2}{dig3}{dig4} ");
                            }
                        }
                    }
                }
                else
                {
                    for (int dig2 = start; dig2 <= end; dig2++)
                    {
                        for (int dig3 = start; dig3 <= end; dig3++)
                        {
                            if ((dig2 + dig3) % 2 != 0)
                                continue;
                            for (int dig4 = start; dig4 <= end; dig4++)
                            {
                                if (dig4 % 2 != 0 || dig4 > dig1)
                                    continue;
                                Console.Write($"{dig1}{dig2}{dig3}{dig4} ");
                            }
                        }

                    }


                }

            }


        }
    }
}
