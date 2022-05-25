using System;

namespace _01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullPoolVolume = int.Parse(Console.ReadLine());
            int firstPipeFlow = int.Parse(Console.ReadLine());
            int secondPipeFlow = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double pipe1Volume = hours * firstPipeFlow;
            double pipe2Volume = hours * secondPipeFlow;
            double currVolume = pipe1Volume + pipe2Volume;
            if (currVolume > fullPoolVolume)
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {currVolume - fullPoolVolume:f2} liters.");
            else
            {
                Console.WriteLine($"The pool is {currVolume * 100/ fullPoolVolume:f2}% full. Pipe 1: {pipe1Volume * 100/ currVolume:f2}%. Pipe 2: {pipe2Volume * 100 / currVolume:f2}%.");
            }
        }
    }
}
