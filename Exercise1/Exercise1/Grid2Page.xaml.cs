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
            OnClear(this, null);
        }

        private void clearEntry(object sender, EventArgs e)
        {
            this.numberResult.Text = "0";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var normalButton = (Button)sender;
            var input = this.numberResult.Text + normalButton.Text;
            numberResult.Text = String.Format("{0:n0}", double.Parse(input));
        }
    }
}