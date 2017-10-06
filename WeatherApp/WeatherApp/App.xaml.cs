using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WeatherApp
{
    class Base
    {
        public void Method1() { }
        public void Method2() { }
    }

    class Derived : Base
    {
        public void Method3() { }

    }
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WeatherApp.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
