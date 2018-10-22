using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfExercise.Models;

namespace WpfExercise.ViewModels
{
    public class WeatherViewModel
    {
        private HttpClient client;

        //public WeatherByZip MyWeatherData { get; set; }



        public async Task<WeatherByZip> GetWeatherAsync(string zipCode)
        {
            // api.openweathermap.org/data/2.5/weather?zip=94040,us
            // id = b28510cc4a82d2ee9fc2145a21c7742d
            try
            {
                client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("http://api.openweathermap.org/data/2.5/weather?zip=" + zipCode + ",us&appid=b28510cc4a82d2ee9fc2145a21c7742d");

                if (response.IsSuccessStatusCode)
                {
                    var r = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<WeatherByZip>(r);


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

            return null;
        }

    }









}
