using System;

namespace _01._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstBorder = int.Parse(Console.ReadLine());
            int secondBorder = int.Parse(Console.ReadLine());
            int thirdBorder = int.Parse(Console.ReadLine());
            for (int firstD = 2; firstD <= firstBorder; firstD++)
            {
                if (firstD % 2 == 0)
                {
                    for (int secondD = 2; secondD <= secondBorder && secondD <= 7 ; secondD++)
                    {
                        if (secondD == 4 || secondD == 6)
                            continue;
                        for (int thirdD = 2; thirdD <= thirdBorder; thirdD++)
                        {
                            if (thirdD % 2 == 0)
                                Console.WriteLine($"{firstD} {secondD} {thirdD}");
                        }
                    }
                }
            }

        }
    }
}
