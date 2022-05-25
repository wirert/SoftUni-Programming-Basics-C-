using System;

namespace _05._PC_Game_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numGames = int.Parse(Console.ReadLine());
            string currGame = null;
            int numHearthstone = 0;
            int numFornite = 0;
            int numOverwatch = 0;
            int numOthers = 0;
            for (int i = 1; i <= numGames; i++)
            {
                currGame = Console.ReadLine();
                if (currGame == "Hearthstone")
                    numHearthstone++;
                else if (currGame == "Fornite")
                    numFornite++;
                else if (currGame == "Overwatch")
                    numOverwatch++;
                else
                    numOthers++;
            }
            Console.WriteLine($"Hearthstone - {numHearthstone * 100.0 / numGames:f2}%");
            Console.WriteLine($"Fornite - {numFornite * 100.0 / numGames:f2}%");
            Console.WriteLine($"Overwatch - {numOverwatch * 100.0 / numGames:f2}%");
            Console.WriteLine($"Others - {numOthers * 100.0 / numGames:f2}%");
        }
    }
}
