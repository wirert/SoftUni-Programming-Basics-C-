﻿using System;

namespace _01._Rectangle_of_10_x_10_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new String('*', 10));
            }
        }
    }
}
