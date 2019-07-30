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
        void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double fontsize = e.NewValue;
            label.Text = String.Format("The Slider value is {0}", fontsize);
            quote.FontSize = fontsize;
        }
        //public MainPage()
        //{
        //    InitializeComponent();
        //    slider.Value = 0.5;
        //    if (Device.RuntimePlatform == Device.iOS)
        //    {
        //        Padding = new Thickness(0, 20, 0, 0);
        //    }
        //}
        //void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        //{
        //    label.Text = string.Format("Value is {0:F2}, e.NewValue");
        //}
    }
}
