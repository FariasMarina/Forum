using Forum.Models;
using Forum.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Forum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private static List<User> users = new();
        private bool usernameExists = false;
        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        //Endpoint de cadastro de usuário-------------------
        [HttpPost("cadastro")] //Nome da rota (ex. auth/cadastro)
        public string Username([FromBody] AuthRequest authRequest) 
        {
            Console.WriteLine(authRequest.Username);
            _logger.LogInformation("Iniciando cadastro de usuário.");

            foreach (var user in users)
            {
                Console.WriteLine(user.Username);

                if (user.Username.Contains(authRequest.Username) || user.Address.Contains(authRequest.Address))
                {
                    usernameExists = true;
                    break;
                }
            }

            if (usernameExists)
            {
                return ("Este username ou e-email já está em uso.");
            }

            var minimunLengthPassword = 6;

            if (authRequest.Password.Length < minimunLengthPassword)
            {
                return ("Sua senha deve ser de no mínimo 6 caracteres.");
            }

            if (!IsValidEmails.IsValidEmail(authRequest.Address))
            {
                return ("Utilize um e-mail válido. Exemplo: xxx@xxx.com");
            }

            users.Add(new User(Guid.NewGuid(), authRequest.Username, authRequest.Address, authRequest.Password));
            return ("Usuário foi criado com sucesso.");
        }

    }
}