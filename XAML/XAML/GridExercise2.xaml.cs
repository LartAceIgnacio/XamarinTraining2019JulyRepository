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
    public partial class GridExercise2 : ContentPage
    {
        public bool HasOperation = false;
        public GridExercise2()
        {
            InitializeComponent();
        }

        private void NumberButton_Clicked(object sender, EventArgs e)
        {
            var _button = (Button)sender;
            if (lblResult.Text == "0" || HasOperation==true)
            {
                lblResult.Text = _button.Text.ToString();
            }
            else
            {
                if (lblResult.Text.Replace(",", "").Length!=9)
                {
                    lblResult.Text = lblResult.Text + _button.Text.ToString();
                    var _formatNumber = double.Parse(lblResult.Text);
                    lblResult.Text = _formatNumber.ToString("N0");
                }
            }
        }

        private void OperationButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}