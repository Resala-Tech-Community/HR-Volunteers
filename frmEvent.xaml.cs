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

namespace HR_Volunteers
{
    /// <summary>
    /// Interaction logic for frmEvent.xaml
    /// </summary>
    public partial class frmEvent : Page
    {
        public frmEvent()
        {
            InitializeComponent();
        }

        private void UserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cBoxBranchName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void scroll_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            const double stepSize = 62;
            var scrollViewer = (ScrollViewer)sender;
            var steps = Math.Round(scrollViewer.VerticalOffset / stepSize);
            var scrollPosition = steps * stepSize;
            e.Equals(10);
            if (scrollPosition >= scrollViewer.ScrollableHeight)
            {
                scrollViewer.ScrollToBottom();
                return;
            }
            scrollViewer.ScrollToVerticalOffset(scrollPosition);

        }

        private void scroll_MouseWheel(object sender, MouseWheelEventArgs e)
        {

        }

    }
}
