using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinActivities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RGBPage : ContentPage
    {
        public RGBPage()
        {
            InitializeComponent();

            var max = 255;
            var min = 0;

            //rgb_result = new BoxView { BackgroundColor = Color.FromRgb(red_slider.Value, green_slider.Value, blue_slider.Value) };
            //result.Color = Color.FromRgb(0, 0, 0);
            result.Color = Color.FromRgb(red_slider.Value, green_slider.Value, blue_slider.Value);

            red_slider.Maximum = max;
            blue_slider.Maximum = max;
            green_slider.Maximum = max;

            red_slider.Minimum = min;
            blue_slider.Minimum = min;
            green_slider.Minimum = min;

            red_slider.Value = 255;
            blue_slider.Value = 0;
            green_slider.Value = 35;

        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            result.Color = Color.FromRgb(red_slider.Value, green_slider.Value, blue_slider.Value);
        }
    }
}