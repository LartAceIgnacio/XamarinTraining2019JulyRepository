using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarin
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
            this.Box.BackgroundColor = Color.FromRgb(0, 0, 0);
            this.RGBValue.Text = String.Format("rgb({0},{1},{2})", 
                                                    (int)this.RedSlider.Value,
                                                    (int)this.GreenSlider.Value,
                                                    (int)this.BlueSlider.Value);
        }

        private void RedSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.Box.BackgroundColor = Color.FromRgb(
                (int)e.NewValue, 
                (int)this.GreenSlider.Value, 
                (int)this.BlueSlider.Value);
            this.RGBValue.Text = String.Format("rgb({0},{1},{2})",
                                                    (int)e.NewValue,
                                                    (int)this.GreenSlider.Value,
                                                    (int)this.BlueSlider.Value);
        }

        private void GreenSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.Box.BackgroundColor = Color.FromRgb(
                (int)this.RedSlider.Value, 
                (int)e.NewValue, 
                (int)this.BlueSlider.Value);
            this.RGBValue.Text = String.Format("rgb({0},{1},{2})",
                                                    (int)this.RedSlider.Value,
                                                    (int)e.NewValue,
                                                    (int)this.BlueSlider.Value);
        }

        private void BlueSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.Box.BackgroundColor = Color.FromRgb(
                (int)this.RedSlider.Value, 
                (int)this.GreenSlider.Value, 
                (int)e.NewValue);
            this.RGBValue.Text = String.Format("rgb({0},{1},{2})",
                                                    (int)this.RedSlider.Value,
                                                    (int)this.GreenSlider.Value,
                                                    (int)e.NewValue);
        }
    }
}