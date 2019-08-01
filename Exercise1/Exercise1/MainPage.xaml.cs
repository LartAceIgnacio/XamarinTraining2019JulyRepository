using System;
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
        async void QuotePage_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuotePage());
        }

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
    }
}
