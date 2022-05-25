using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int period = int.Parse(Console.ReadLine());
            int doctors = 7;            
            int examinedPatients = 0;
            int unexamPatients = 0;
            for (int i = 1; i <= period; i++)
            {
                int dayPatients = int.Parse(Console.ReadLine());               
                if (i % 3 == 0 && unexamPatients > examinedPatients)
                    doctors++;
                if (dayPatients >= doctors)
                {
                    examinedPatients += doctors;
                    unexamPatients += dayPatients - doctors;
                }
                else                
                    examinedPatients += dayPatients;
            }
            Console.WriteLine($"Treated patients: {examinedPatients}.");
            Console.WriteLine($"Untreated patients: {unexamPatients}.");
        }
    }
}
