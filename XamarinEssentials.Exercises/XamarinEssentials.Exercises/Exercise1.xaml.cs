using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise1 : ContentPage
    {
        public string DisplayedQuotes;
        public string[] Quotes;
        public int index = 0;

        public Exercise1()
        {
            InitializeComponent();

            Quotes = new string[5]
            {
                "Everyone needs a little inspiration from time to time.",
                "Whether you’re going through a break up, you’ve just lost your job, or you simply woke up feeling a little insecure this morning—we’ve all had these days.",
                "Feeding your mind inspiring quotes daily is a great practice to boost your positivity.",
                "I’m selfish, impatient and a little insecure. I make mistakes, I am out of control and at times hard to handle. But if you can’t handle me at my worst, then you sure as hell don’t deserve me at my best.",
                "The first step toward success is taken when you refuse to be a captive of the environment in which you first find yourself."
            };

            this.QuoteLabel.Text = Quotes[index];
        }

        private void Next(object sender, EventArgs e)
        {
            if (index == 4)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            this.QuoteLabel.Text = Quotes[index];
        }

        private void Back(object sender, EventArgs e)
        {
            if (index == 0)
            {
                index = 4;
            }
            else
            {
                index--;
            }

            this.QuoteLabel.Text = Quotes[index];
        }
    }
}