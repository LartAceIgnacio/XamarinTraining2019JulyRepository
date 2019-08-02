using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavPage : ContentPage
    {
        public NavPage()
        {
            InitializeComponent();
        }

        private async void GoToQuotesPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise1());
        }


        private async void GoToBoxColorPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise2());
        }

        private async void GoToLoginPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayout_Exercise1());
        }

        private async void GoToInstagram_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayout_Exercise2());
        }

        private async void GoToPhone_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid_Exercise1());
        }

        private async void GoToCalculator_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid_Exercise2());
        }

        private async void GoToAbsolute_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayout_Exercise());
        }

        private async void GoToRelative_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayout_Exercise());
        }
    }
}