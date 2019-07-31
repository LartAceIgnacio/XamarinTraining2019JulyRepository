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
                new QuotesPage{QuotePage="A1"},
                new QuotesPage{QuotePage="B2"},
                new QuotesPage{QuotePage="C3"},
                new QuotesPage{QuotePage="A4"},
                new QuotesPage{QuotePage="B5"},
                new QuotesPage{QuotePage="C6"}
                //new QuotesPage{QuotePage="A"},
                //new QuotesPage{QuotePage="B"},
                //new QuotesPage{QuotePage="A"},
                //new QuotesPage{QuotePage="B"},
                //new QuotesPage{QuotePage="C"},
                //new QuotesPage{QuotePage="A"},
                //new QuotesPage{QuotePage="B"},
                //new QuotesPage{QuotePage="A"},
                //new QuotesPage{QuotePage="B"},
                //new QuotesPage{QuotePage="C"},
                //new QuotesPage{QuotePage="A"},
                //new QuotesPage{QuotePage="B"},
                //new QuotesPage{QuotePage="A"},
                //new QuotesPage{QuotePage="B"},
                //new QuotesPage{QuotePage="C"},
                //new QuotesPage{QuotePage="A"},
                //new QuotesPage{QuotePage="B"}

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