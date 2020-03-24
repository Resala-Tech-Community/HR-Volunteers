using System.Windows.Controls;

namespace Resala
{
    public class SignIn
    {
        private string email, password;

        public bool signIn(TextBox email, PasswordBox pass)
        {
            if (email.Text == "" || pass.Password == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}