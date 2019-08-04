using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Colors();
            //MainPage = new QuotesPage();
            //MainPage = new StackLayout1Page();
            //MainPage = new StackLayout2Page();
            //MainPage = new GridExercise1Page();
            //MainPage = new GridExercise2Page();
            //MainPage = new AbsoluteLayoutPage();
            //MainPage = new RelativeLayoutPage();
            MainPage = new Image1Page();
            //MainPage = new Image2Page();
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
