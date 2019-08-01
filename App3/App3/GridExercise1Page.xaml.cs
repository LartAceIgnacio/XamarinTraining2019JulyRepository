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
    public partial class GridExercise1Page : ContentPage
    {
        public GridExercise1Page()
        {
            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            displayedNumbers.Text += '1';
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {
            displayedNumbers.Text += '2';
        }
        private void Button3_Clicked(object sender, EventArgs e)
        {
            displayedNumbers.Text += '3';
        }
        private void Button4_Clicked(object sender, EventArgs e)
        {
            displayedNumbers.Text += '4';
        }
        private void Button5_Clicked(object sender, EventArgs e)
        {
            displayedNumbers.Text += '5';
        }
        private void Button6_Clicked(object sender, EventArgs e)
        {
            displayedNumbers.Text += '6';
        }
        private void Button7_Clicked(object sender, EventArgs e)
        {
            displayedNumbers.Text += '7';
        }
        private void Button8_Clicked(object sender, EventArgs e)
        {
            displayedNumbers.Text += '8';
        }
        private void Button9_Clicked(object sender, EventArgs e)
        {
            displayedNumbers.Text += '9';
        }
        private void Button0_Clicked(object sender, EventArgs e)
        {
            displayedNumbers.Text += '0';
        }
    }
}