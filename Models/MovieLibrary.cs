using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Сoursework.Models
{
    class MovieLibrary
    {
        private List<Movie> movies = new List<Movie>();

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public void AddMovie(Movie movie)
        {
            if (movies.Any(m => m.Title == movie.Title && m.Year == movie.Year))
                throw new InvalidOperationException("Such a film already exists in the film library.");
            movies.Add(movie);
        }

        public bool RemoveMovie(string title)
        {
            var movie = movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            return movies.Remove(movie);

        }

        public Movie FindMovie(string title)
        {
            return movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }


        public bool EditMovie(string title, Movie updatedMovie)
        {
            var index = movies.FindIndex(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (index == -1) return false;
            movies[index] = updatedMovie;
            return true;
        }

        public void SaveToFile(string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(movies, options);
            File.WriteAllText(filePath, json);
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            string json = File.ReadAllText(filePath);
            movies = JsonSerializer.Deserialize<List<Movie>>(json) ?? new List<Movie>();
        }

    }
}
