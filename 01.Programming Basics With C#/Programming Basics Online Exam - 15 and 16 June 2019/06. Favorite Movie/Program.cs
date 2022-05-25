using System;

namespace _06._Favorite_Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = null;
            int numMovies = 0;
            int maxPoints = int.MinValue;
            string pickMovie = null;
            while ((movieName = Console.ReadLine()) != "STOP")
            {

                numMovies++;
                if (numMovies >= 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
                int nameLenght = (int)movieName.Length;
                int points = 0;
                foreach (var letter in movieName)
                {
                    bool isUpper = char.IsUpper(letter);
                    int letterPoints = (int)letter;
                    if (isUpper && ((letterPoints >= 65 && letterPoints <= 132) || (letterPoints >= 141 && letterPoints <= 172)))
                        letterPoints -= nameLenght;
                    else if (isUpper == false && ((letterPoints >= 65 && letterPoints <= 132) || (letterPoints >= 141 && letterPoints <= 172)))
                        letterPoints -= 2 * nameLenght;
                    points += letterPoints;
                }
                if (points > maxPoints)
                {
                    maxPoints = points;
                    pickMovie = movieName;
                }
            }
            Console.WriteLine($"The best movie for you is {pickMovie} with {maxPoints} ASCII sum.");
        }
    }
}
