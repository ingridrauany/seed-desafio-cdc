using System.Text.RegularExpressions;

namespace DesafioCDC.Validations
{
    public class EmailValidaton
    {
        public bool IsValidEmail(string email)
        {
            // Use a regular expression to validate email format
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
