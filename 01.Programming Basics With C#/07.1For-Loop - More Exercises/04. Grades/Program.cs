using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double students2 = 0;
            double students3 = 0;
            double students4 = 0;
            double students5 = 0;
            double allGrades = 0;
            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                allGrades += grade;
                if (grade < 3)
                    students2++;
                else if (grade < 4)
                    students3++;
                else if (grade < 5)
                    students4++;
                else
                    students5++;
            }
            Console.WriteLine($"Top students: {students5 * 100 / students:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {students4 * 100 / students:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {students3 * 100 / students:f2}%");
            Console.WriteLine($"Fail: {students2 * 100 / students:f2}%");
            Console.WriteLine($"Average: {allGrades / students:f2}");
        }
    }
}
