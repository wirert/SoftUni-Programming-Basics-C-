using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numGroups = int.Parse(Console.ReadLine());
            int membersMusala = 0;
            int membersMontblan = 0;
            int membersKilimanjaro = 0;
            int membersK2 = 0;
            int membersEverest = 0;
            int members = 0;
            for (int i = 1; i <= numGroups; i++)
            {
                int membersOfGroup = int.Parse(Console.ReadLine());
                members+=membersOfGroup;
                if (membersOfGroup <= 5)
                    membersMusala += membersOfGroup;
                else if (membersOfGroup <= 12)
                    membersMontblan += membersOfGroup;
                else if (membersOfGroup <= 25)
                    membersKilimanjaro += membersOfGroup;
                else if (membersOfGroup <= 40)
                    membersK2 += membersOfGroup;
                else
                    membersEverest += membersOfGroup;
            }
            Console.WriteLine($"{membersMusala * 100.0 / members:f2}%");
            Console.WriteLine($"{membersMontblan * 100.0 / members:f2}%");
            Console.WriteLine($"{membersKilimanjaro * 100.0 / members:f2}%");
            Console.WriteLine($"{membersK2 * 100.0 / members:f2}%");
            Console.WriteLine($"{membersEverest * 100.0 / members:f2}%");
        }
    }
}
