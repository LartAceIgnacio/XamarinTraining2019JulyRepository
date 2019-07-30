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
    public partial class BoxColorPage : ContentPage
    {
        public BoxColorPage()
        {
            InitializeComponent();

            Box.Color = Color.FromRgb(0, 0, 0);

        }

        private void RGB_Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Box.Color = Color.FromRgb(Red_Slider.Value, 
                                       Green_Slider.Value, 
                                       Blue_Slider.Value);
        }
    }
}