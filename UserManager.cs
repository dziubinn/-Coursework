using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Сoursework
{
    public static class UserManager
    {
        private static readonly string FilePath = "users.json";

        public static List<User> LoadUsers()
        {
            if (!File.Exists(FilePath))
                return new List<User>();

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        public static void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public static void AddUser(User newUser)
        {
            var users = LoadUsers();
            users.Add(newUser);
            SaveUsers(users);
        }

        public static bool UserExists(string login)
        {
            var users = LoadUsers();
            return users.Any(u => u.Login == login);
        }

        public static User? FindUser(string login, string password)
        {
            var users = LoadUsers();
            return users.FirstOrDefault(u => u.Login == login && u.Password == password);
        }
        public static bool IsLoginTaken(string login)
        {
            var users = LoadUsers();
            return users.Any(u => u.Login == login);
        }
    }
}
