﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            //MainPage = new MainPage();
            //MainPage = new Exercise2();
            //MainPage = new StackLayout1Page();
            //MainPage = new Grid1Page();
            //MainPage = new Grid2Page();
            //MainPage = new StackLayout2Page();
            //MainPage = new ApplicationProperties();
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
