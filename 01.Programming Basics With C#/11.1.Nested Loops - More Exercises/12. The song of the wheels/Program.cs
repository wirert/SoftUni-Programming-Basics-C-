using System;

namespace _12._The_song_of_the_wheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ctrlNum = int.Parse(Console.ReadLine());
            int numFours = 0;            
            int a4 = 0;
            int b4 = 0;
            int c4 = 0;
            int d4 = 0;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    if (a >= b)
                        continue;
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (d >= c)
                                continue;
                            if (a * b + c * d == ctrlNum)
                            {
                                numFours++;
                                Console.Write($"{a}{b}{c}{d} ");
                                if (numFours == 4)
                                {
                                    a4 = a;
                                    b4 = b;
                                    c4 = c;
                                    d4 = d;
                                }
                            }
                            
                        }
                    }
                }
            }
            Console.WriteLine();
            if (numFours >= 3)
            {
                Console.WriteLine($"Password: {a4}{b4}{c4}{d4}");
            }
            else
                Console.WriteLine("No!");
        }
    }
}
