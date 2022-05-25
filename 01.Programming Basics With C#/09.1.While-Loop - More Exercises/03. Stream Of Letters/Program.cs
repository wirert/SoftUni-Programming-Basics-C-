using System;

namespace _03._Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letter = null;
            string word = null;
            string pass = null;
            while ((letter = Console.ReadLine()) != "End")
            {
                if (letter == "c" || letter == "o" || letter == "n")
                    pass += letter;

            }

        }
    }
}
