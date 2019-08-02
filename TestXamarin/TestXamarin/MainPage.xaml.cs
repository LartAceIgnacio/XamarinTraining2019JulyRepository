using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            /*
             * For XAML with ContentPage.Content tag
             * 
             * this.Content = new Label() {
             *      Text = "Sample Label",
             *      HorizontalOptions = LayoutOptions.Center,
             *      VerticalOptions = LayoutOptions.Center
             * }
             */
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
        private async void GoToExercise1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuotesPage());
        }

        private async void GoToExercise2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise2());
        }

        private async void GoToExercise3A_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayout1());
        }

        private async void GoToExercise3B_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayout2());
        }

        private async void GoToExercise4A_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridLayout1());
        }

        private async void GoToExercise4B_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridLayout2());
        }

        private async void GoToExercise5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayout());
        }

        private async void GoToExercise6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayout());
        }

        private async void GoToRoundedImg_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RoundImageDemo());
        }

        private async void GoToImageLoadingGrid_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageLoadingGrid());
        }
    }
}
