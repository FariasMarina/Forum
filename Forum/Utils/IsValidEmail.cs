using System.Net.Mail;

namespace Forum.Utils
{
    public static class IsValidEmails  //geralmente utils são classes estáticas 
    { 
        public static bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

    }

}
