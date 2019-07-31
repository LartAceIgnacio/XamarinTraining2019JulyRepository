using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise2 : ContentPage
    {
        public Exercise2()
        {
            InitializeComponent();
            boxView.Color = Color.FromRgb(25, 25, 25);
        }
        void Color_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (sender == red)
            {
                redLabel.Text = String.Format("Red: {0:F0}", (int)e.NewValue);
            }
            if (sender == green)
            {
                greenLabel.Text = String.Format("Green: {0:F0}", (int)e.NewValue);
            }
            if (sender == blue)
            {
                greenLabel.Text = String.Format("Blue: {0:F0}", (int)e.NewValue);
            }
            boxView.Color = Color.FromRgb((int)red.Value,
                                          (int)green.Value,
                                          (int)blue.Value);
        }
    }
}