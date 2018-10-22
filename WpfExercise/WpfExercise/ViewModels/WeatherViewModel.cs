using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfExercise.Models;
using WpfExercise.Common;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfExercise.ViewModels
{
    public class WeatherViewModel : INotifyPropertyChanged
    {
        private HttpClient client;


        private WeatherByZip _weatherByZip;
        public WeatherByZip MyWeatherData
        {
            get { return _weatherByZip; }
            set
            {
                _weatherByZip = value;
                NotifyPropertyChanged();
            }
        }


        public RelayCommand<string> GetWeatherCommand => new RelayCommand<string>(GetWeatherAsync);



        public async void GetWeatherAsync(string zipCode)
        {
            // api.openweathermap.org/data/2.5/weather?zip=94040,us
            // id = b28510cc4a82d2ee9fc2145a21c7742d
            try
            {
                client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("http://api.openweathermap.org/data/2.5/weather?zip=" + zipCode + ",us&units=imperial&appid=b28510cc4a82d2ee9fc2145a21c7742d");

                if (response.IsSuccessStatusCode)
                {
                    var r = await response.Content.ReadAsStringAsync();

                    var w = JsonConvert.DeserializeObject<WeatherByZip>(r);

                    MyWeatherData = w;

                    //return w;
                }
                else
                {
                    MessageBox.Show("Error getting data please check zip code or try again later.", "Some error", MessageBoxButton.OK, MessageBoxImage.Warning);

                }

            }

            // It just simple catch all exception, for detail catch exception from most specific to most general.
            catch (Exception)
            {
                MessageBox.Show("Error getting data please check network connection or try again later.", "Ooops error", MessageBoxButton.OK, MessageBoxImage.Error);


            }

            //return null;
        }


        public event PropertyChangedEventHandler PropertyChanged;


        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
