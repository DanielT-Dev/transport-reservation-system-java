namespace model
{
    public class User
    {
        public int? Id { get; set; }           // nullable int like Java Integer
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Constructor with Id
        public User(int? id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        // Constructor without Id
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Email} {Password}";
        }
    }
}