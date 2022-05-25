using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryNum = int.Parse(Console.ReadLine());
            string presentation = null;
            int numPresentations = 0;
            double sumAllGrades = 0;
            while ((presentation = Console.ReadLine()) != "Finish")
            {
                numPresentations++;
                double sumCurrGrades = 0;
                for (int numGrade = 1; numGrade <= juryNum; numGrade++)
                {
                    double currGrade = double.Parse(Console.ReadLine());
                    sumAllGrades += currGrade;
                    sumCurrGrades += currGrade;
                }
                Console.WriteLine($"{presentation} - {sumCurrGrades / juryNum:f2}.");
            }
            Console.WriteLine($"Student's final assessment is {sumAllGrades / (juryNum * numPresentations):f2}.");
        }
    }
}
