using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            redLabel.Text = String.Format("Red : {0:0}", RedSlider.Value * 255);
            greenLabel.Text = String.Format("Green : {0:0}", GreenSlider.Value * 255);
            blueLabel.Text = String.Format("Green : {0:0}", BlueSlider.Value * 255);
        }
        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            Box.Color = Color.FromRgb(RedSlider.Value, GreenSlider.Value, BlueSlider.Value);
            redLabel.Text = String.Format("Red : {0:0}", RedSlider.Value * 255);
            greenLabel.Text = String.Format("Green : {0:0}", GreenSlider.Value * 255);
            blueLabel.Text = String.Format("Green : {0:0}", BlueSlider.Value * 255);
        }
    }
}
