using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numBadGrade = int.Parse (Console.ReadLine());
            string task;
            double gradeSum = 0;
            int badGrades = 0;
            string lastProblem = null;
            int gradesNum = 0;
            while ((task = Console.ReadLine()) != "Enough")
            {
                lastProblem = task;
                double grade = double.Parse(Console.ReadLine());
                gradesNum++;
                gradeSum += grade;
                if (grade <= 4) 
                {                     
                    badGrades++;
                    if (badGrades >= numBadGrade)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        break;
                    }
                }
            }
            if (badGrades < numBadGrade)
            {
                Console.WriteLine($"Average score: {gradeSum / gradesNum:f2}");
                Console.WriteLine($"Number of problems: {gradesNum}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }            
        }
    }
}
