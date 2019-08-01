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
    public partial class Grid_Exercise1 : ContentPage
    {
        public Grid_Exercise1()
        {
            InitializeComponent();
        }

        private void numberButton_Clicked(object sender, EventArgs e)
        {
            string inputText = (sender as Button).Text;
            string labelText = numDisplay.Text;

            labelText += inputText;
            numDisplay.Text = labelText;
        }
    }
}