namespace Users
{
    public class User
    {
        //Create four properties
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public DateTime DateCreated { get; private set; }

        // constructor that takes 4 arguments that correspond to the above properties
        public User(int id, string username, string password, DateTime dateCreated)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be positive");

            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username is required and cannot contain spaces");

            if (password.Length < 6 || !password.Any(char.IsLetter) || !password.Any(char.IsDigit) || !password.Any(char.IsPunctuation))
                throw new ArgumentException("Password must be at least 6 characters and contain a letter, a digit, and a punctuation symbol");

            if (dateCreated > DateTime.Now)
                throw new ArgumentException("DateCreated cannot be in the future");

            Id = id;
            Username = username;
            Password = password;
            DateCreated = dateCreated;
        }

        // Override the ToString method
        public override string ToString()
        {
            return $"{Id}|{Username}|{Password}|{DateCreated}";
        }
    }
}
