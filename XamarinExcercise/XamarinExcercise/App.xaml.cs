using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExcercise
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new StackLayout1();
            //MainPage = new StackLayout2();
            //MainPage = new GridExercise1();
            //MainPage = new GridExercise2();
            //MainPage = new AbsoluteLayoutExercise();
            //MainPage = new RelativeLayoutExercise();
            MainPage = new ImageExercise();
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
