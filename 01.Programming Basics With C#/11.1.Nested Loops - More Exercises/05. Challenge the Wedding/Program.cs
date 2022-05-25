using System;

namespace _05._Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int males = int.Parse(Console.ReadLine());
            int females = int.Parse(Console.ReadLine());
            int maxNumTables = int.Parse(Console.ReadLine());
            int numTables = 0;
            for (int maleN = 1; maleN <= males; maleN++)
            {
                for (int femaleN = 1; femaleN <= females; femaleN++)
                {
                    numTables++;
                    Console.Write($"({maleN} <-> {femaleN}) ");
                    if (numTables == maxNumTables)
                        return;
                }
            }
        }
    }
}
