using Forum.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers
{
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        // (injeção de dependência)
        private readonly ILogger<PostsController> _logger;
        private static List<Posts> allPosts = new();

        public PostsController(ILogger<PostsController> logger)

        {
            _logger = logger;
        }

        //ENDPOINT DE CRIAÇÃO DE POSTS 
        
        [HttpPost("publicar")]
        public string CreateArticle([FromBody] Posts post)
        {
            //if (string.IsNullOrEmpty(post.Title))
            //{
            //    return "Ué, seu post necessita de um título.";
            //}
            //if (string.IsNullOrEmpty(post.Description))
            //{
            //    return "Ora bolas, você não fez uma descrição pro seu post.";
            //}

            Posts posts = new(new Guid(), "", "", "", new User(new Guid(), "", "", "", DateTime.Now));
            
            // allPosts.Add(new Posts(Guid.NewGuid(), post.Title, post.Topics, post.Description, post.PositiveReactions, post.NegativeReactions, post.Replies, post.IsEdited, post.User));
            _logger.LogInformation("Post criado.");
            return "Artigo criado com sucesso.";
        }
    }
}
