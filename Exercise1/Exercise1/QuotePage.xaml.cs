using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercise1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class QuotePage : ContentPage
    {
        public String[] quotes;
        public int quotePage = 0;

        public QuotePage()
        {
            InitializeComponent();
            quotes = new String[5]
            {
                "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.",
                "Be yourself; everyone else is already taken.",
                "A room without books is like a body without a soul.",
                "Be the change that you wish to see in the world.",
                "Yesterday was a history, tomorrow's a mystery, but today is a gift, that is why we call it Present",
            };
            this.Quoted.Text = quotes[quotePage];
        }
        void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            getQuote.Text = String.Format("{0:0}", e.NewValue);
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            if (quotePage < 4)
            {
                quotePage++;
                this.Quoted.Text = quotes[quotePage];
            }
            else
            {
                quotePage = 0;
                this.Quoted.Text = quotes[quotePage];
            }
        }
        private void BackButton_Clicked(object sender, EventArgs e)
        {
            if (quotePage > 0)
            {
                quotePage--;
                this.Quoted.Text = quotes[quotePage];
            }
            else
            {
                quotePage = 4;
                this.Quoted.Text = quotes[quotePage];
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
