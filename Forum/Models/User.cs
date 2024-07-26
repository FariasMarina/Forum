namespace Forum.Models
{
    public class User
    {
        public User(Guid id, string username, string address, string password)
        {
            Id = id;
            Username = username;
            Address = address;
            Password = password;
        }

        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
    }
}