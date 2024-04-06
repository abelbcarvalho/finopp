using System.Text.RegularExpressions;
using ExceptionUsername;

namespace UtilUsername
{
    public class UsernameUtil
    {
        public static void CheckUsername(string username)
        {
            string userRegex = @"^[a-z_]{1}[a-z0-9_\-\.]{1,30}[a-z0-9_\.]{1}$";

            if (!Regex.IsMatch(username, userRegex))
            {
                throw new UsernameException("error: this useranem doesn't matches the required format");
            }
        }
    }
}