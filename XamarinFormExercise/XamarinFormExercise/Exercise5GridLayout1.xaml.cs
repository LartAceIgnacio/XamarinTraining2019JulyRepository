using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise5GridLayout1 : ContentPage
    {
        string concat;
        string number;
        public Exercise5GridLayout1()
        {
            InitializeComponent();
        }
        private void ButtonOneClicked(object sender, EventArgs e)
        {
           number = one.GetValue(Button.TextProperty).ToString();
           ShowNumbers(number);
        }
        private void ButtonTwoClicked(object sender, EventArgs e)
        {
            number = two.GetValue(Button.TextProperty).ToString();
            ShowNumbers(number);
        }
        private void ButtonThreeClicked(object sender, EventArgs e)
        {
            number = three.GetValue(Button.TextProperty).ToString();
            ShowNumbers(number);
        }
        private void ButtonFourClicked(object sender, EventArgs e)
        {
            number = four.GetValue(Button.TextProperty).ToString();
            ShowNumbers(number);
        }
        private void ButtonFiveClicked(object sender, EventArgs e)
        {
            number = five.GetValue(Button.TextProperty).ToString();
            ShowNumbers(number);
        }
        private void ButtonSixClicked(object sender, EventArgs e)
        {
            number = six.GetValue(Button.TextProperty).ToString();
            ShowNumbers(number);
        }
        private void ButtonSevenClicked(object sender, EventArgs e)
        {
            number = seven.GetValue(Button.TextProperty).ToString();
            ShowNumbers(number);
        }
        private void ButtonEightClicked(object sender, EventArgs e)
        {
            number = eight.GetValue(Button.TextProperty).ToString();
            ShowNumbers(number);
        }
        private void ButtonNineClicked(object sender, EventArgs e)
        {
            number = nine.GetValue(Button.TextProperty).ToString();
            ShowNumbers(number);
        }
        private void ButtonZeroClicked(object sender, EventArgs e)
        {
          number = zero.GetValue(Button.TextProperty).ToString();
            ShowNumbers(number);
        }
        private void ShowNumbers(string number)
        {

            concat += number;
            result.Text = concat;
           
        }
    }
}