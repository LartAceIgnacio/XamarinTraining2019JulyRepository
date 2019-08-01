using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Grid_Exercise2 : ContentPage
    {
        public Grid_Exercise2()
        {
            InitializeComponent();
        }

        private void numberButton_Clicked(object sender, EventArgs e)
        {
            string inputText = (sender as Button).Text;
            string labelText = numDisplay.Text.Replace(",","");
            //int num = System.Convert.ToInt32(inputText);

            if (numDisplay.Text.Length > 15)
            {
                return;
            }
            if (numDisplay.Text == "0")
            {
               numDisplay.Text = inputText;
            }
            else
            {
                labelText += inputText;
                labelText = Convert.ToDecimal(labelText).ToString("N0");
                numDisplay.Text = labelText;
            }
        }

        private void clearButton_Clicked(object sender, EventArgs e)
        {
            numDisplay.Text = "0";
        }
    }
}