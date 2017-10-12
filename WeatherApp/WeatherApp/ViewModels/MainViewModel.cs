using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.ViewModels
{
    public class MainViewModel
    {
          #region properties
        public List<CityModel> Cities { get; set; }
        #endregion
        #region constructor
        public MainViewModel()
        {
            Repository repo = new Repository();
            Cities = repo.GetCities();
        }
        #endregion
    }
}
