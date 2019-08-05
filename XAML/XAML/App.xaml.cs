using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAML
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new RGBExercise();
            //MainPage = new StackLayout1();
            //MainPage = new StackLayout2();
            //MainPage = new GridExercise1();
            //MainPage = new GridExercise2();
            //MainPage = new AbsoluteExercise();
            //MainPage = new RelativeExercise();
            //MainPage = new ImageExercise1();
            //MainPage = new ImageExercise2();
            MainPage = new ListExercise();
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
