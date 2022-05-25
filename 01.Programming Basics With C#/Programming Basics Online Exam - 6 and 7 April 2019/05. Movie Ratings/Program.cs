using System;

namespace _05._Movie_Ratings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numFilms = int.Parse(Console.ReadLine());
            double bestRating = double.MinValue;
            double worstRating = double.MaxValue;
            string worstFilm = null;
            double sumRating = 0;
            string bestFilm = null;
            for (int i = 1; i <= numFilms; i++)
            {
                string film = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                sumRating += rating;
                if (rating > bestRating)
                {
                    bestRating = rating;
                    bestFilm = film;
                }
                if (rating < worstRating)
                {
                    worstRating = rating;
                    worstFilm = film;
                }
            }
            Console.WriteLine($"{bestFilm} is with highest rating: {bestRating:f1}");
            Console.WriteLine($"{worstFilm} is with lowest rating: {worstRating:f1}");
            Console.WriteLine($"Average rating: {sumRating / numFilms:f1}");
        }
    }
}
