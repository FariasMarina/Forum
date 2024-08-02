namespace Forum.Models
{
    public class User
    {
        public User(Guid id, string username, string address, string password, DateTime createdAt, List<Posts> posts)
        {
            Id = id;
            Username = username;
            Address = address;
            Password = password;
            CreatedAt = createdAt;
            Posts = posts; // lista de 'posts'
        }

        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } 
        public List<Posts> Posts { get; set; }
    }
}