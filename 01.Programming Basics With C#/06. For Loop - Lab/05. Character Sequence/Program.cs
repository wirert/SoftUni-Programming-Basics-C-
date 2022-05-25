using System;

namespace _05._Character_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = text.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
