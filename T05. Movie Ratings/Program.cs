using System;

namespace T05._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int countFilms = int.Parse(Console.ReadLine());

            double maxRating = double.MinValue;
            double minRating = double.MaxValue;

            string bestFilm = "";
            string worstFilm = "";

            double sumRating = 0;

            for (int i = 0; i < countFilms; i++)
            {
                string film = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                if (rating > maxRating)
                {
                    bestFilm = film;
                    maxRating = rating;
                }
                else if (rating < minRating)
                {
                    worstFilm = film;
                    minRating = rating;
                }
                sumRating += rating;
            }
            double averageRate = (double)sumRating / countFilms;
            Console.WriteLine($"{bestFilm} is with highest rating: {maxRating:f1}\n{worstFilm} is with lowest rating: {minRating:f1}\nAverage rating: {averageRate:f1}");
        }
    }
}
