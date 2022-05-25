using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double gradesSum = 0;

            int yearWithGoodGrade = 0;
            int yearWithBadGrade = 0;
            double grade = double.Parse(Console.ReadLine());
            while (true)
            {
                if (grade >= 4)
                {
                    yearWithGoodGrade++;
                    gradesSum += grade;
                }
                else
                {
                    yearWithBadGrade++;
                    if (yearWithBadGrade >= 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {yearWithGoodGrade + 1} grade");
                        break;
                    }
                }
                if (yearWithGoodGrade >= 12)
                    break;
                grade = double.Parse(Console.ReadLine());

            }
            if (yearWithBadGrade < 2)
                Console.WriteLine($"{name} graduated. Average grade: {gradesSum / yearWithGoodGrade:f2}");
        }
    }
}
