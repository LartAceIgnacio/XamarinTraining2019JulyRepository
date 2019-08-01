using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridExercise1 : ContentPage
    {
        public GridExercise1()
        {
            InitializeComponent();
        }

        private void NumberButton_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var number = button.Text;

            lblNumber.Text = lblNumber.Text + number;
        }


    }
}