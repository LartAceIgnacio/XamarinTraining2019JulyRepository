﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercise1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        //async void QuotePage_button_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new QuotePage());
        //}
        async void BoxViewPage_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise2());
        }

        async void StackLayoutPage_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayout1Page());
        }
        async void StackLayoutPage2_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayout2Page());
        }
        async void PhoneDialPage_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid1Page());
        }
        async void CalculatorPage_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid2Page());
        }
        async void AbsoluteLayoutPage_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutPage());
        }
        async void RelativeLayoutPage_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayoutPage());
        }
        async void ImahengBilogPage_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImahengBilog());
        }
        async void ImageGalleryPage_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageGalleryPage());
        }
        async void ImageGallerySwitchPage_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageGallerySwitchPage());
        }

        async void ContactListPage_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactListPage());
        }
    }
}
