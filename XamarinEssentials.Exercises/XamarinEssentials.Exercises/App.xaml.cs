using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials.Exercises
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Exercise1();
            //MainPage = new Exercise2();
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
