using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Сoursework
{
    /// <summary>
    /// Статичний клас для управління користувачами:
    /// зберігання, завантаження, пошук, перевірка унікальності логіну.
    /// </summary>
    public static class UserManager
    {
        private static readonly string FilePath = "users.json";

        /// <summary>
        /// Завантажує список користувачів із JSON-файлу.
        /// Якщо файл не існує — повертає порожній список.
        /// </summary>
        public static List<User> LoadUsers()
        {
            if (!File.Exists(FilePath))
                return new List<User>();

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        /// <summary>Зберігає список користувачів у JSON-файл.</summary>
        public static void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        /// <summary>Додає нового користувача до системи та зберігає оновлений список.</summary>
        public static void AddUser(User newUser)
        {
            var users = LoadUsers();
            users.Add(newUser);
            SaveUsers(users);
        }

        /// <summary>Перевіряє, чи існує користувач із вказаним логіном.</summary>
        public static bool UserExists(string login)
        {
            var users = LoadUsers();
            return users.Any(u => u.Login == login);
        }

        /// <summary>Повертає користувача за заданими логіном і паролем, якщо знайдено.</summary>
        public static User? FindUser(string login, string password)
        {
            var users = LoadUsers();
            return users.FirstOrDefault(u => u.Login == login && u.Password == password);
        }

        /// <summary>Перевіряє, чи зайнятий логін у системі.</summary>
        public static bool IsLoginTaken(string login)
        {
            var users = LoadUsers();
            return users.Any(u => u.Login == login);
        }
    }
}