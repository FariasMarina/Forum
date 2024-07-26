namespace Forum.Controllers
{
    public class PostsController
    {


        //Injeção de dependência _
        private readonly ILogger<PostsController> _logger;

        public PostsController(ILogger<PostsController> logger)
        {
            _logger = logger;
        }


    }


}
