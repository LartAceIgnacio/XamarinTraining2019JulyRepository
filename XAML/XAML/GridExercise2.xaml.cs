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
        public Boolean HasOperation = false;
        public int CommaCtr = 0;
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
                //if(CommaCtr>1)
                //{
                //    lblResult.Text = lblResult.Text +"," +_button.Text.ToString();
                //    CommaCtr = 0;
                //}
                //else
                //{
                //    lblResult.Text = lblResult.Text + _button.Text.ToString();
                //    CommaCtr += 1;
                //}
                lblResult.Text = lblResult.Text + _button.Text.ToString();
                var _formatNumber = double.Parse(lblResult.Text);
                lblResult.Text = _formatNumber.ToString("N0");
            }
        }

        private void OperationButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}