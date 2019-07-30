using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExcercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise2 : ContentPage
    {
        //BoxView box = new BoxView();
        double red =0 , green = 0, blue = 0;
        public Exercise2()
        {
            InitializeComponent();
            RedLabel.Text = String.Format("Red: {0}", red);
            GreenLabel.Text = String.Format("Green: {0}", green);
            BlueLabel.Text = String.Format("Blue: {0}", blue);
            changeColor();

        }

        void changeColor()
        {
            Box.Color = Color.FromRgb(red, green, blue);
        }
        private void RedChange(object sender, ValueChangedEventArgs e)
        {
            red = e.NewValue;
            changeColor();
            RedLabel.Text = String.Format("Red: {0:0}", (red*255));

        }
        private void GreenChange(object sender, ValueChangedEventArgs e)
        {
            green = e.NewValue;
            changeColor();
            GreenLabel.Text = String.Format("Green: {0:0}", (green * 255));

        }
        private void BlueChange(object sender, ValueChangedEventArgs e)
        {
            blue = e.NewValue;
            changeColor();
            BlueLabel.Text = String.Format("Blue: {0:0}", (blue * 255));


        }
    }
}