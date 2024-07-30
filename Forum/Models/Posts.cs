namespace Forum.Models
{
    public class Posts
    {
        public Posts(Guid id, string title, string topics, string description, int comments, int positiveReactions, int negativeReactions, int replies, bool isEdited, User user,) {

            Id = id;
            Title = title;
            Topics = topics;
            Description = description;
            Comments = comments;    
            PositiveReactions = positiveReactions;
            NegativeReactions = negativeReactions;
            Replies = replies;
            IsEdited = isEdited;
            User = user;
         }


        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Topics { get; set; }
        public int Comments { get; set; }

        public int PositiveReactions { get; set; }

        public int NegativeReactions { get; set; }

        public int Replies { get; set; }

        public bool IsEdited { get; set; } = false;

        public User User { get; set; }

        public DateTime CreatedAt { get; set; }


    }
}
