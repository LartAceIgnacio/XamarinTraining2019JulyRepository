using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormExercise
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new Exercise1QuotesPage();
            // MainPage = new Exercise2RGB();
            //  MainPage = new Exercise3StackLayout1();
            // MainPage = new Exercise4StackLayout2();
            //MainPage = new Exercise5GridLayout1();
            MainPage = new Exercise6GridLayout2();
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
