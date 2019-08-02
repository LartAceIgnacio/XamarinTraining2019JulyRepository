using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinExercise
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

        private async void Ex1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise1());
        }

        private async void Ex2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise2());
        }

        private async void Ex3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void Ex4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InstagramPage());
        }

        private async void Ex5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DialerPage());
        }

        private async void Ex6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalculatorPage());
        }

        private async void Ex7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutPage());
        }

        private async void Ex8_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayoutPage());

        }
    }
}
