using HR_Volunteers.Data_Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Volunteers.Pages_Bind_Data
{
    class LoginPage : ViewModelBase
    {
        
        Dictionary<string, string> _errorInfo = new Dictionary<string, string>();

        public string usernameError { private set; get; }
        public string passwordError { private set; get; }
        private string username { get; set; }
        private string password { get; set; }
        public bool canLogin => (String.IsNullOrEmpty(usernameError) && String.IsNullOrEmpty(passwordError) ? true : false);
        public string Username
        {
            get { return username; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    usernameError = "يجب ادخال عنوان البريد الالكتروني";
                }
                else if (value.Length < 5 || value.Length > 30)
                {
                    usernameError = "عنوان البريد الالكتروني يجب ان يحتوي علي 5 حروف علي الاقل";
                }
                else
                {
                    usernameError = String.Empty;
                    username = value;
                }
            }
        }

        //[Required(ErrorMessage = "Password is Mandatory")]
        //[StringLength(20, MinimumLength = 8, ErrorMessage = "Must be at least 5 Characters")]
        public string Password
        {
            get { return password; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    passwordError = "يجب ادخال كلمة السر";
                }
                else if (value.Length < 5 || value.Length > 20)
                {
                    passwordError = "عنوان كلمة السر يجب ان تحتوي علي 5 حروف علي الاقل";
                }
                else
                {
                    passwordError = String.Empty;
                    password = value;
                }
            }
        }
        public LoginPage()
        {
            /*_errorInfo["Username"] = String.IsNullOrWhiteSpace(username) ? "Username is Mandatory" : "";
            _errorInfo["Password"] = String.IsNullOrWhiteSpace(password) ? "Password is Mandatory" : "";*/
            //canLogin = false;
            Username = "";
            Password = "";
            
        }

        public bool IsValidLogin()
        {
            if (String.IsNullOrEmpty(usernameError) && String.IsNullOrEmpty(passwordError))
                return false;
            return true;
        }

        public Color hasUserError()
        {
            return String.IsNullOrEmpty(usernameError)? Color.FromArgb(255, 0, 0) : Color.FromArgb(0, 0, 0);
        }

        public bool hasPassError()
        {
            return String.IsNullOrEmpty(passwordError);
        }
    }
}