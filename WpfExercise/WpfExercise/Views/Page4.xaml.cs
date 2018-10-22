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
using WpfExercise.ViewModels;

namespace WpfExercise.Views
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        private WeatherViewModel weather;


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

        private async void BtnGetWeather_Click(object sender, RoutedEventArgs e)
        {
            weather = new WeatherViewModel();

            WResult.DataContext = await weather.GetWeatherAsync(TxtBoxZipCode.Text);

            //WResult.DataContext = weather.MyWeatherData;

        }
    }
}
