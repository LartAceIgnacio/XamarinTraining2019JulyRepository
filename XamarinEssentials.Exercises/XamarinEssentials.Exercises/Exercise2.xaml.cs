using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise2 : ContentPage
    {
        public Exercise2()
        {
            InitializeComponent();

            this.RedSlider.Value = 0;
            this.GreenSlider.Value = 0;
            this.BlueSlider.Value = 0;

            this.BoxViewColor.BackgroundColor = Color.FromRgb(this.RedSlider.Value,
                                                              this.GreenSlider.Value,
                                                              this.BlueSlider.Value);
        }

        private void ColorSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.BoxViewColor.BackgroundColor = Color.FromRgb(this.RedSlider.Value,
                                                              this.GreenSlider.Value,
                                                              this.BlueSlider.Value);

            this.RedLbl.Text = String.Format("Red: {0}", this.RedSlider.Value*255);
            this.GreenLbl.Text = String.Format("Green: {0}", this.GreenSlider.Value*255);
            this.BlueLbl.Text = String.Format("Blue: {0}", this.BlueSlider.Value*255);
        }
    }
}