using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quotes : ContentPage
    {
        public Quotes()
        {
            InitializeComponent();
            DisplayedQuote.Text = _quotes[quoteNumber];
            FontSlider.Value = 16;
            FontSize.Text = String.Format("Font Size : {0:0}", FontSlider.Value);
            DisplayedQuote.FontSize = FontSlider.Value;
        }
        String[] _quotes = new string[]
        {
            "1.Suffering is a brand of a warrior",
            "2.Few men greater then me",
            "3.You Ought to look farther ahead",
            "4.Chaos is a ladder",
            "5.SThe things we do for love"
        };
        int quoteNumber = 0;
        private void Back_Clicked(object sender, EventArgs e)
        {
            if (quoteNumber == 0)
            {
                quoteNumber = _quotes.Length-1;
            }
            else
            {
                quoteNumber -= 1;
            }
            DisplayedQuote.Text = _quotes[quoteNumber];
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            if (quoteNumber == _quotes.Length-1)
            {
                quoteNumber =0;
            }
            else
            {
                quoteNumber += 1;
            }
            DisplayedQuote.Text = _quotes[quoteNumber];
        }

        private void FontSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            FontSize.Text= String.Format("Font Size : {0:0}", FontSlider.Value);
            DisplayedQuote.FontSize = FontSlider.Value;
        }
    }
}