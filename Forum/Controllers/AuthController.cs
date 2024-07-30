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
        private const int MinimunLengthPassword = 6;
        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        private (string ErrorMessage, bool IsOk) IsAccountAvailable( AuthRequest authRequest)
        {
            if (usernameExists)
            {
                return ("Este username ou e-email já está em uso.", false);
            }

            if (authRequest.Password.Length < MinimunLengthPassword)
            {
                return ("Sua senha deve ser de no mínimo 6 caracteres.", false);
            }

            if (!IsValidEmails.IsValidEmail(authRequest.Address))
            {
                return ("Utilize um e-mail válido. Exemplo: xxx@xxx.com", false);
            }
            return (String.Empty, true);
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

                if (user.Username.Equals(authRequest.Username) || user.Address.Equals(authRequest.Address))
                {
                    usernameExists = true;
                    break;
                }
            }

            var responseAccountVerification = IsAccountAvailable(authRequest);


            if (responseAccountVerification.IsOk) //Item 1 e 2 dos retornos do método. 
            {
                users.Add(new User(Guid.NewGuid(), authRequest.Username, authRequest.Address, authRequest.Password, DateTime.UtcNow));
                _logger.LogInformation("Usuário "+authRequest.Username+" foi criado.");
                return ("Usuário foi criado com sucesso.");
            } else
            {
                return responseAccountVerification.ErrorMessage;
            }


            return String.Empty;
        }

    }
}