﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinActivities
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new TabsPage();
            MainPage = new WelcomePage();
            MainPage = new AbsolutePage();
            // MainPage = new InstagramPage();
            // MainPage = new DialPage();
            // MainPage = new CalculatorPage();
            // MainPage = new QuotesPage();
            // MainPage = new BoxColorPage();

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
