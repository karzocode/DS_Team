using System.Collections.Generic;

namespace DSA_Project
{
    public class MovieDictionary
    {
        private readonly Dictionary<string, Movie> items = new Dictionary<string, Movie>();

        public IEnumerable<Movie> Values
        {
            get { return items.Values; }
        }

        public void Add(Movie movie)
        {
            items[movie.Id] = movie;
        }

        public bool ContainsId(string id)
        {
            return id != null && items.ContainsKey(id);
        }

        public bool TryGet(string id, out Movie movie)
        {
            movie = null;
            return id != null && items.TryGetValue(id, out movie);
        }

        public Movie Find(string id)
        {
            Movie movie;
            return TryGet(id, out movie) ? movie : null;
        }

        public bool Remove(string id)
        {
            return id != null && items.Remove(id);
        }
    }
}
