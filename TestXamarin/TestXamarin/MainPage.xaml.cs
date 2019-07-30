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


        /*
         * void Handle_ValueChanged(object sender, Xamarin.Forms)
         * {
         *      Label.Text = String.Formar("Volume " {0}", e.NewValue.ToString());
         * }
         * 
         * 
         */
    }
}
