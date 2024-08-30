namespace Forum.Models
{
    public class Posts
    {
        //tirei negative e positive reactions, replies, isEdited.
        public Posts(Guid id, string title, string topics, string description, User user) {

            Id = id;
            Title = title;
            Topics = topics;
            Description = description; 
            User = user;
         }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Topics { get; set; }
        public List<Comment> Comments { get; set; } = new(); //Cria nova lista de comentários vazia pra não dar null quando é formado o construtor.
        public int PositiveReactions { get; set; } = 0;
        public int NegativeReactions { get; set; } = 0;
        public int Replies { get; set; } = 0;
        public bool IsEdited { get; set; } = false;
        public User User { get; set; }
        public DateTime CreatedAt { get; init; } = DateTime.Now; //Sempre colocar datetime no objeto pra não precisar passar responsabilidade pro construtor (só vai ser feito 1 vez.)
                                                                 //init pra quando vamos fazer uma alteração apenas no construtor.
    }
}
