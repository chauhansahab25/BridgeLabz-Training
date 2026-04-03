using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.CinemaTimeManager
{
    public class CinemaManagerImpl : ICinemaManager
    {
        private Movie[] movies;
        private int movieCount;
        private int maxMovies;

        public CinemaManagerImpl(int capacity)
        {
            maxMovies = capacity;
            movies = new Movie[maxMovies];
            movieCount = 0;
        }

        public void AddMovie(string title, string time)
        {
            if (!TimeUtility.ValidateTimeFormat(time))
            {
                Console.WriteLine("Error: Invalid time format. Use HH:MM AM/PM format");
                return;
            }

            if (movieCount < maxMovies)
            {
                movies[movieCount] = new Movie(title, time);
                movieCount++;
                Console.WriteLine("Movie added: " + title + " at " + time);
            }
            else
            {
                Console.WriteLine("Cinema is full! Cannot add more movies.");
            }
        }

        public void SearchMovie(string keyword)
        {
            bool found = false;
            Console.WriteLine("Search results for: " + keyword);

            for (int i = 0; i < movieCount; i++)
            {
                if (movies[i].Title.ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine(TimeUtility.FormatMovieInfo(movies[i], i));
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No movies found with keyword: " + keyword);
            }
        }

        public void DisplayAllMovies()
        {
            Console.WriteLine("# All Movies #");

            if (movieCount == 0)
            {
                Console.WriteLine("No movies scheduled");
                return;
            }

            for (int i = 0; i < movieCount; i++)
            {
                Console.WriteLine(TimeUtility.FormatMovieInfo(movies[i], i));
            }
        }

        public void GenerateReport()
        {
            Console.WriteLine("# Cinema Report #");
            Console.WriteLine("Total movies: " + movieCount);

            // convert to array for report
            Movie[] reportMovies = new Movie[movieCount];

            for (int i = 0; i < movieCount; i++)
            {
                reportMovies[i] = movies[i];
            }

            Console.WriteLine("Movies in report:");
            for (int i = 0; i < reportMovies.Length; i++)
            {
                Console.WriteLine("- " + reportMovies[i].ToString());
            }
        }
    }
}
