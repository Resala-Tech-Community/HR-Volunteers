using System;
using System.Collections.Generic;
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
using Resala;

namespace ResalaDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        SignIn sign = new SignIn();
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(sign.signIn(txtEmail,txtPass))
            {
                lblError.Content = "تم الدخول بنجاح";
            }
            else
            {
                lblError.Content = "يوجد مشكلة في تسجيل الدخول";
            }
        }
    }
}
