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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }


        private void BtnGoHome_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());

            e.Handled = true;

            while (NavigationService.CanGoBack)
            {
                NavigationService.RemoveBackEntry();

            }
        }

        private void BtnBackToThirdPage_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

    }
}
