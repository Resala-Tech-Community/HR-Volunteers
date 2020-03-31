using HR_Volunteers.Data_Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Volunteers.Pages_Bind_Data
{
    class Login : ViewModelBase
    {
        
        Dictionary<string, string> _errorInfo = new Dictionary<string, string>();

        private string username { get; set; }

        private string password { get; set; }

        public string canLogin => (this._errorInfo.Count == 0? "True" : "False");
        public string Username
        {
            get { return username; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    _errorInfo["Username"] = "UserName is mandatory";
                }
                else if (value.Length < 5 || value.Length > 30)
                {
                    _errorInfo["Username"] = "Must be at least 5 Characters";
                }
                else
                {
                    _errorInfo.Remove("Username");
                    username = value;
                }
            }
        }

        [Required(ErrorMessage = "Password is Mandatory")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Must be at least 5 Characters")]
        public string Password
        {
            get { return password; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    _errorInfo["Password"] = "Password is mandatory";
                }
                else if (value.Length < 5 || value.Length > 20)
                {
                    _errorInfo["Password"] = "Must be at least 5 Characters";
                }
                else
                {
                    _errorInfo.Remove("Password");
                    password = value;
                }
            }
        }
        public Login()
        {
            _errorInfo["Username"] = String.IsNullOrWhiteSpace(username) ? "Username is Mandatory" : "";
            _errorInfo["Password"] = String.IsNullOrWhiteSpace(password) ? "Password is Mandatory" : "";
        }
    }
}