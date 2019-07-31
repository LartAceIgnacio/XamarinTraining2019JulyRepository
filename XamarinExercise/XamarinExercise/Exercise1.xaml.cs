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
    public partial class Exercise1 : ContentPage
    {
        string[] quotes = { "I'll be there for you",
                            "When the rain starts to fall",
                            "Like I've been there Before",
                            "Cause your there for me too" };
        int index = 0;

        public Exercise1()
        {
            InitializeComponent();
            quote.Text = quotes[this.index];
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
    }
}
