using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridExercise2Page : ContentPage
    {
        public GridExercise2Page()
        {
            InitializeComponent();
        }

        private void Number_Input(object sender, EventArgs e)
        {
            var _button = (Button)sender;
            displayedNumbersLabel.Text += _button.Text;
            displayedNumbersLabel.Text = String.Format("{0:n0}", Double.Parse(displayedNumbersLabel.Text));
        }

        private void ButtonC_Clicked(object sender, EventArgs e)
        {
            displayedNumbersLabel.Text = "";
        }
    }
}