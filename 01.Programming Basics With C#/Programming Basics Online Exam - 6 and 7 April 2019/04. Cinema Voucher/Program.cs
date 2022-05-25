using System;

namespace _04._Cinema_Voucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vaucher = int.Parse(Console.ReadLine());
            string purchise = Console.ReadLine();
            int numTickets = 0;
            int numOther = 0;            
            while (purchise != "End")
            {
                int purchiseLenght = purchise.Length;
                int letter1 = (int)purchise[0];
                int letter2 = (int)purchise[1];
                
                if (purchiseLenght > 8)
                {
                    if (vaucher < letter1 + letter2)
                        break;
                    vaucher -= letter1 + letter2;                    
                    numTickets++;
                }
                else
                {
                    if (vaucher < letter1)
                        break;
                    numOther++;
                    vaucher -= letter1;
                }
                purchise = Console.ReadLine();
            }
            Console.WriteLine(numTickets);
            Console.WriteLine(numOther);
        }
    }
}
