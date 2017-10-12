using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp
{
    public class Repository
    {
        public List<CityModel> GetCities()
        {
            return new List<CityModel>() {
                new CityModel() { CityName = "New-York", Latitude = "40.7128", Longitude = "74.0060"},
                new CityModel() { CityName = "London", Latitude = "51.5074", Longitude = "0.1278"},
                new CityModel() { CityName = "Macau", Latitude = "22.1987", Longitude = "113.5439"},
                new CityModel() { CityName = "Krakow", Latitude = "50.0647", Longitude = "19.9450"},
                new CityModel() { CityName = "Tel-Aviv", Latitude = "32.0853", Longitude = "34.7818"},
                new CityModel() { CityName = "Bremen", Latitude = "53.0793", Longitude = "8.8017"},
                new CityModel() { CityName = "Asmara", Latitude = "15.3229", Longitude = "38.9251"},
            };
        }
    }
}
