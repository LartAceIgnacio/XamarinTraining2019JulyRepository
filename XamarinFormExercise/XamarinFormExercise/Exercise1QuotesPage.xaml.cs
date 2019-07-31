using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormExercise.Model;

namespace XamarinFormExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise1QuotesPage : ContentPage
    {
        List<QuotesPage> quotePage = new List<QuotesPage>()
            {
                new QuotesPage{QuotePage="I've missed more than 9000 shots in my career. I've lost almost 300 games. 26 times, I've been trusted to take the game winning shot and missed. I've failed over and over and over again in my life. And that is why I succeed."},
                new QuotesPage{QuotePage="Sports build good habits, confidence, and discipline. They make players into community leaders and teach them how to strive for a goal, handle mistakes, and cherish growth opportunities."},
                new QuotesPage{QuotePage="Sports teaches you character, it teaches you to play by the rules, it teaches you to know what it feels like to win and lose-it teaches you about life."},
                new QuotesPage{QuotePage="Gold medals aren't really made of gold. They're made of sweat, determination, and a hard-to-find alloy called guts."},
                new QuotesPage{QuotePage="Love is in the air"},
                new QuotesPage{QuotePage="Don't give up"},
                new QuotesPage{QuotePage="Hardwork always rewarded"},
                new QuotesPage{QuotePage="Some people want it to happen, some wish it would happen, others make it happen."},
                new QuotesPage{QuotePage="Talent wins games, but teamwork and intelligence wins championships."},
                new QuotesPage{QuotePage="My father used to say that it's never too late to do anything you wanted to do. And he said, 'You never know what you can accomplish until you try.'"},
                new QuotesPage{QuotePage="Sometimes, things may not go your way, but the effort should be there every single night."},
                new QuotesPage{QuotePage="Believe in yourself! Have faith in your abilities! Without a humble but reasonable confidence in your own powers you cannot be successful or happy."}
           
            };
        int selectedQuote;
        List<int> index = new List<int>();

        public Exercise1QuotesPage()
        {
            InitializeComponent();
            var Quotes = quotePage.Select(x => x.QuotePage).ToArray();
            slider.Value = 1;
            result.Text = Quotes[0];
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
           
            LabelFontSize.Text = String.Format("{0:0,0}", e.NewValue);
            result.FontSize = Int32.Parse(LabelFontSize.GetValue(Label.TextProperty).ToString());
        }
        private void OnNextClicked(object sender, EventArgs e)
        {
          
            var Quotes = quotePage.Select(x => x.QuotePage).ToArray();
            if (index.Count == Quotes.Length)
            {
                index.Clear();
                selectedQuote = index.Count;
                index.Add(selectedQuote);
                result.Text = Quotes[selectedQuote];
            }
            else
            {
                selectedQuote = index.Count;
                index.Add(selectedQuote);
                result.Text = Quotes[selectedQuote];
            }
        }
        private void OnBackClicked(object sender, EventArgs e)
        {
            var Quotes = quotePage.Select(x => x.QuotePage).ToArray();
            if(index.Count == 0)
            {
                for(int i=0; i<Quotes.Length; i++)
                {
                    index.Add(i);
                }
                selectedQuote = index.Count - 1;
                index.RemoveAt(selectedQuote);
                result.Text = Quotes[selectedQuote];
            }
            else
            {
                selectedQuote = index.Count - 1;
                index.RemoveAt(selectedQuote);
                result.Text = Quotes[selectedQuote];
            }

        }
    }
}