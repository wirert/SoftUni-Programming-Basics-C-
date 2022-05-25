using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());
            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;
            string earlyOrLate = "";
            if (examTime >= arrivalTime && examTime - arrivalTime <= 30)
                earlyOrLate = "On time";
            else if (examTime - arrivalTime > 30)
                earlyOrLate = "Early";
            else
                earlyOrLate = "Late";
            Console.WriteLine(earlyOrLate);
            if (arrivalTime - examTime > 0 && arrivalTime - examTime < 60)
                Console.WriteLine($"{arrivalTime - examTime} minutes after the start");
            else if (arrivalTime - examTime >= 60 && (arrivalTime - examTime) % 60 >= 10)
                Console.WriteLine($"{(arrivalTime - examTime) / 60}:{(arrivalTime - examTime) % 60} hours after the start");
            else if (arrivalTime - examTime >= 60 && (arrivalTime - examTime) % 60 < 10)
            {
                Console.WriteLine($"{(arrivalTime - examTime) / 60}:0{(arrivalTime - examTime) % 60} hours after the start");
            }
            else if (examTime - arrivalTime > 0 && examTime - arrivalTime < 60)
                Console.WriteLine($"{examTime - arrivalTime} minutes before the start");
            else if (examTime - arrivalTime >= 60 && (examTime - arrivalTime) % 60 >= 10)
                Console.WriteLine($"{(examTime - arrivalTime) / 60}:{(examTime - arrivalTime) % 60} hours before the start");
            else if (examTime - arrivalTime >= 60 && (examTime - arrivalTime) % 60 < 10)
            {
                Console.WriteLine($"{(examTime - arrivalTime) / 60}:0{(examTime - arrivalTime) % 60} hours before the start");
            }
        }
    }
}
