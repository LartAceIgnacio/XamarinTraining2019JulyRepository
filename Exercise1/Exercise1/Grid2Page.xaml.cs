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
            ClearEntry(this, null);
        }

        private void ClearEntry(object sender, EventArgs e)
        {
            this.numberResultLabel.Text = "0";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var normalButton = (Button)sender;
            var input = this.numberResultLabel.Text + normalButton.Text;
            numberResultLabel.Text = String.Format("{0:n0}", double.Parse(input));
        }
    }
}