using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinExcercise
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<string> quotesList = new List<string>();
        int index = 0;

        
        public MainPage()
        {
            InitializeComponent();
            BuildQuotes();
            this.quote.Text = quotesList[index];

        }

        public void BuildQuotes()
        {
            quotesList.Add("You can do anything, but not everything.");
            quotesList.Add("Perfection is achieved, not when there is nothing more to add, but when there is nothing left to take away.");
            quotesList.Add("The richest man is not he who has the most, but he who needs the least.");
            quotesList.Add("You miss 100 percent of the shots you never take.");
            quotesList.Add("Courage is not the absence of fear, but rather the judgement that something else is more important than fear.");
            quotesList.Add("You must be the change you wish to see in the world.");
            quotesList.Add("When hungry, eat your rice; when tired, close your eyes. Fools may laugh at me, but wise men will know what I mean.");
            quotesList.Add("The third-rate mind is only happy when it is thinking with the majority. The second-rate mind is only happy when it is thinking with the minority. The first-rate mind is only happy when it is thinking.");
            quotesList.Add("To the man who only has a hammer, everything he encounters begins to look like a nail.");
            quotesList.Add("We are what we repeatedly do; excellence, then, is not an act but a habit.");
            quotesList.Add("A wise man gets more use from his enemies than a fool from his friends.");
            quotesList.Add("Do not seek to follow in the footsteps of the men of old; seek what they sought.");
            quotesList.Add("Everyone is a genius at least once a year. The real geniuses simply have their bright ideas closer together.");
            quotesList.Add("The real voyage of discovery consists not in seeking new lands but seeing with new eyes.");
            quotesList.Add("What we think, or what we know, or what we believe is, in the end, of little consequence. The only consequence is what we do.");
            quotesList.Add("Work like you don’t need money, love like you’ve never been hurt, and dance like no one’s watching.");
            quotesList.Add("Try a thing you haven’t done three times. Once, to get over the fear of doing it. Twice, to learn how to do it. And a third time, to figure out whether you like it or not.");
            quotesList.Add("Even if you’re on the right track, you’ll get run over if you just sit there.");
            quotesList.Add("People often say that motivation doesn’t last. Well, neither does bathing – that’s why we recommend it daily.");
            quotesList.Add("Before I got married I had six theories about bringing up children; now I have six children and no theories.");
        }

        private void Next(object sender, EventArgs e)
        {
            if(index < 19)
            {
                index++;
                this.quote.Text = quotesList[index];
            }


        }
        private void Previous(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                this.quote.Text = quotesList[index];
            }

        }
    }
}
