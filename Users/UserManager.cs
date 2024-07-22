using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class UserManager
    {
        private List<User> users = new List<User>();
        private string filename = "users.txt";

        public UserManager()
        {
            try
            {
                if (!File.Exists(filename))
                {
                    File.Create(filename).Dispose(); // Ensure the file is created if it does not already exist
                }
                LoadUsers();
            }
            catch (Exception ex)
            {
                // Pass on any exceptions to the calling code
                throw new Exception("An error occurred while initializing the UserManager.", ex);
            }
        }

        private void LoadUsers()
        {
            if (File.Exists(filename))
            {
                var lines = File.ReadAllLines(filename);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 4) // Ensure there are exactly 4 parts
                    {
                        var id = int.Parse(parts[0]);
                        var username = parts[1];
                        var password = parts[2];
                        var dateCreated = DateTime.Parse(parts[3]);
                        users.Add(new User(id, username, password, dateCreated));
                    }
                }
            }
        }

        public int GetNewId()
        {
            try
            {
                return users.Any() ? users.Max(u => u.Id) + 1 : 1;
            }
            catch (Exception ex)
            {
                // Pass on any exceptions to the calling code
                throw new Exception("An error occurred while generating a new ID.", ex);
            }
        }

        public void AddNewUser(User user)
        {
            if (users.Any(u => u.Username == user.Username))
                throw new ArgumentException("Username already exists");

            users.Add(user);
            SaveUsers();
        }

        private void SaveUsers()
        {
            var lines = users.Select(u => u.ToString()).ToArray();
            File.WriteAllLines(filename, lines);
        }
    }
}
