using System;

namespace _08._Secret_Door_s_Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hundredsBorder = int.Parse(Console.ReadLine());
            int tenthsBorder = int.Parse(Console.ReadLine());
            int digitsBorder = int.Parse(Console.ReadLine());

            for (int hundreds = 2; hundreds <= hundredsBorder; hundreds++)
            {
                if (hundreds % 2 != 0)
                    continue;
                for (int tenths = 2; tenths <= tenthsBorder && tenths <= 7; tenths++)
                {
                    if (tenths == 4 || tenths == 6)
                        continue;
                    for (int digits = 2; digits <= digitsBorder; digits++)
                    {
                        if (digits % 2 != 0)
                            continue;
                        Console.WriteLine($"{hundreds} {tenths} {digits}");
                    }
                }
            }
        }
    }
}
