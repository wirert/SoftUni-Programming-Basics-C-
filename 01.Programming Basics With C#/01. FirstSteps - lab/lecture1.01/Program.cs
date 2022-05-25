using System;

namespace lecture1._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            int proekti = int.Parse(Console.ReadLine());
            int chasove = proekti * 3;
            Console.WriteLine($"The architect {architect} will need {chasove} hours to complete {proekti} project/s.");
        }
    }
}
