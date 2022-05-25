using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNumText;
            int maxNum = int.MinValue;
            while ((inputNumText = Console.ReadLine()) != "Stop")
            {
                int inputNum = int.Parse(inputNumText);
                if (inputNum >= maxNum)
                    maxNum = inputNum;
            }
            Console.WriteLine(maxNum);
        }
    }
}
