using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinActivities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        int QuoteIndex = 0;
        List<String> Quotes;

        public QuotesPage()
        {
            InitializeComponent();

            Quotes = new List<string>()
            {
                "Better to remain silent and be thought a fool than to speak out and remove all doubt.'– Abraham Lincoln",
                "Nobody realizes that some people expend tremendous energy merely to be normal.– Albert Camus",
                "The average dog is a nicer person than the average person.– Andy Rooney",
                "Wine is constant proof that God loves us and loves to see us happy.– Benjamin Franklin",
                "The world is full of magical things patiently waiting for our wits to grow sharper.– Bertrand Russell",
                "The surest sign that intelligent life exists elsewhere in the universe is that it has never tried to contact us.– Bill Watterson"
            };
            Quote_Label.Text = Quotes[QuoteIndex];
        }

        private void Back_Button_Clicked(object sender, EventArgs e)
        {
            if(QuoteIndex == 0)
            {
                QuoteIndex = Quotes.Count-1;
            }
            else
            {
                QuoteIndex--;
            }
            Quote_Label.Text = Quotes[QuoteIndex];
        }

        private void Next_Button_Clicked(object sender, EventArgs e)
        {
            if (QuoteIndex == Quotes.Count-1)
            {
                QuoteIndex = 0;
            }
            else
            {
                QuoteIndex++;
            }
            Quote_Label.Text = Quotes[QuoteIndex];
        }
    }
}