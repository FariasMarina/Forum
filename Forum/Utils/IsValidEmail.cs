using System.Net.Mail;

namespace Forum.Utils
{
    public static class IsValidEmails  //geralmente utils são classes estáticas 
    { 
        public static bool IsValidEmail(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

    }

}
