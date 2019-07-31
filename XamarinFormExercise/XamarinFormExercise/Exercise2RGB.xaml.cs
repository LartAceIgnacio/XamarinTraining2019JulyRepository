using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise2RGB : ContentPage
    {
        public Exercise2RGB()
        {
            InitializeComponent(); 
        }
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            result.Color = Color.FromRgb(red.Value / 255, green.Value / 255, blue.Value / 255);
        }
    }
}