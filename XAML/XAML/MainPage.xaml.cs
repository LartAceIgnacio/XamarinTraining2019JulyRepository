using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAML
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public int index = 0;
        List<string> Quote = new List<string>
            {
                "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe",
                "If you can't explain it to a six year old, you don't understand it yourself.",
                "If you want your children to be intelligent, read them fairy tales. If you want them to be more intelligent, read them more fairy tales.Quote3",
                "Reality is merely an illusion, albeit a very persistent one.",
                "Any fool can know. The point is to understand."
            };

        public MainPage()
        {
            InitializeComponent();
            quote.Text = Quote[index];
        }

        private void NextQuote(object sender, EventArgs e)
        {
            if (index == 4)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            this.quote.Text = Quote[index];
        }

        private void BackQuote(object sender, EventArgs e)
        {
            if (index == 0)
            {
                index = 4;
            }
            else
            {
                index--;
            }
            this.quote.Text = Quote[index];
        }
    }
}
