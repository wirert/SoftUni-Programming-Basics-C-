﻿using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum < num)
            {
                int currNum = int.Parse(Console.ReadLine());
                sum += currNum;
            }
            Console.WriteLine(sum);
        }
    }
}
