using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinActivities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridLayout1 : ContentPage
    {
        public GridLayout1()
        {
            InitializeComponent();
            lblResult.Text = "";
        }

        private void LblResult_ValueChanged(object sender, EventArgs e)
        {
            if (lblResult.Text.Length+1 <= 12)
            {
                Button button = (Button)sender;
                string pressed = button.Text;
                lblResult.Text += pressed;
            }
            else
            {
                DisplayAlert("Dial", "You reached the maximun phone number", "OK");
            }
        }

        private void BtnDial_Clicked(object sender, EventArgs e)
        {
            var dialing = "Calling " + lblResult.Text + "...";
            DisplayAlert("Dial", dialing , "Cancel");
            lblResult.Text = "";
        }
    }
}