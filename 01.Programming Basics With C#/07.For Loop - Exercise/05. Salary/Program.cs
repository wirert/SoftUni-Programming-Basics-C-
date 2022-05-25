using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string currentTab = Console.ReadLine();
                if (currentTab == "Facebook")
                    salary -= 150;
                else if (currentTab == "Instagram")
                    salary -= 100;
                else if (currentTab == "Reddit")
                    salary -= 50;
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine(salary);
        }
    }
}
