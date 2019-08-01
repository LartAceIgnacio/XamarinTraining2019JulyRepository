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
    public partial class Grid1Page : ContentPage
    {
        public Grid1Page()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button phoneButton = (Button)sender;
            string pressed = phoneButton.Text;
            this.phoneNum.Text += pressed;
        }
    }
}