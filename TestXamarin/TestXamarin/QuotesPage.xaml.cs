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
    public partial class QuotesPage : ContentPage
    {

        String[] quotes = new string[]
        {
                "Close your eyes",
                ""
        };

        int i = 0;

        public QuotesPage()
        {
            InitializeComponent();
            SetQuote(quotes[i]);
            Slider.Value = 16;
        }

        public void SetQuote(String text)
        {
            this.quote.Text = text;
        }

        private void BackBtn_Clicked(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i = quotes.Length - 1;
            }
            else
            {
                i--;
            }

            SetQuote(quotes[i]);
        }

        private void NextBtn_Clicked(object sender, EventArgs e)
        {
            if (i == quotes.Length - 1)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            SetQuote(quotes[i]);
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.FontSizeLabel.Text = String.Format("Font Size: {0}", ((int)e.NewValue).ToString());
            this.FontSizeLabel.FontSize = (int)e.NewValue;
            this.quote.FontSize = e.NewValue;
        }
    }
}