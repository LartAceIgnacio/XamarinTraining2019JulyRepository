using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinActivities
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new TabbedNavigation();
            MainPage = new E4ImageExercised1();
            //MainPage = new E4ImagePage();
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
