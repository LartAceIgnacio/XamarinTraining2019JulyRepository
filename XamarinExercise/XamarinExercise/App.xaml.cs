using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExercise
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new Exercise1();
            //MainPage = new Exercise2();
            //MainPage = new LoginPage();
            //MainPage = new CalculatorPage();
            //MainPage = new DialerPage();
            MainPage = new NavigationPage(new MainPage());
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
