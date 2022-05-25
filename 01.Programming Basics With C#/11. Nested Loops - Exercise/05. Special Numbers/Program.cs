using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            for (int firstD = 1; firstD <= 9; firstD++)
            {
                for (int secontD = 1; secontD <= 9; secontD++)
                {
                    for (int third = 1; third <= 9; third++)
                    {
                        for (int fourth = 1; fourth <= 9; fourth++)
                        {
                            if (n % fourth == 0 && n % third == 0 && n% secontD == 0 && n % firstD == 0)
                                Console.Write($"{firstD}{secontD}{third}{fourth} ");
                        }
                    }
                }

            }
                      
        }
    }
}
