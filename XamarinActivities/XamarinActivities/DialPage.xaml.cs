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
    public partial class DialPage : ContentPage
    {
        public DialPage()
        {
            InitializeComponent();
        }

        private void Number_Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var buttonValue = button.Text;
            Number_Label.Text = Number_Label.Text + buttonValue;
        }
    }
}