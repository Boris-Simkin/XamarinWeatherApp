using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.ViewModels;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            CityModel choosenCity = (CityModel)e.Item;
            var weatherPage = new WeatherPage();
            weatherPage.BindingContext = new WeatherPageViewModel(choosenCity);
            Navigation.PushAsync(weatherPage);

            
        }
    }
}
