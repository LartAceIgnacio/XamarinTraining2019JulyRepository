using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise1
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Grid2Page : ContentPage
    {

        public Grid2Page()
        {
            InitializeComponent();
            
        }

        private void clearEntry(object sender, EventArgs e)
        {
            this.resultCalc.Text = "0";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button normalButton = (Button)sender;
            string pressed = normalButton.Text;
            this.resultCalc.Text += pressed;

        }
    }
}