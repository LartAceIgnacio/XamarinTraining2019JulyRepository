using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise2 : ContentPage
    {

        public Exercise2()
        {
            InitializeComponent();
            boxView.Color = Color.FromRgb(0, 0, 0);
        }

        private void Color_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (sender == redslider)
            {
                getRed.Text = String.Format("Red : {0:0}", (int)e.NewValue);
            }
            if (sender == blueslider)
            {
                getBlue.Text = String.Format("Blue : {0:0}", (int)e.NewValue);
            }
            if (sender == greenslider)
            {
                getGreen.Text = String.Format("Green : {0:0}", (int)e.NewValue);
            }
            boxView.Color = Color.FromRgb((int)redslider.Value
                                        , (int)blueslider.Value
                                        , (int)greenslider.Value );
        }

    }
}