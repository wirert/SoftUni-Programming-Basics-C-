using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numDetergents = int.Parse(Console.ReadLine());
            int detergent = numDetergents * 750;
            int utensilDeterget = 0;            
            string command = null;
            int i = 0;
            int dishes = 0;
            int pots = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                i++;
                int numUtensils = int.Parse(command);
                if (i % 3 == 0)
                {
                    pots += numUtensils;
                    utensilDeterget += numUtensils * 15;
                }
                else
                {
                    dishes += numUtensils;
                    utensilDeterget += numUtensils * 5;
                }
                if (utensilDeterget > detergent)
                {
                    Console.WriteLine($"Not enough detergent, {utensilDeterget - detergent} ml. more necessary!");
                    break;
                }
            }
            if (utensilDeterget <= detergent) 
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent - utensilDeterget} ml.");
            }
        }
    }
}
