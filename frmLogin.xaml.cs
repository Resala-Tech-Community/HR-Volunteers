using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using HR_Volunteers.Pages_Bind_Data;

namespace HR
{
    public partial class frmLogin : Window
    {
        LoginPage loginContext = new LoginPage();
        public frmLogin()
        {
            InitializeComponent();
            this.DataContext = loginContext;
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            /*if(sign.signIn(txtEmail,txtPass))
            {
                lblError.Content = "تم الدخول بنجاح";
            }
            else
            {
                lblError.Content = "يوجد مشكلة في تسجيل الدخول";
            }*/
        }

        private void txtPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            this.loginContext.Password = txtPass.Password;
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.loginContext.Username = txtEmail.Text;
        }
    }
}
