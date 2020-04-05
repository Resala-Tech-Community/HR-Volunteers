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
using System.Windows.Shapes;

namespace HR_Volunteers
{
    /// <summary>
    /// Interaction logic for frmKPI.xaml
    /// </summary>
    public partial class frmKPI : Window
    {
        public frmKPI()
        {
            InitializeComponent();
        }

        private void btnBranchName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void onActivityClick(object sender, RoutedEventArgs e)
        {

        }

        private void cBoxBranchName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cBoxBranchName.Items.Add("aybtngan");
        }
    }
}
