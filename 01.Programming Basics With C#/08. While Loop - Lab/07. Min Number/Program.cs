using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNumText;
            int minNum = int.MaxValue;
            while ((inputNumText = Console.ReadLine()) != "Stop")
            {
                int inputNum = int.Parse(inputNumText);
                if (inputNum <= minNum)
                    minNum = inputNum;
            }
            Console.WriteLine(minNum);
        }
    }
}
