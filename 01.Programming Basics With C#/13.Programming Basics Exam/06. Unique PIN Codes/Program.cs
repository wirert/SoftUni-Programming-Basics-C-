using System;

namespace _06._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int border1 = int.Parse(Console.ReadLine());
            int border2 = int.Parse(Console.ReadLine());
            int border3 = int.Parse(Console.ReadLine());
            for (int first = 1; first <= border1; first++)
            {
                if (first % 2 != 0)
                    continue;
                for (int second = 2; second <= border2; second++)
                {
                    if (second == 4 || second == 6 || second > 7)
                        continue;
                    for (int third = 1; third <= border3; third++)
                    {
                        if (third % 2 != 0)
                            continue;
                        Console.WriteLine($"{first} {second} {third}");
                    }
                }
            }
        }
    }
}
