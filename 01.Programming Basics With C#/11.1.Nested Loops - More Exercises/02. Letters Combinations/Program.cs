using System;

namespace _02._Letters_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char exeption = char.Parse(Console.ReadLine());
            int counter = 0;
            for (char firstL = start; firstL <= end; firstL++)
            {
                if (firstL == exeption)
                    continue;
                for (char secondL = start; secondL <= end; secondL++)
                {
                    if (secondL == exeption)
                        continue;
                    for (char thirdL = start; thirdL <= end; thirdL++)
                    {
                        if (thirdL == exeption)
                            continue;
                        counter++;
                        Console.Write($"{firstL}{secondL}{thirdL} ");
                    }
                }

            }
            Console.Write(counter);
        }
    }
}
