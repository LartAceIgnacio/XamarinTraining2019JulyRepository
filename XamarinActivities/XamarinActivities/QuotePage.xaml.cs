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
    public partial class QuotePage : ContentPage
    {
        private int count;
        private List<string> quoteList;
        public QuotePage()
        {
            InitializeComponent();
            slider.Value = 20;
            slider.Maximum = 50;
            slider.Minimum = 0;

            quoteList = new List<String>()
            {
               "Don't cry because it's over, smile because it happened.",
               "Be who you are and say what you feel, because those who mind don't matter, and those who matter don't mind",
               "A room without books is like a body without a soul.",
               "You only live once, but if you do it right, once is enough",
               "Be the change that you wish to see in the world.",
               "In three words I can sum up everything I've learned about life: it goes on.",
               "If you want to know what a man's like, take a good look at how he treats his inferiors, not his equals.",
               "No one can make you feel inferior without your consent.",
               "If you tell the truth, you don't have to remember anything.",
               "Be yourself; everyone else is already taken.",
               "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe."
            };

            count = 0;
            quote.Text = quoteList[count];
        }

        private void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            if (count == 0)
            {
                quote.Text = quoteList[count];
                count = quoteList.Count - 1;
            } else
            {
                quote.Text = quoteList[count-1];
                count -= 1;
            }
        }

        private void OnNextPageButtonClicked(object sender, EventArgs e)
        {

            if (count == quoteList.Count-1) //last index
            {
                quote.Text = quoteList[quoteList.Count - 1];
                count = 0;
            }
            else
            {
                quote.Text = quoteList[count + 1];
                count += 1;
            }
        }
    }
}