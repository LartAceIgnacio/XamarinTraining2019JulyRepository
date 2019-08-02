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

        String[] _quotes = new string[]
        {
                "Chance favors the prepared mind",
                "Hardwork and discipline beats talent",
                "Let no man's ghost come back to say my training let me down - NY Fire Department Training Academy",
                "The best plan is only good intentions unless it degenerates into work - Peter Drucker",
                "Unattended children will be given espresso",
                "Bawal umihi dito"
        };

        int i = 0;

        public QuotesPage()
        {
            InitializeComponent();
            this.Slider.Value = 16;
            SetQuote(_quotes[i]);
        }

        public void SetQuote(String text)
        {
            this.quote.Text = text;
        }

        private void BackBtn_Clicked(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i = _quotes.Length - 1;
            }
            else
            {
                i--;
            }

            SetQuote(_quotes[i]);
        }

        private void NextBtn_Clicked(object sender, EventArgs e)
        {
            if (i == _quotes.Length - 1)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            SetQuote(_quotes[i]);
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.FontSizeLabel.Text = String.Format("Font Size: {0}", ((int)e.NewValue).ToString());
            this.FontSizeLabel.FontSize = (int)e.NewValue;
            this.quote.FontSize = e.NewValue;
        }
    }
}