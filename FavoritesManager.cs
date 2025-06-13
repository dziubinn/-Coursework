using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Сoursework
{
    public static class FavoritesManager
    {
        private static string GetFilePath(string login)
        {
            return $"favorites_{login}.json";
        }
        public static List<string> LoadFavorites(string login)
        {
            string path = GetFilePath(login);
            if (!File.Exists(path))
                return new List<string>();

            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();
        }
        public static void SaveFavorites(string login, List<string> favorites)
        {
            string json = JsonSerializer.Serialize(favorites, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(GetFilePath(login), json);
        }
        public static void AddFavorite(string login, string movieTitle)
        {
            var favorites = LoadFavorites(login);
            if(!favorites.Contains(movieTitle))
            {
                favorites.Add(movieTitle);
                SaveFavorites(login, favorites);
            }
        }

        public static void RemoveFavorites(string login, string movieTitle)
        {
            var favorites = LoadFavorites(login);
            if (favorites.Remove(movieTitle))
                SaveFavorites(login, favorites);
        }
        public static bool IsFavorite(string login, string movieTitle)
        {
            var favorites = LoadFavorites(login);
            return favorites.Contains(movieTitle);
        }
    }
}
