namespace Forum.Models
{
    public class Comment
    {
        public Comment(string body, User user, Posts post) {
            Body = body;
            User = user;
            Post = post;
        }
        public Guid Id { get; init; } = Guid.NewGuid();
        public string Body { get; set; }
        public User User { get; set; }
        public Posts Post { get; set; }

    }
}
