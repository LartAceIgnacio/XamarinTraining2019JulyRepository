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
        string[] quotes = { "I'll be there for you",
                            "When the rain starts to fall",
                            "Like I've been there Before",
                            "Cause your there for me too" };
        int index = 0;

        public MainPage()
        {
            InitializeComponent();
            quote.Text = quotes[this.index];
            boxView.Color = Color.FromRgb(25, 25, 25);
        }

        void FontSize_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            displayLabel.Text = String.Format("Font Size: {0}", value);
            quote.FontSize = value;
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            if (sender == next)
            {
                this.index++;
                if (index > this.quotes.Length - 1)
                {
                    index = 0;
                }
                quote.Text = this.quotes[index];
            }
            else if (sender == back)
            {
                this.index--;
                if (index < 0)
                {
                    index = this.quotes.Length - 1;
                }
                quote.Text = this.quotes[index];
            }
        }

        void Color_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (sender == red)
            {
                redLabel.Text = String.Format("Red: {0:X2}", (int)e.NewValue);
            }
            if (sender == green)
            {
                greenLabel.Text = String.Format("Green: {0:X2}", (int)e.NewValue);
            }
            if (sender == blue)
            {
                greenLabel.Text = String.Format("Blue: {0:X2}", (int)e.NewValue);
            }
            boxView.Color = Color.FromRgb((int)red.Value,
                                          (int)green.Value,
                                          (int)blue.Value);
        }
        //void OnNextButtonClicked(object sender, EventArgs e)
        //{

        //    this.index++;
        //    if (index > this.quotes.Length-1)
        //    {
        //        index = 0;
        //    }
        //    quote.Text = this.quotes[index];
        //}
        //void OnBackButtonClicked(object sender, EventArgs e)
        //{
        //    this.index--;
        //    if (index < 0)
        //    {
        //        index = this.quotes.Length-1;
        //    }
        //    quote.Text = this.quotes[index];
        //}

    }
}
