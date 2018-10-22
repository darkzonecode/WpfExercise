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

namespace WpfExercise.Views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void BtnClearName_Click(object sender, RoutedEventArgs e)
        {
            TxtBoxUserName.Text = String.Empty;
            TxtBoxUserName.Focus();

            e.Handled = true;
        }

        private void BtnNextToSecondPage_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/Views/Page2.xaml", UriKind.Relative)); // just another way to navigate.
            NavigationService.Navigate(new Page2());

            e.Handled = true;

            // Save user name to the UserSettings
            Properties.Settings.Default.UserName = TxtBoxUserName.Text;
        }
    }
}
