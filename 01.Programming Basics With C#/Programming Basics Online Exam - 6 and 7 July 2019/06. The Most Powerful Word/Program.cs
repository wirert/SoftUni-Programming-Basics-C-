using System;

namespace _06._The_Most_Powerful_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = null;
            string powerWord = null;
            double maxResult = double.MinValue;
            double result = 0;
            while ((words = Console.ReadLine()) != "End of words")
            {
                char firstLetter = (char)words[0];
                double length = words.Length;
                result = 0;
                foreach (var letter in words)
                {
                    int letterInt = (int)letter;
                    result += letterInt;
                }
                if (firstLetter == 'a' || firstLetter == 'e' || firstLetter == 'i' || firstLetter == 'o' || firstLetter == 'u' || firstLetter == 'y' || firstLetter == 'A' || firstLetter == 'E' || firstLetter == 'I' || firstLetter == 'O' || firstLetter == 'U' || firstLetter == 'Y')
                    result *= length;
                else
                    result = Math.Floor(result / length);
                if (result > maxResult)
                {
                    maxResult = result;
                    powerWord = words;
                }
            }
            Console.WriteLine($"The most powerful word is {powerWord} - {maxResult}");
        }
    }
}
