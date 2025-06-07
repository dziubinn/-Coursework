using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;

namespace Сoursework.Models
{
    public class MovieLibrary
    {
        private List<Movie> movies = new List<Movie>();

        public List<Movie> GetAllMovies() => movies;

        public void AddMovie(Movie movie)
        {
            if (movies.Any(m => m.Title == movie.Title && m.Year == movie.Year))
                throw new InvalidOperationException("Such a film already exists in the film library.");
            movies.Add(movie);
        }

        public void DeleteMovie(Movie movie) => movies.Remove(movie);

        public void UpdateMovie(Movie updatedMovie)
        {
            var index = movies.FindIndex(m => m.Id == updatedMovie.Id);
            if (index >= 0)
                movies[index] = updatedMovie;
        }

        public Movie FindMovie(string title)
        {
            return movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public void SaveToFile(string filePath)
        {
            try
            {
                var json = JsonSerializer.Serialize(movies, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Save error: {ex.Message}");
            }
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return;

            try
            {
                var json = File.ReadAllText(filePath);
                var loaded = JsonSerializer.Deserialize<List<Movie>>(json);
                if (loaded != null)
                    movies = loaded;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Load error: {ex.Message}");
            }
        }

    }
}
