using System;
using System.Collections.Generic;

namespace DSA_Project
{
    public static class MovieService
    {
        private static readonly MovieDictionary movies = new MovieDictionary();   
        private static readonly MovieBST movieIndex = new MovieBST();             
        private static int nextMovieNumber = 5;

        public static Movie SelectedMovie { get; set; }

        static MovieService()
        {
            Seed("MOV001", "Interstellar", "Sci-Fi", 169, 8.7, 120m, "12:00, 15:30, 19:00",
                 "A team travels through a wormhole to find a new home for humanity.");
            Seed("MOV002", "Titanic", "Romance", 195, 7.9, 100m, "13:00, 17:00, 21:00",
                 "A love story aboard the ill-fated ocean liner.");
            Seed("MOV003", "Tatta7", "Comedy", 110, 6.5, 90m, "14:00, 18:00, 22:00",
                 "An Egyptian comedy.");
            Seed("MOV004", "Dune: Part Two", "Sci-Fi", 166, 8.5, 150m, "11:00, 16:00, 20:30",
                 "Paul Atreides joins the Fremen to avenge his family.");
        }

        private static void Seed(string id, string title, string genre, int duration, double rating,
                                 decimal price, string showtimes, string description)
        {
            Register(new Movie
            {
                Id = id,
                Title = title,
                Genre = genre,
                Duration = duration,
                Rating = rating,
                TicketPrice = price,
                Showtimes = showtimes,
                Description = description
            });
        }

        private static void Register(Movie movie)
        {
            movies.Add(movie);
            movieIndex.Insert(movie);
            SeatService.AddMovie(movie);
        }

        public static void Add(Movie movie)
        {
            if (movie == null)
                throw new ArgumentNullException("movie");
            if (String.IsNullOrWhiteSpace(movie.Title))
                throw new ArgumentException("Movie title is required.", "movie");

            movie.Title = movie.Title.Trim();
            if (movieIndex.Search(movie.Title) != null)
                throw new InvalidOperationException("A movie titled \"" + movie.Title + "\" already exists.");

            movie.Id = "MOV" + nextMovieNumber.ToString("000");
            nextMovieNumber++;
            Register(movie);
        }

        public static bool Remove(string id)
        {
            Movie movie;
            if (!movies.TryGet(id, out movie))
                return false;

            movieIndex.Delete(movie.Title);
            movies.Remove(id);
            if (SelectedMovie == movie)
                SelectedMovie = null;
            return true;
        }

        public static List<Movie> Search(string query)
        {
            List<Movie> all = movieIndex.GetInOrder();
            if (String.IsNullOrWhiteSpace(query))
                return all;

            string text = query.Trim();
            return all.FindAll(m => Contains(m.Title, text) || Contains(m.Genre, text));
        }

        private static bool Contains(string source, string text)
        {
            return source != null && source.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public static Movie FindByTitle(string title)
        {
            return title == null ? null : movieIndex.Search(title.Trim());
        }

        public static List<Movie> GetAllMovies()
        {
            return movieIndex.GetInOrder();
        }
    }
}
