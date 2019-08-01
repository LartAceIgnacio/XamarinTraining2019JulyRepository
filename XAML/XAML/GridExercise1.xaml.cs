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
            var _button = (Button)sender;
            lblNumber.Text = lblNumber.Text + _button.Text.ToString();
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            if (lblNumber.Text.Length != 0)
            {
                string _text = lblNumber.Text;
                _text = _text.Remove(lblNumber.Text.Length - 1);
                lblNumber.Text = _text;
            }
        }
    }
}