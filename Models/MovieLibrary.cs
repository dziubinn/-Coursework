using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;

namespace Сoursework.Models
{
    /// <summary>
    /// Клас для керування колекцією фільмів.
    /// Забезпечує додавання, оновлення, видалення, пошук фільмів, а також збереження і завантаження колекції у/з JSON-файлу.
    /// </summary>
    public class MovieLibrary
    {
        private List<Movie> movies = new List<Movie>();

        /// <summary>Повертає всі фільми в бібліотеці.</summary>
        public List<Movie> GetAllMovies() => movies;

        /// <summary>Додає новий фільм до бібліотеки. Якщо фільм із таким самим заголовком і роком вже існує, кидає виняток.</summary>
        public void AddMovie(Movie movie)
        {
            if (movies.Any(m => m.Title == movie.Title && m.Year == movie.Year))
                throw new InvalidOperationException("Such a film already exists in the film library.");
            movies.Add(movie);
        }

        /// <summary>Видаляє фільм із бібліотеки.</summary>
        public void DeleteMovie(Movie movie) => movies.Remove(movie);

        /// <summary>Оновлює інформацію про існуючий фільм за ідентифікатором.</summary>
        public void UpdateMovie(Movie updatedMovie)
        {
            var index = movies.FindIndex(m => m.Id == updatedMovie.Id);
            if (index >= 0)
                movies[index] = updatedMovie;
        }

        /// <summary>Знаходить фільм за точною назвою (без врахування регістру).</summary>
        public Movie FindMovie(string title)
        {
            return movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>Зберігає поточну колекцію фільмів у JSON-файл.</summary>
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

        /// <summary>Завантажує колекцію фільмів із JSON-файлу.</summary>
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
