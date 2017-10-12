using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.ViewModels
{
    public class WeatherPageViewModel : INotifyPropertyChanged
    {
        public WeatherPageViewModel(CityModel city)
        {
            this.latitude = city.Latitude;
            this.longitude = city.Longitude;

            GetWeatherData();
        }

        const string DarkSkyUri = "https://api.darksky.net/forecast/063818ef6882a3514f2af44441fefbd7/";

        private string latitude;
        private string longitude;

        private string temperature;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Temperature"));
            }
        }

        public async void GetWeatherData()
        {

            string responseBody = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                responseBody = await client.GetStringAsync($"{DarkSkyUri}{latitude},{longitude}?units=si");
            }

            DarkSkyModel model = JsonConvert.
                DeserializeObject<JObject>(responseBody).
                ToObject<DarkSkyModel>();

            Temperature = model.currently.temperature.ToString();

        }
    }
}
