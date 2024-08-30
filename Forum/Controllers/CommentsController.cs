using Forum.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers
{
    [Route("[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private const int MaximumCharacter = 10000;
        private static List<Comment> CommentsList = [];
        public CommentsController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [HttpPost("publicar-comentario")] 
        public string CreateComment([FromBody] int postId, string commentBody)
        {

            Posts posts = post.Where(id == 1);
            posts.Comments.Add(new Comment(commentBody, posts.User, posts));
            CommentsList.Add(new Comment("", posts.User, posts));
            
            if (string.IsNullOrEmpty(comment.Body))
            {
                return "Escreva seu comentário.";
            }
            if (comment.Body.Length > MaximumCharacter)
            {
                return "Seu comentário atingiu mais de 10.000 linhas. O.o";
            }

            CommentsList.Add(comment);
            

            return string.Empty; 
        }
    }
}
