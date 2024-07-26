namespace Forum.Models
{
    public class AuthRequest
    {
        public AuthRequest(string username, string address, string password)
        {
            Username = username;
            Address = address;
            Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
