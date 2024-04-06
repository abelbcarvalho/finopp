using System.Text.RegularExpressions;
using ExceptionEmail;

namespace UtilEmail
{
    public class EmailUtil
    {
        public static void CheckEmailAddress(string email)
        {
            string emailRegex = @"^[a-z]{1}[a-z0-9\-_.]+[a-z0-9]{1}@[a-z0-9]{1}[a-z0-9_\.]+[a-z0-9]{1}\.[a-z.]+[a-z]{1}$";

            if (!Regex.IsMatch(email, emailRegex))
            {
                throw new EmailException("error: this email address doesn't matches the required format");
            }
        }
    }
}