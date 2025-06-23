using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Сoursework
{
    /// <summary>
    /// Статичний клас для управління списком улюблених фільмів окремого користувача.
    /// Зберігає дані у форматі JSON у локальних файлах, прив’язаних до логіна.
    /// </summary>
    public static class FavoritesManager
    {
        /// <summary>Генерує шлях до файлу улюблених фільмів для вказаного логіна.</summary>
        private static string GetFilePath(string login)
        {
            return $"favorites_{login}.json";
        }

        /// <summary>Завантажує список улюблених фільмів для заданого користувача.</summary>
        public static List<string> LoadFavorites(string login)
        {
            string path = GetFilePath(login);
            if (!File.Exists(path))
                return new List<string>();

            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();
        }

        /// <summary>Зберігає список улюблених фільмів для заданого користувача у JSON-файл.</summary>
        public static void SaveFavorites(string login, List<string> favorites)
        {
            string json = JsonSerializer.Serialize(favorites, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(GetFilePath(login), json);
        }

        /// <summary>Додає фільм до списку улюблених користувача, якщо його ще не додано.</summary>
        public static void AddFavorite(string login, string movieTitle)
        {
            var favorites = LoadFavorites(login);
            if(!favorites.Contains(movieTitle))
            {
                favorites.Add(movieTitle);
                SaveFavorites(login, favorites);
            }
        }

        /// <summary>Видаляє фільм зі списку улюблених користувача, якщо він там є.</summary>
        public static void RemoveFavorites(string login, string movieTitle)
        {
            var favorites = LoadFavorites(login);
            if (favorites.Remove(movieTitle))
                SaveFavorites(login, favorites);
        }

        /// <summary>Перевіряє, чи фільм є в списку улюблених у конкретного користувача.</summary>
        public static bool IsFavorite(string login, string movieTitle)
        {
            var favorites = LoadFavorites(login);
            return favorites.Contains(movieTitle);
        }
    }
}
