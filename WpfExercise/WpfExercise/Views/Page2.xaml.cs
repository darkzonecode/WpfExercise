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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();

        }

        

        private void BtnBackToFirstPage_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void BtnNextPage_Click(object sender, RoutedEventArgs e)
        {           
            //NavigationService.Navigate(new Uri("/Views/ThirdPage.xaml", UriKind.Relative));
            NavigationService.Navigate(new Page3());

            //Properties.Settings.Default.RectFillColor = (System.Drawing.Color)CmbBoxColors.SelectedItem;
            //Properties.Settings.Default.RectBorderColor = (System.Drawing.Color)CmbStrokeColors.SelectedItem;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string uName = Properties.Settings.Default.UserName;

            TxtWelUser.Text = "Welcome " + uName;

            // Set combobox colors from app settings.
            //CmbBoxColors.SelectedItem = Properties.Settings.Default.RectFillColor;
            //CmbStrokeColors.SelectedItem = Properties.Settings.Default.RectBorderColor;
        }
    }
}
