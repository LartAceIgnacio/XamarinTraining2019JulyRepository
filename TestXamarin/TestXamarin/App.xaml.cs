using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var page = new MainPage();
            MainPage = new NavigationPage(page);
            NavigationPage.SetHasNavigationBar(page, false);
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
